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

namespace Mensuraligner.Gui
{
  /// <summary>
  /// A Control to select Sequences
  /// </summary>
  public partial class ControlSequences : UserControl
  {
    private Dictionary<string, List<Sequence>> dicSequences2Filename;

    /// <summary>
    /// Konstruktor
    /// </summary>
    public ControlSequences()
    {
      InitializeComponent();

      this.btnAllDown.Text = "\u21CA";
      this.btnOneDown.Text = "\u2193";
      this.btnAllUp.Text = "\u21C8";
      this.btnOneUp.Text = "\u2191";
    }

    #region Getting/Setting Data
    /// <summary>
    /// Sets the data needed in the dialog
    /// </summary>
    /// <param name="_dicSequences2Filename"></param>
    public void SetData(Dictionary<string, List<Sequence>> _dicSequences2Filename)
    {
      // Set every key in the BomboBoxes and remember the dictionary
      this.dicSequences2Filename = _dicSequences2Filename;
      foreach (string strAktuell in this.dicSequences2Filename.Keys)
      {
        this.cmbFiles.Items.Add(strAktuell);
      }
      if (this.dicSequences2Filename.Count > 0)
      {
        this.cmbFiles.SelectedIndex = 0;
      }
    }

    /// <summary>
    /// Get the chosen ones
    /// </summary>
    public List<Sequence> SequencesSelected
    {
      get
      {
        return this.listSequencesSelected.SequencesShown;
      }
    }

    /// <summary>
    /// Reset the current selection
    /// </summary>
    public void ResetSelectedSequences()
    {
      this.listSequencesSelected.SequencesShown = new List<Sequence>();
      this.FillSequences();
    }
    #endregion

    #region Eventhandler
    private void btnAllDown_Click(object sender, EventArgs e)
    {
      List<Sequence> lstSelected = this.listSequencesSelected.SequencesShown;
      lstSelected.AddRange(this.listSequences.SequencesShown);
      this.listSequencesSelected.SequencesShown = lstSelected;
      FillSequences();
    }

    private void btnOneDown_Click(object sender, EventArgs e)
    {
      List<Sequence> lstSelected = this.listSequencesSelected.SequencesShown;
      lstSelected.AddRange(this.listSequences.SequencesSelected);
      this.listSequencesSelected.SequencesShown = lstSelected;
      FillSequences();
    }

    private void btnOneUp_Click(object sender, EventArgs e)
    {
      List<Sequence> lstSelected = this.listSequencesSelected.SequencesShown;
      List<Sequence> lstSelectedSelected = this.listSequencesSelected.SequencesSelected;
      lstSelectedSelected.ForEach(seq => lstSelected.Remove(seq));
      this.listSequencesSelected.SequencesShown = lstSelected;
      FillSequences();
    }

    private void btnAllUp_Click(object sender, EventArgs e)
    {
      this.listSequencesSelected.SequencesShown = new List<Sequence>();
      FillSequences();
    }

    private void listSequences_DoubleClick(object sender, EventArgs e)
    {
      List<Sequence> lstSelected = this.listSequencesSelected.SequencesShown;
      lstSelected.AddRange(this.listSequences.SequencesSelected);
      this.listSequencesSelected.SequencesShown = lstSelected;
      FillSequences();
    }

    private void listSequencesSelected_DoubleClick(object sender, EventArgs e)
    {
      List<Sequence> lstSelected = this.listSequencesSelected.SequencesShown;
      List<Sequence> lstSelectedSelected = this.listSequencesSelected.SequencesSelected;
      lstSelectedSelected.ForEach(seq => lstSelected.Remove(seq));
      this.listSequencesSelected.SequencesShown = lstSelected;
      FillSequences();
    }

    /// <summary>
    /// Index of the ComboBox has changed - Refill the Listbox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cmbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      FillSequences();
    }
    #endregion

    #region Helpers
    private void FillSequences()
    {
      if (this.cmbFiles.SelectedItem != null)
      {
        List<Sequence> sequences2Show = this.dicSequences2Filename[(string)this.cmbFiles.SelectedItem];
        sequences2Show = sequences2Show.Where(seq => this.listSequencesSelected.SequencesShown.Contains(seq) == false).ToList();
        this.listSequences.SequencesShown = sequences2Show;
      }
    }
    #endregion
  }
}
