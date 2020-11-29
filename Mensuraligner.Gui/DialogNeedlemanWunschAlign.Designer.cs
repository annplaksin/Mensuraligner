namespace Mensuraligner.Gui
{
  partial class DialogNeedlemanWunschAlign
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNeedlemanWunschAlign));
      this.btnBuildAlignment = new System.Windows.Forms.Button();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.btnClose = new System.Windows.Forms.Button();
      this.lblCompareWith = new System.Windows.Forms.Label();
      this.grbOptions = new System.Windows.Forms.GroupBox();
      this.controlOptions = new Mensuraligner.Gui.ControlOptions();
      this.controlSequencesA = new Mensuraligner.Gui.ControlSequences();
      this.controlSequencesB = new Mensuraligner.Gui.ControlSequences();
      this.grbOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnBuildAlignment
      // 
      this.btnBuildAlignment.Location = new System.Drawing.Point(521, 94);
      this.btnBuildAlignment.Name = "btnBuildAlignment";
      this.btnBuildAlignment.Size = new System.Drawing.Size(75, 36);
      this.btnBuildAlignment.TabIndex = 6;
      this.btnBuildAlignment.Text = "Build Alignment";
      this.btnBuildAlignment.UseVisualStyleBackColor = true;
      this.btnBuildAlignment.Click += new System.EventHandler(this.btnBuildAlignment_Click);
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(521, 358);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // lblCompareWith
      // 
      this.lblCompareWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCompareWith.Location = new System.Drawing.Point(231, 39);
      this.lblCompareWith.Name = "lblCompareWith";
      this.lblCompareWith.Size = new System.Drawing.Size(13, 207);
      this.lblCompareWith.TabIndex = 2;
      this.lblCompareWith.Text = "Compare with";
      this.lblCompareWith.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // grbOptions
      // 
      this.grbOptions.Controls.Add(this.controlOptions);
      this.grbOptions.Location = new System.Drawing.Point(472, 12);
      this.grbOptions.Name = "grbOptions";
      this.grbOptions.Size = new System.Drawing.Size(125, 76);
      this.grbOptions.TabIndex = 13;
      this.grbOptions.TabStop = false;
      this.grbOptions.Text = "Options";
      // 
      // controlOptions
      // 
      this.controlOptions.Location = new System.Drawing.Point(6, 19);
      this.controlOptions.Name = "controlOptions";
      this.controlOptions.Size = new System.Drawing.Size(113, 51);
      this.controlOptions.TabIndex = 0;
      // 
      // controlSequencesA
      // 
      this.controlSequencesA.Location = new System.Drawing.Point(12, 12);
      this.controlSequencesA.Name = "controlSequencesA";
      this.controlSequencesA.Size = new System.Drawing.Size(214, 369);
      this.controlSequencesA.TabIndex = 15;
      // 
      // controlSequencesB
      // 
      this.controlSequencesB.Location = new System.Drawing.Point(250, 12);
      this.controlSequencesB.Name = "controlSequencesB";
      this.controlSequencesB.Size = new System.Drawing.Size(216, 369);
      this.controlSequencesB.TabIndex = 16;
      // 
      // DialogNeedlemanWunschAlign
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(608, 393);
      this.Controls.Add(this.controlSequencesB);
      this.Controls.Add(this.controlSequencesA);
      this.Controls.Add(this.grbOptions);
      this.Controls.Add(this.lblCompareWith);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnBuildAlignment);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DialogNeedlemanWunschAlign";
      this.ShowInTaskbar = false;
      this.Text = "Needleman-Wunsch Alignment";
      this.grbOptions.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBuildAlignment;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblCompareWith;
    private System.Windows.Forms.GroupBox grbOptions;
    private ControlSequences controlSequencesA;
    private ControlSequences controlSequencesB;
    private ControlOptions controlOptions;
  }
}