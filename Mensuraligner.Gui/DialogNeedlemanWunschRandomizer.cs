using mei2Sequence;
using mei2Sequence.Model;
using Mensuraligner;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Mensuraligner.Gui
{
  public partial class DialogNeedlemanWunschRandomizer : Form
  {
    #region Members
    private List<List<ObjectInSequence>> lstRandomizedObjectsA, lstRandomizedObjectsB;

    // Initialize the Randomizer
    private Random rsm = new Random((int)DateTime.Now.Ticks);

    /// <summary>
    /// Member if we have locked sequences
    /// </summary>
    private bool bolSequencesLocked = false;
    #endregion

    #region Konstruktor
    /// <summary>
    /// Constructor
    /// </summary>
    public DialogNeedlemanWunschRandomizer()
    {
      InitializeComponent();

      this.listBoxChosenCompares.DisplayMember = nameof(CompareObject.DisplayText);
    }
    #endregion

    #region Setting Data
    /// <summary>
    /// Sets the data needed in the dialog
    /// </summary>
    /// <param name="_dicSequences2Filename"></param>
    public void SetData(Dictionary<string, List<Sequence>> _dicSequences2Filename)
    {
      // Pass the Files to the Controls
      this.controlSequencesA.SetData(_dicSequences2Filename);
      this.controlSequencesB.SetData(_dicSequences2Filename);
    }
    #endregion

    #region Eventhandlers
    private void btnRandomSequenceModel_Click(object sender, EventArgs e)
    {
      // Check if we either have an saved Sequence or the user has chosen a sequence to use
      if (this.listBoxChosenCompares.Items.Count == 0 && this.lstRandomizedObjectsA == null && this.lstRandomizedObjectsB == null)
      {
        MessageBox.Show("Please select at least one compare or load a randomized set of data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Extract the options
      NeedlemanWunschOptions options = this.controlOptions.Options;

      List<ObjectInSequence> lstSequenceA = new List<ObjectInSequence>(), lstSequenceB = new List<ObjectInSequence>();
      // Make 2 List for the ObjectsInSequences
      List<List<ObjectInSequence>> lstSequencesA = new List<List<ObjectInSequence>>(), lstSequencesB = new List<List<ObjectInSequence>>();

      // Differ if we have loaded sequences or use the chosen compares
      if (this.lstRandomizedObjectsA != null && this.lstRandomizedObjectsB != null)
      {
        lstSequenceA = this.lstRandomizedObjectsA[0];
        lstSequencesA = this.lstRandomizedObjectsA.GetRange(1, this.lstRandomizedObjectsA.Count - 1);
        lstSequenceB = this.lstRandomizedObjectsB[0];
        lstSequencesB = this.lstRandomizedObjectsB.GetRange(1, this.lstRandomizedObjectsB.Count - 1);

        // GO!
        ConcurrentBag<Tuple<decimal, int, int, int, int>> lstDistances = new ConcurrentBag<Tuple<decimal, int, int, int, int>>();

        // Create the Alignment
        NeedlemanWunsch nw = new NeedlemanWunsch(lstSequenceA, lstSequenceB, options, true);

        // DebugCode if we need to see the Original Alignment
        //DialogNeedlemanWunschShowAlign dialogShow = new DialogNeedlemanWunschShowAlign();
        //dialogShow.SetData(nw);
        //dialogShow.ShowDialog(this.FindForm());

        // Now loop over the created sequences and compare all of them
        Parallel.ForEach(lstSequencesA, seqA =>
        {
          Parallel.ForEach(lstSequencesB, seqB =>
          {
            // Build the alignment
            NeedlemanWunsch nwRandom = new NeedlemanWunsch(seqA, seqB, options, true);
            // Now we need the distance
            lstDistances.Add(Tuple.Create(nwRandom.Distance, nwRandom.NumberOfChanges, nwRandom.Backtraces.Min(bt => bt.WayBack.Count), nwRandom.SequenceA.Count, nwRandom.SequenceB.Count));
          });
        });

        MessageBox.Show(this.FindForm(), $"Distance: {nw.Distance}{Environment.NewLine}" +
        $"Average Random Distance: {lstDistances.Sum(dis => dis.Item1) / lstDistances.Count}{Environment.NewLine}" +
        $"Minimum Random Distance: {lstDistances.Min(dis => dis.Item1)}{Environment.NewLine}" +
        $"Maximum Random Distance: {lstDistances.Max(dis => dis.Item1)}{Environment.NewLine}");

        // Export all distances if wanted
        if (this.saveFileDialogCSV.ShowDialog(this.FindForm()) == DialogResult.OK)
        {
          SaveCSV(this.saveFileDialogCSV.FileName, nw, lstDistances, lstSequenceA, lstSequenceB);
        }
      }
      else
      {
        // Here we loop over the chosen Compares
        foreach (object objAktuell in this.listBoxChosenCompares.Items)
        {
          if (objAktuell is CompareObject compObj)
          {
            // Create the original sequences - Copy the choosen ones from the List if possible as default
            lstSequenceA = new List<ObjectInSequence>();
            lstSequenceB = new List<ObjectInSequence>();
            compObj.SequenceA.ForEach(item => lstSequenceA.AddRange(item.ObjectsInSequence));
            compObj.SequenceB.ForEach(item => lstSequenceB.AddRange(item.ObjectsInSequence));

            // Check if we have locked sequences or create new ones
            if (compObj.RandomizedSequencesA != null && compObj.RandomizedSequencesB != null)
            {
              lstSequencesA = new List<List<ObjectInSequence>>(compObj.RandomizedSequencesA);
              lstSequencesB = new List<List<ObjectInSequence>>(compObj.RandomizedSequencesB);
            }
            else
            {
              RandomizeSequence(compObj.SequenceA, lstSequencesA);
              RandomizeSequence(compObj.SequenceB, lstSequencesB);
            }

            // Now we have everything, runrunrun
            ConcurrentBag<Tuple<decimal, int, int, int, int>> lstDistances = new ConcurrentBag<Tuple<decimal, int, int, int, int>>();

            // Create the Alignment
            NeedlemanWunsch nw = new NeedlemanWunsch(lstSequenceA, lstSequenceB, options, true);

            // DebugCode if we need to see the Original Alignment
            //DialogNeedlemanWunschShowAlign dialogShow = new DialogNeedlemanWunschShowAlign();
            //dialogShow.SetData(nw);
            //dialogShow.ShowDialog(this.FindForm());

            // Now loop over the created sequences and compare all of them
            Parallel.ForEach(lstSequencesA, seqA =>
            {
              Parallel.ForEach(lstSequencesB, seqB =>
              {
                // Build the alignment
                NeedlemanWunsch nwRandom = new NeedlemanWunsch(seqA, seqB, options, true);
                // Now we need the distance
                lstDistances.Add(Tuple.Create(nwRandom.Distance, nwRandom.NumberOfChanges, nwRandom.Backtraces.Min(bt => bt.WayBack.Count), nwRandom.SequenceA.Count, nwRandom.SequenceB.Count));

                //if (nwRandom.Distance < 35m)
                //{
                //  lstSusp.Add(nwRandom);
                //}
              });
            });

            // We get the filename from the CompareObject
            string strSavePath = Path.Combine(Path.GetDirectoryName(compObj.SavePath), Path.GetFileNameWithoutExtension(compObj.SavePath) + $"_{options.Name}" + Path.GetExtension(compObj.SavePath));
            SaveCSV(strSavePath, nw, lstDistances, lstSequenceA, lstSequenceB);
            // Also save the Sequences
            string strSavePathSequencesA, strSavePathSequencesB;
            strSavePathSequencesA = Path.Combine(Path.GetDirectoryName(compObj.SavePath), Path.GetFileNameWithoutExtension(compObj.SavePath) + "_sequencesA.xml");
            strSavePathSequencesB = Path.Combine(Path.GetDirectoryName(compObj.SavePath), Path.GetFileNameWithoutExtension(compObj.SavePath) + "_sequencesB.xml");
            // Insert the original Sequence in A and save them
            lstSequencesA.Insert(0, lstSequenceA);
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<List<ObjectInSequence>>));
            using (XmlWriter writer = XmlWriter.Create(strSavePathSequencesA))
            {
              serializer.WriteObject(writer, lstSequencesA);
              writer.Close();
            }
            // Same for B
            lstSequencesB.Insert(0, lstSequenceB);
            using (XmlWriter writer = XmlWriter.Create(strSavePathSequencesB))
            {
              serializer.WriteObject(writer, lstSequencesB);
              writer.Close();
            }

            // Save the options?
            
          }
        }

        // Show something so the user knows were done
        MessageBox.Show(this.FindForm(), "Done!");
      }
    }

    private void btnLoadA_Click(object sender, EventArgs e)
    {
      if (this.openFileDialogXML.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        DataContractSerializer serializer = new DataContractSerializer(typeof(List<List<ObjectInSequence>>));
        using (FileStream fs = new FileStream(this.openFileDialogXML.FileName, FileMode.Open))
        {
          this.lstRandomizedObjectsA = (List<List<ObjectInSequence>>)serializer.ReadObject(fs);
          fs.Close();
        }
        SetControlStatus();
      }
    }

    private void btnSaveA_Click(object sender, EventArgs e)
    {
      // Safetycheck
      if (this.lstRandomizedObjectsA != null)
      {
        // Ask for save destination
        if (this.saveFileDialogXML.ShowDialog(this.FindForm()) == DialogResult.OK)
        {
          // Save the sequences to the destination
          DataContractSerializer serializer = new DataContractSerializer(typeof(List<List<ObjectInSequence>>));
          using (XmlWriter writer = XmlWriter.Create(this.saveFileDialogXML.FileName))
          {
            serializer.WriteObject(writer, this.lstRandomizedObjectsA);
            writer.Close();
          }
        }
      }
    }

    private void btnUnloadA_Click(object sender, EventArgs e)
    {
      this.lstRandomizedObjectsA = null;
      SetControlStatus();
    }

    private void btnViewA_Click(object sender, EventArgs e)
    {

    }

    private void btnLoadB_Click(object sender, EventArgs e)
    {
      if (this.openFileDialogXML.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        DataContractSerializer serializer = new DataContractSerializer(typeof(List<List<ObjectInSequence>>));
        using (FileStream fs = new FileStream(this.openFileDialogXML.FileName, FileMode.Open))
        {
          this.lstRandomizedObjectsB = (List<List<ObjectInSequence>>)serializer.ReadObject(fs);
          fs.Close();
        }
        SetControlStatus();
      }
    }

    private void btnSaveB_Click(object sender, EventArgs e)
    {
      // Safetycheck
      if (this.lstRandomizedObjectsB != null)
      {
        // Ask for save destination
        if (this.saveFileDialogXML.ShowDialog(this.FindForm()) == DialogResult.OK)
        {
          // Save the sequences to the destination
          DataContractSerializer serializer = new DataContractSerializer(typeof(List<List<ObjectInSequence>>));
          using (XmlWriter writer = XmlWriter.Create(this.saveFileDialogXML.FileName))
          {
            serializer.WriteObject(writer, this.lstRandomizedObjectsB);
            writer.Close();
          }
        }
      }
    }

    private void btnUnloadB_Click(object sender, EventArgs e)
    {
      this.lstRandomizedObjectsB = null;
      SetControlStatus();
    }

    private void btnAddCompare_Click(object sender, EventArgs e)
    {
      // Ceck if at least 1 sequence is selected in A and B
      if (this.controlSequencesA.SequencesSelected.Count == 0)
      {
        MessageBox.Show(this.FindForm(), "Please select at least one sequence in A to compare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (this.controlSequencesB.SequencesSelected.Count == 0)
      {
        MessageBox.Show(this.FindForm(), "Please select at least one sequence in B to compare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (string.IsNullOrEmpty(this.txtSavePath.Text))
      {
        MessageBox.Show(this.FindForm(), "Please select a savepath!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Check if the Filename already exists in another CompareObject
      foreach (object objAktuell in this.listBoxChosenCompares.Items)
      {
        if (objAktuell is CompareObject compObj && compObj.SavePath == this.txtSavePath.Text)
        {
          MessageBox.Show(this.FindForm(), "The chosen filename is already in use by another Compare, please select another filename!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      // Create a new CompareObject
      CompareObject compareNew = new CompareObject(this.controlSequencesA.SequencesSelected, this.controlSequencesB.SequencesSelected, this.txtSavePath.Text);

      this.listBoxChosenCompares.Items.Add(compareNew);
      // And clear the items in the sequencelists
      this.controlSequencesA.ResetSelectedSequences();
      this.controlSequencesB.ResetSelectedSequences();
    }

    private void btnChoseSafepath_Click(object sender, EventArgs e)
    {
      if (this.saveFileDialogCSV.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        this.txtSavePath.Text = this.saveFileDialogCSV.FileName;
      }
    }

    private void btnLockSequences_Click(object sender, EventArgs e)
    {
      if (this.bolSequencesLocked)
      {
        // We have locked sequences - unlock all
        foreach (object objAktuell in this.listBoxChosenCompares.Items)
        {
          if (objAktuell is CompareObject compObj)
          {
            compObj.RandomizedSequencesA = null;
            compObj.RandomizedSequencesB = null;
          }
        }

        this.btnLockSequences.Text = "Lock";
        this.bolSequencesLocked = false;
      }
      else
      {
        List<List<ObjectInSequence>> lstRandomizedSequences;
        // We don't have locked sequences - lock them all
        foreach (object objAktuell in this.listBoxChosenCompares.Items)
        {
          if (objAktuell is CompareObject compObj)
          {
            lstRandomizedSequences = new List<List<ObjectInSequence>>();
            RandomizeSequence(compObj.SequenceA, lstRandomizedSequences);
            compObj.RandomizedSequencesA = lstRandomizedSequences;

            lstRandomizedSequences = new List<List<ObjectInSequence>>();
            RandomizeSequence(compObj.SequenceB, lstRandomizedSequences);
            compObj.RandomizedSequencesB = lstRandomizedSequences;
          }
        }

        this.btnLockSequences.Text = "Unlock";
        this.bolSequencesLocked = true;
      }

      this.SetControlStatus();
    }
    #endregion

    #region Helpers
    private void SetControlStatus()
    {
      this.btnUnloadA.Enabled = this.lstRandomizedObjectsA != null;
      this.btnUnloadB.Enabled = this.lstRandomizedObjectsB != null;

      this.controlSequencesA.Enabled = this.bolSequencesLocked == false;
      this.controlSequencesB.Enabled = this.bolSequencesLocked == false;
      this.btnAddCompare.Enabled = this.bolSequencesLocked == false;
      this.txtSavePath.Enabled = this.bolSequencesLocked == false;
      this.btnChoseSafepath.Enabled = this.bolSequencesLocked == false;
      this.listBoxChosenCompares.Enabled = this.bolSequencesLocked == false;
      this.nudRandomSequenceModel.Enabled = this.bolSequencesLocked == false;
    }

    private void RandomizeSequence(List<Sequence> _lst2Randomize, List<List<ObjectInSequence>> _lstSequences)
    {
      List<ObjectInSequence> lst2Randomize = new List<ObjectInSequence>();
      _lst2Randomize.ForEach(item => lst2Randomize.AddRange(item.ObjectsInSequence));

      // Now loop a number of times wanted
      for (int intIntex = 0; intIntex < this.nudRandomSequenceModel.Value; intIntex++)
      {
        // Make a Copy of the list
        List<ObjectInSequence> lst2RandomizeCopy = new List<ObjectInSequence>(lst2Randomize);
        // Randomize the sequence
        List<ObjectInSequence> lstRandomized = new List<ObjectInSequence>();
        while (lst2RandomizeCopy.Count > 0)
        {
          // Get the next random index
          int intIndexRandom = rsm.Next(0, lst2RandomizeCopy.Count - 1);
          lstRandomized.Add(lst2RandomizeCopy[intIndexRandom]);
          lst2RandomizeCopy.RemoveAt(intIndexRandom);
        }

        _lstSequences.Add(lstRandomized);
      }
    }

    private void SaveCSV(
      string _filename,
      NeedlemanWunsch nw,
      ConcurrentBag<Tuple<decimal, int, int, int, int>> lstDistances,
      List<ObjectInSequence> lstSequenceA, 
      List<ObjectInSequence> lstSequenceB)
    {
      TextWriter csvWriter = new StreamWriter(_filename, false);
      // Write the Header
      csvWriter.WriteLine("Source;Distance;Number of Changes;LengthSequenceA;LengthSequenceB;LengthBacktrace");
      // Write the original distance
      csvWriter.WriteLine($"original;{nw.Distance};{nw.NumberOfChanges};{nw.SequenceA.Count};{nw.SequenceB.Count};{nw.Backtraces.Min(bt => bt.WayBack.Count)}");

      // Now append the randomized distances
      foreach (var nwAktuell in lstDistances)
      {
        csvWriter.WriteLine($"randomized;{nwAktuell.Item1};{nwAktuell.Item2};{nwAktuell.Item4};{nwAktuell.Item5};{nwAktuell.Item3}");
      }

      csvWriter.Flush();
      csvWriter.Close();
    }
    #endregion

    #region Private classes
    private class CompareObject
    {
      public CompareObject(List<Sequence> _sequenceA, List<Sequence> _sequenceB, string _savePath)
      {
        this.SequenceA = _sequenceA;
        this.SequenceB = _sequenceB;
        this.SavePath = _savePath;
      }

      public List<Sequence> SequenceA
      {
        get;
        private set;
      }

      /// <summary>
      /// The randomized sequences from A if the user locked them
      /// </summary>
      public List<List<ObjectInSequence>> RandomizedSequencesA
      {
        get;
        set;
      }

      public List<Sequence> SequenceB
      {
        get;
        private set;
      }

      /// <summary>
      /// The randomized sequences from B if the user locked them
      /// </summary>
      public List<List<ObjectInSequence>> RandomizedSequencesB
      {
        get;
        set;
      }

      public string SavePath
      {
        get;
        private set;
      }

      public string DisplayText
      {
        get
        {
          string strDisplayA = this.SequenceA.ToString(", "), strDisplayB = this.SequenceB.ToString(", ");
          return $"({strDisplayA}) compare with ({strDisplayB}) {this.SavePath}";
        }
      }
    }
    #endregion
  }
}
