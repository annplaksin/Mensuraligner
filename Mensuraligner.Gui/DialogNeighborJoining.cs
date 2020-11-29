using mei2Sequence.Model;
using Mensuraligner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Dialog for a neighbor joining
  /// </summary>
  public partial class DialogNeighborJoining : Form
  {
    private Dictionary<string, List<Sequence>> dicSequences2Filename;

    /// <summary>
    /// Constructor
    /// </summary>
    public DialogNeighborJoining()
    {
      InitializeComponent();

      this.listBoxTaxa.DisplayMember = nameof(TaxonObject.Name);
    }

    /// <summary>
    /// Sets the data needed in the dialog
    /// </summary>
    /// <param name="_dicSequences2Filename"></param>
    public void SetData(Dictionary<string, List<Sequence>> _dicSequences2Filename)
    {
      // Set every key in both BomboBoxes and remember the dictionary
      this.dicSequences2Filename = _dicSequences2Filename;
      this.controlSequences.SetData(_dicSequences2Filename);
    }


    #region Eventhandler
    /// <summary>
    /// Choose save file for NJ result tree
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSavePath_Click(object sender, EventArgs e)
    {
      if (this.saveFileDir.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        this.txtSavePath.Text = this.saveFileDir.FileName;
      }
    }

    private void btnSelectSequence_Click(object sender, EventArgs e)
    {
      // Check for empty or duplicate Name
      if (string.IsNullOrWhiteSpace(this.txtTaxonName.Text))
      {
        MessageBox.Show(this.FindForm(), "Please select a name for the taxon.");
        return;
      }
      foreach (object objAktuell in this.listBoxTaxa.Items)
      {
        if (objAktuell is TaxonObject taxObjAktuell)
        {
          if (this.txtTaxonName.Text == taxObjAktuell.Name)
          {
            MessageBox.Show(this.FindForm(), "Please choose a different name for the taxon.");
            return;
          }
        }
      }

      // Now everything is fine. Build a new TaxoObject and add it to the list
      TaxonObject objNew = new TaxonObject(this.txtTaxonName.Text, this.controlSequences.SequencesSelected);
      this.listBoxTaxa.Items.Add(objNew);
      this.controlSequences.ResetSelectedSequences();
      // this.ShowUnselectedSequences();
    }

    private void listBoxTaxa_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Show the selected Sequences in the list
      if (this.listBoxTaxa.SelectedItem is TaxonObject taxObj)
      {
        this.listSequencesSelected.SequencesShown = taxObj.Items;
      }
    }

    private void listBoxTaxa_DoubleClick(object sender, EventArgs e)
    {
      if (this.listBoxTaxa.SelectedItem is TaxonObject taxObj)
      {
        this.listBoxTaxa.Items.Remove(taxObj);
        this.listSequencesSelected.SequencesShown = new List<Sequence>();
      }
    }

    private void btnNeighborJoining_Click(object sender, EventArgs e)
    {
      // We need to build a Matrix with the differences of the Taxas
      var lstItems = this.listBoxTaxa.Items.Cast<TaxonObject>();
      decimal[,] decsDifferences = new decimal[lstItems.Count(), lstItems.Count()];
      Dictionary<int, string> dicLabels2Position = new Dictionary<int, string>();

      // Fill the Labels Dictionary
      for (int intIndex = 0; intIndex < lstItems.Count(); intIndex++)
      {
        // Add the item to the Labels2Position Dictionary
        dicLabels2Position.Add(intIndex, lstItems.ElementAt(intIndex).Name);
      }

      Parallel.For(0, lstItems.Count(), intOuter =>
      {
        TaxonObject objOuter = lstItems.ElementAt(intOuter);
        
        // Add the compare with itself 0 in the identity
        decsDifferences[intOuter, intOuter] = 0m;

        Parallel.For(intOuter + 1, lstItems.Count(), intInner =>
        {
          TaxonObject objInner = lstItems.ElementAt(intInner);

          NeedlemanWunsch nw = new NeedlemanWunsch(objOuter.Items, objInner.Items, this.controlOptions.Options, true);

          decsDifferences[intOuter, intInner] = this.rdbDistance.Checked ? nw.Distance : nw.NumberOfChanges;
          decsDifferences[intInner, intOuter] = this.rdbDistance.Checked ? nw.Distance : nw.NumberOfChanges;
        });
      });

      /*
      for (int intOuter = 0; intOuter < lstItems.Count(); intOuter++)
      {
        TaxonObject objOuter = lstItems.ElementAt(intOuter);
        // Add the item to the Labels2Position Dictionary
        dicLabels2Position.Add(intOuter, objOuter.Name);
        // Add the compare with itself 0 in the identity
        decsDifferences[intOuter, intOuter] = 0m;

        // Now align it with the remaining Taxas
        for (int intInner = intOuter + 1; intInner < lstItems.Count(); intInner++)
        {
          TaxonObject objInner = lstItems.ElementAt(intInner);

          NeedlemanWunsch nw = new NeedlemanWunsch(objOuter.Items, objInner.Items, this.controlOptions.Options, true);

          decsDifferences[intOuter, intInner] = this.rdbDistance.Checked ? nw.Distance : nw.NumberOfChanges;
          decsDifferences[intInner, intOuter] = this.rdbDistance.Checked ? nw.Distance : nw.NumberOfChanges;
        }
      }
      */

      // Do the thing!
      NeighborJoining joining = new NeighborJoining(decsDifferences, dicLabels2Position);

      //Write result tree to selected txt
      string logFileString = Path.ChangeExtension(this.txtSavePath.Text, ".log");
      File.WriteAllText(this.txtSavePath.Text, joining.NewickTree);

      // Write fancy log file
      // Reset all Text with nothing so that we can append from now on
      File.WriteAllText(logFileString, string.Empty);
      for (int intIndex = 0; intIndex < dicLabels2Position.Count; intIndex++)
      {
        File.AppendAllText(logFileString, dicLabels2Position[intIndex] + Environment.NewLine);
      }

      File.AppendAllText(logFileString, Environment.NewLine + "Start Matrix" + Environment.NewLine + "------" + Environment.NewLine);

      // Matrix to string[]
      string[] matrixLines = new string[decsDifferences.GetLength(0)], matrixLinesTree = new string[decsDifferences.GetLength(0)];
      for (int line = 0; line <= decsDifferences.GetLength(0) - 1; line++)
      {
        for (int column = 0; column <= decsDifferences.GetLength(0) - 1; column++)
        {
          matrixLines[line] = matrixLines[line] + decsDifferences[line, column].ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB")) + "\t";
          matrixLinesTree[line] += joining.TreeMatrix[line, column].ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB")) + "\t";
        }
      }
      File.AppendAllLines(logFileString, matrixLines);

      File.AppendAllText(logFileString, Environment.NewLine + "Tree Matrix" + Environment.NewLine + "------" + Environment.NewLine);
      File.AppendAllLines(logFileString, matrixLinesTree);

      File.AppendAllText(logFileString, Environment.NewLine + "Mimimal Branch Length + Error" + Environment.NewLine + "------" + Environment.NewLine);
      File.AppendAllText(logFileString, $"{joining.MinEdge.ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB"))} \t\t{(joining.MinEdge / 2m).ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB"))}");

      File.AppendAllText(logFileString, Environment.NewLine + Environment.NewLine);

      // Append joining.NodesAndEdges
      string[] nodesAndEdges = new string[joining.NodesAndEdges.Count + 2];
      nodesAndEdges[0] = "Between" + "\t\t" + "And" + "\t\t" + "Length";
      nodesAndEdges[1] = "-------" + "\t\t" + "---" + "\t\t" + "------";

      for (int count = 2; count <= joining.NodesAndEdges.Count + 1; count++)
      {
        Tuple<string, decimal, string> current = joining.NodesAndEdges[count - 2];
        nodesAndEdges[count] = current.Item1 + "\t\t" + current.Item3 + "\t\t" + current.Item2.ToString("0.#####", CultureInfo.CreateSpecificCulture("en-GB"));
      }
      File.AppendAllLines(logFileString, nodesAndEdges);

      // CSV Export
      string strSavepathCSV = Path.Combine(Path.GetDirectoryName(logFileString), Path.GetFileNameWithoutExtension(logFileString) + ".csv");
      using (TextWriter csvWriter = new StreamWriter(strSavepathCSV, false))
      {
        // Writer the Header
        for (int intIndexHeader = 0; intIndexHeader < dicLabels2Position.Count; intIndexHeader++)
        {
          csvWriter.Write($";{dicLabels2Position[intIndexHeader]}");
        }
        csvWriter.WriteLine();

        // Write the Original Matrix
        for (int line = 0; line <= decsDifferences.GetLength(0) - 1; line++)
        {
          csvWriter.Write(dicLabels2Position[line]);
          for (int column = 0; column <= decsDifferences.GetLength(0) - 1; column++)
          {
            csvWriter.Write($";{decsDifferences[line, column].ToString("0.#####")}");
          }
          csvWriter.WriteLine();
        }

        // Write as much ';' as needed in the NewLine
        csvWriter.WriteLine(new string(';', dicLabels2Position.Count));

        // Write the Tree Matrix
        for (int line = 0; line <= joining.TreeMatrix.GetLength(0) - 1; line++)
        {
          csvWriter.Write(dicLabels2Position[line]);
          for (int column = 0; column <= joining.TreeMatrix.GetLength(0) - 1; column++)
          {
            csvWriter.Write($";{joining.TreeMatrix[line, column].ToString("0.#####")}");
          }
          csvWriter.WriteLine();
        }

        csvWriter.Flush();
      }

      MessageBox.Show(this.FindForm(), "Done!");
    }
    #endregion

    /*
    private void ShowUnselectedSequences()
    {
      if (this.cmbFilesA.SelectedItem != null)
      {
        List<Sequence> lstItems = this.dicSequences2Filename[(string)this.cmbFilesA.SelectedItem];
        List<Sequence> lstItemsSelected = new List<Sequence>();
        foreach (object objAktuell in this.listBoxTaxa.Items)
        {
          if (objAktuell is TaxonObject taxObjAktuell)
          {
            lstItemsSelected.AddRange(taxObjAktuell.Items);
          }
        }
        lstItems.RemoveAll(item => lstItemsSelected.Contains(item));
        this.listSequences.SequencesShown = lstItems;
      }
    }
    */

    #region Hilfsklasse TaxonObject

    private class TaxonObject
    {
      public TaxonObject(string _name, List<Sequence> _lstSequences)
      {
        this.Name = _name;
        this.Items = _lstSequences;
      }

      public string Name
      {
        get;
        private set;
      }


      public List<Sequence> Items
      {
        get;
        private set;
      }
    }
    #endregion
  }
}
