using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mei;
using mei2Sequence;
using mei2Sequence.Model;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Control fpr showing sequences from an MEIDocument
  /// </summary>
  public partial class ShowSequences : UserControl
  {
    /// <summary>
    /// MEIDocument
    /// </summary>
    public MeiDocument MeiDocument { get; private set; }

    #region Constructor
    /// <summary>
    /// Constructur
    /// </summary>
    /// <param name="_filedir">Directory for loading the sequencelist</param>
    public ShowSequences(string _filedir)
    {
      InitializeComponent();

      List<Sequence> sequenceList = Controller.GetSequences(_filedir);

      // Initialize the Sequences
      foreach (Sequence sequenceAktuell in sequenceList)
      {
        Controller.BuildSequence(sequenceAktuell);
      }

      // Set the Sequences to the Listbox
      this.SequenceList.SequencesShown = sequenceList;
    }
    #endregion

    /// <summary>
    /// Gets the selected Sequences
    /// </summary>
    public List<Sequence> SequencesSelected
    {
      get
      {
        return SequenceList.SequencesSelected;
      }
    }

    /// <summary>
    /// Gets this shown Sequences
    /// </summary>
    public List<Sequence> SequencesShown
    {
      get
      {
        return this.SequenceList.SequencesShown;
      }
    }

    #region Private Helpers
    private void AddDataRows(Sequence _seq)
    {
      foreach (ObjectInSequence obj in _seq.ObjectsInSequence)
      {
        SequenceGridView.Rows.Add(ObjectWriter.WriteToDataRow(obj));
      }
    }

    private void SequenceList_SelectedIndexChanged(object sender, EventArgs e)
    {
      SequenceGridView.Rows.Clear();
      foreach (var itemAktuell in SequenceList.SequencesSelected)
      {
        AddDataRows(itemAktuell);
      }
    }
    #endregion
  }
}
