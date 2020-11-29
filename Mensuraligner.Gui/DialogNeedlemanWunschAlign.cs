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
using System.Xml.Serialization;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Dialog to build the Alignment of 2 Sequences
  /// </summary>
  public partial class DialogNeedlemanWunschAlign : Form
  {
    /// <summary>
    /// Constructor - Mostly harmless
    /// </summary>
    public DialogNeedlemanWunschAlign()
    {
      InitializeComponent();
    }

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
    
    #region Eventhandler
    private void btnBuildAlignment_Click(object sender, EventArgs e)
    {
      // Do some checks
      if (DoChecks())
      {
        // Create the Alignment
        NeedlemanWunsch nw = new NeedlemanWunsch(this.controlSequencesA.SequencesSelected, this.controlSequencesB.SequencesSelected, this.controlOptions.Options);

        DialogNeedlemanWunschShowAlign.ShowDialogForAlignment(nw);
      }
    }
    #endregion

    #region Helpers
    private bool DoChecks()
    {
      if (this.controlSequencesA.SequencesSelected.Count == 0)
      {
        MessageBox.Show("Please select at least one Sequence in the left Sequenceliste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      if (this.controlSequencesB.SequencesSelected.Count == 0)
      {
        MessageBox.Show("Please select at least one Sequence in the right Sequenceliste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (this.controlOptions.Options == null)
      {
        MessageBox.Show("Please chose Options to use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      return true;
    }
    #endregion
  }
}
