namespace Mensuraligner.Gui
{
  partial class ControlOptions
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnNewOptions = new System.Windows.Forms.Button();
      this.cmbSettings = new System.Windows.Forms.ComboBox();
      this.btnEditOptions = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnNewOptions
      // 
      this.btnNewOptions.Location = new System.Drawing.Point(65, 27);
      this.btnNewOptions.Name = "btnNewOptions";
      this.btnNewOptions.Size = new System.Drawing.Size(48, 25);
      this.btnNewOptions.TabIndex = 5;
      this.btnNewOptions.Text = "New";
      this.btnNewOptions.UseVisualStyleBackColor = true;
      this.btnNewOptions.Click += new System.EventHandler(this.btnNewOptions_Click);
      // 
      // cmbSettings
      // 
      this.cmbSettings.FormattingEnabled = true;
      this.cmbSettings.Location = new System.Drawing.Point(0, 0);
      this.cmbSettings.Name = "cmbSettings";
      this.cmbSettings.Size = new System.Drawing.Size(113, 21);
      this.cmbSettings.TabIndex = 3;
      this.cmbSettings.SelectedIndexChanged += new System.EventHandler(this.cmbSettings_SelectedIndexChanged);
      // 
      // btnEditOptions
      // 
      this.btnEditOptions.Location = new System.Drawing.Point(10, 27);
      this.btnEditOptions.Name = "btnEditOptions";
      this.btnEditOptions.Size = new System.Drawing.Size(48, 25);
      this.btnEditOptions.TabIndex = 4;
      this.btnEditOptions.Text = "Edit";
      this.btnEditOptions.UseVisualStyleBackColor = true;
      this.btnEditOptions.Click += new System.EventHandler(this.btnEditOptions_Click);
      // 
      // ControlOptions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnNewOptions);
      this.Controls.Add(this.cmbSettings);
      this.Controls.Add(this.btnEditOptions);
      this.Name = "ControlOptions";
      this.Size = new System.Drawing.Size(113, 51);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnNewOptions;
    private System.Windows.Forms.ComboBox cmbSettings;
    private System.Windows.Forms.Button btnEditOptions;
  }
}
