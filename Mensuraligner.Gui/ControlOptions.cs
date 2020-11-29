using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensuraligner;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Control to chose and edit the options
  /// </summary>
  public partial class ControlOptions : UserControl
  {
    /// <summary>
    /// Member where we store the Options chosen
    /// </summary>
    private NeedlemanWunschOptions varOptions = new NeedlemanWunschOptions();

    /// <summary>
    /// Constructor
    /// </summary>
    public ControlOptions()
    {
      InitializeComponent();

      this.cmbSettings.DisplayMember = nameof(NeedlemanWunschOptions.Name);
      this.cmbSettings.Items.AddRange(NeedlemanWunschOptions.LoadOptions().ToArray());
    }

    /// <summary>
    /// Get the chosen options
    /// </summary>
    public NeedlemanWunschOptions Options
    {
      get
      {
        return this.varOptions;
      }
    }

    #region Eventhandler
    private void cmbSettings_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmbSettings.SelectedItem is NeedlemanWunschOptions options)
      {
        this.varOptions = options;
      }
    }

    private void btnEditOptions_Click(object sender, EventArgs e)
    {
      if (this.varOptions == null)
      {
        this.varOptions = new NeedlemanWunschOptions();
      }

      using (DialogNeedlemanWunschOptions dialogOptions = new DialogNeedlemanWunschOptions())
      {
        dialogOptions.Options = this.varOptions;
        if (dialogOptions.ShowDialog(this.FindForm()) == DialogResult.OK)
        {
          this.varOptions = dialogOptions.Options;
          this.RefillCombobox();
        }
      }
    }

    private void btnNewOptions_Click(object sender, EventArgs e)
    {
      this.varOptions = new NeedlemanWunschOptions();

      using (DialogNeedlemanWunschOptions dialogOptions = new DialogNeedlemanWunschOptions())
      {
        dialogOptions.Options = this.varOptions;
        if (dialogOptions.ShowDialog(this.FindForm()) == DialogResult.OK)
        {
          this.varOptions = dialogOptions.Options;
          this.RefillCombobox();
        }
      }
    }
    #endregion

    #region Helpers
    private void RefillCombobox()
    {
      this.cmbSettings.Items.Clear();
      this.cmbSettings.Items.AddRange(NeedlemanWunschOptions.LoadOptions().ToArray());
      this.cmbSettings.SelectedItem = this.varOptions;
    }
    #endregion
  }
}
