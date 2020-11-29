using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mei2Sequence.Model;
using mei2Sequence;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Listbox for Sequences
  /// </summary>
  public partial class ListSequences : ListBox
  {
    private Dictionary<string, Sequence> Sequences
    {
      get;
      set;
    } = new Dictionary<string, Sequence>();

    /// <summary>
    /// Constructor
    /// </summary>
    public ListSequences()
    {
      InitializeComponent();
    }

    #region Designer-Properties
    /// <summary>
    /// Should the piece be shown in the view?
    /// </summary>
    [DefaultValue(true)]
    [Description("Should the piece be shown in the view?")]
    public bool ShowPiece
    {
      get;
      set;
    } = true;
    #endregion

    #region Properties
    /// <summary>
    /// Gets/Sets the Sequences to show in the Listbox
    /// </summary>
    [Browsable(false), ReadOnly(true), DefaultValue(null)]
    public List<Sequence> SequencesShown
    {
      get
      {
        List<Sequence> lstReturn = new List<Sequence>();
        lstReturn.AddRange(Sequences.Values);
        return lstReturn;
      }
      set
      {
        // Clear the Items
        this.Items.Clear();
        Sequences.Clear();

        // Build the string2Sequence Dictionary
        foreach (Sequence seq in value)
        {
          // Controller.BuildSequence(seq);
          SequenceConversion.ConvertBrevePosition(seq);
          SequenceConversion.ConvertAbsolutePitch(seq);

          // Build the "id" of the Sequence
          StringBuilder strBuilderSeqID = new StringBuilder();
          // If the Piece should be shown append it at first
          if (ShowPiece)
          {
            strBuilderSeqID.Append(seq.Piece);
            strBuilderSeqID.Append("-");
          }

          // Only Append the PartOfPiece if it is there
          if (string.IsNullOrEmpty(seq.PartOfPiece) == false)
          {
            strBuilderSeqID.Append(seq.PartOfPiece);
            strBuilderSeqID.Append("-");
          }
          // Now append the rest that's always there
          strBuilderSeqID.Append(seq.Page);
          strBuilderSeqID.Append("-");
          strBuilderSeqID.Append(seq.Voice);
          strBuilderSeqID.Append("-");
          strBuilderSeqID.Append(seq.VoiceNr.ToString());

          // When the State ist not null append it
          if (seq.State != State.Null)
          {
            strBuilderSeqID.Append("_");
            strBuilderSeqID.Append(seq.State.ToString());
          }

          Sequences.Add(strBuilderSeqID.ToString(), seq);
        }

        foreach (KeyValuePair<string, Sequence> seq in Sequences)
        {
          this.Items.Add(seq.Key);
        }
      }
    }

    /// <summary>
    /// Gets the selected Sequences
    /// </summary>
    [Browsable(false), ReadOnly(true), DefaultValue(null)]
    public List<Sequence> SequencesSelected
    {
      get
      {
        List<Sequence> lstReturn = new List<Sequence>();
        foreach (var itemAktuell in this.SelectedItems)
        {
          lstReturn.Add(Sequences[itemAktuell.ToString()]);
        }

        return lstReturn;
      }
    }
    #endregion
  }
}
