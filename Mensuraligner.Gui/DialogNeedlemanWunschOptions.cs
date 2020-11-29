using Mensuraligner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Dialog for editing the NeedlemanWunschOptions
  /// </summary>
  public partial class DialogNeedlemanWunschOptions : Form
  {
    private NeedlemanWunschOptions options2Edit;
    private List<NeedlemanWunschOptions> lstOptions;

    /// <summary>
    /// Konstruktor - Mostly harmless
    /// </summary>
    public DialogNeedlemanWunschOptions()
    {
      InitializeComponent();

      this.lstOptions = NeedlemanWunschOptions.LoadOptions();
    }

    /// <summary>
    /// Get/Set the Options
    /// </summary>
    public NeedlemanWunschOptions Options
    {
      get
      {
        GetDataFromGui(this.options2Edit);
        return this.options2Edit;
      }
      set
      {
        this.options2Edit = value;
        this.SetDataToGui(this.options2Edit);
      }
    }

    #region Hilfsmethoden
    private void GetDataFromGui(NeedlemanWunschOptions _options)
    {
      _options.Name = this.txtName.Text;

      _options.UberLogic = this.cbxUberLogic.Checked;

      _options.GapPenalty = this.nudGapPenalty.Value;
      _options.UseAffineGaps = this.cbxAffineGap.Checked;
      _options.GapExtensionPenalty = this.nudAffineGapPenalty.Value;
      _options.DamagePenalty = this.nudDamagePenalty.Value;
      _options.UseAffineDamages = this.cbxAffineDamage.Checked;
      _options.DamageExtensionPenalty = this.nudAffineDamagePenalty.Value;
      _options.ConversionPenalty = this.nudConversionPenalty.Value;
      // Weights - Rest
      _options.WeightRestDuration = this.nudRestDuration.Value;
      _options.WeightRestBreveDuration = this.nudRestBreveduration.Value;
      // Weights - Note
      _options.WeightNoteBreveduration = this.nudNoteBreveduration.Value;
      _options.WeightNoteColoration = this.nudNoteColoration.Value;
      _options.WeightNoteDuration = this.nudNoteDuration.Value;
      _options.WeightNoteFermata = this.nudNoteFermata.Value;
      _options.WeightNoteLigatureForm = this.nudNoteLigatureForm.Value;
      _options.WeightNoteLigaturePosition = this.nudNoteLigaturePosition.Value;
      _options.WeightNotePitchWithAccid = this.nudNotePitchWithAccid.Value;
      _options.WeightNoteStem = this.nudNoteStem.Value;
      _options.WeightNoteWrittenPitch = this.nudNoteWrittenPitch.Value;
      // Weights - Mensur
      _options.WeightMensurMaximodus = this.nudMensurLogic.Value;
      _options.WeightMensurModus = this.nudMensurLogic.Value;
      _options.WeightMensurProlatio = this.nudMensurLogic.Value;
      _options.WeightMensurTempus = this.nudMensurLogic.Value;
      _options.WeightMensurRatio = this.nudMensurRatio.Value;
      _options.WeightMensurSign = this.nudMensurSign.Value;
      // Weights - Proportion
      _options.WeightProportionAffected = this.nudProportionAffected.Value;
      _options.WeightProportionRatio = this.nudProportionRatio.Value;
      _options.WeightProportionSign = this.nudProportioSign.Value;
    }

    private void SetDataToGui(NeedlemanWunschOptions _options)
    {
      this.txtName.Text = _options.Name;

      this.cbxUberLogic.Checked = _options.UberLogic;

      this.nudGapPenalty.Value = _options.GapPenalty;
      this.cbxAffineGap.Checked = _options.UseAffineGaps;
      this.nudAffineGapPenalty.Value = _options.GapExtensionPenalty;
      this.nudDamagePenalty.Value = _options.DamagePenalty;
      this.cbxAffineDamage.Checked = _options.UseAffineDamages;
      this.nudAffineDamagePenalty.Value = _options.DamageExtensionPenalty;
      this.nudConversionPenalty.Value = _options.ConversionPenalty;
      // Weights - Rest
      this.nudRestDuration.Value = _options.WeightRestDuration;
      this.nudRestBreveduration.Value = _options.WeightRestBreveDuration;
      // Weights - Note
      this.nudNoteBreveduration.Value = _options.WeightNoteBreveduration;
      this.nudNoteColoration.Value = _options.WeightNoteColoration;
      this.nudNoteDuration.Value = _options.WeightNoteDuration;
      this.nudNoteFermata.Value = _options.WeightNoteFermata;
      this.nudNoteLigatureForm.Value = _options.WeightNoteLigatureForm;
      this.nudNoteLigaturePosition.Value = _options.WeightNoteLigaturePosition;
      this.nudNotePitchWithAccid.Value = _options.WeightNotePitchWithAccid;
      this.nudNoteStem.Value = _options.WeightNoteStem;
      this.nudNoteWrittenPitch.Value = _options.WeightNoteWrittenPitch;
      // Weights - Mensur
      this.nudMensurLogic.Value = _options.WeightMensurMaximodus;
      this.nudMensurRatio.Value = _options.WeightMensurRatio;
      this.nudMensurSign.Value = _options.WeightMensurSign;
      // Weights - Proportion
      this.nudProportionAffected.Value = _options.WeightProportionAffected;
      this.nudProportionRatio.Value = _options.WeightProportionRatio;
      this.nudProportioSign.Value = _options.WeightProportionSign;
    }
    #endregion

    #region Eventhandler
    private void cbxAffineGap_CheckedChanged(object sender, EventArgs e)
    {
      this.nudAffineGapPenalty.Enabled = this.cbxAffineGap.Checked;
    }

    private void cbxAffineDamage_CheckedChanged(object sender, EventArgs e)
    {
      this.nudAffineDamagePenalty.Enabled = this.cbxAffineDamage.Checked;
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
      // Check if settings with the Name already exists
      NeedlemanWunschOptions optionsFound = this.lstOptions.FirstOrDefault(option => option.Name == this.txtName.Text);
      // If yes ask the user if he wants to replace them
      if (optionsFound != null)
      {
        if (MessageBox.Show(this.FindForm(), "Settings with this name already exist. Replace them?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
          return;
        }
        // We're still here, read the data from the gui into the object
        this.GetDataFromGui(optionsFound);
      }
      else
      {
        this.GetDataFromGui(this.options2Edit);
        // And append them to the list
        this.lstOptions.Add(this.options2Edit);
      }

      NeedlemanWunschOptions.SaveOptions();

      MessageBox.Show(this.FindForm(), "Options saved!");

      /*
      // Refresh the ComboBox
      this.cmbSettings.Items.Clear();
      this.cmbSettings.Items.AddRange(this.lstOptions.ToArray());
      */
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
    #endregion
  }
}
