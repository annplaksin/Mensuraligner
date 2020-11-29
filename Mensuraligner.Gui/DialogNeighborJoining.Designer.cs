namespace Mensuraligner.Gui
{
  partial class DialogNeighborJoining
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
      this.btnSelectSequence = new System.Windows.Forms.Button();
      this.txtSavePath = new System.Windows.Forms.TextBox();
      this.btnSavePath = new System.Windows.Forms.Button();
      this.saveFileDir = new System.Windows.Forms.SaveFileDialog();
      this.groupBoxSettings = new System.Windows.Forms.GroupBox();
      this.rdbChanges = new System.Windows.Forms.RadioButton();
      this.rdbDistance = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.listBoxTaxa = new System.Windows.Forms.ListBox();
      this.txtTaxonName = new System.Windows.Forms.TextBox();
      this.btnNeighborJoining = new System.Windows.Forms.Button();
      this.grbOptions = new System.Windows.Forms.GroupBox();
      this.controlOptions = new ControlOptions();
      this.listSequencesSelected = new ListSequences();
      this.controlSequences = new ControlSequences();
      this.groupBoxSettings.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.grbOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSelectSequence
      // 
      this.btnSelectSequence.Location = new System.Drawing.Point(228, 191);
      this.btnSelectSequence.Name = "btnSelectSequence";
      this.btnSelectSequence.Size = new System.Drawing.Size(39, 23);
      this.btnSelectSequence.TabIndex = 8;
      this.btnSelectSequence.Text = "-->";
      this.btnSelectSequence.UseVisualStyleBackColor = true;
      this.btnSelectSequence.Click += new System.EventHandler(this.btnSelectSequence_Click);
      // 
      // txtSavePath
      // 
      this.txtSavePath.Location = new System.Drawing.Point(7, 19);
      this.txtSavePath.Name = "txtSavePath";
      this.txtSavePath.Size = new System.Drawing.Size(203, 20);
      this.txtSavePath.TabIndex = 9;
      // 
      // btnSavePath
      // 
      this.btnSavePath.Location = new System.Drawing.Point(135, 51);
      this.btnSavePath.Name = "btnSavePath";
      this.btnSavePath.Size = new System.Drawing.Size(75, 23);
      this.btnSavePath.TabIndex = 10;
      this.btnSavePath.Text = "Choose";
      this.btnSavePath.UseMnemonic = false;
      this.btnSavePath.UseVisualStyleBackColor = true;
      this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
      // 
      // saveFileDir
      // 
      this.saveFileDir.DefaultExt = "txt";
      this.saveFileDir.Filter = "Textfile|*.txt";
      // 
      // groupBoxSettings
      // 
      this.groupBoxSettings.Controls.Add(this.rdbChanges);
      this.groupBoxSettings.Controls.Add(this.rdbDistance);
      this.groupBoxSettings.Location = new System.Drawing.Point(446, 200);
      this.groupBoxSettings.Name = "groupBoxSettings";
      this.groupBoxSettings.Size = new System.Drawing.Size(133, 74);
      this.groupBoxSettings.TabIndex = 11;
      this.groupBoxSettings.TabStop = false;
      this.groupBoxSettings.Text = "Settings";
      // 
      // rdbChanges
      // 
      this.rdbChanges.AutoSize = true;
      this.rdbChanges.Checked = true;
      this.rdbChanges.Location = new System.Drawing.Point(7, 19);
      this.rdbChanges.Name = "rdbChanges";
      this.rdbChanges.Size = new System.Drawing.Size(119, 17);
      this.rdbChanges.TabIndex = 1;
      this.rdbChanges.TabStop = true;
      this.rdbChanges.Text = "Number of Changes";
      this.rdbChanges.UseVisualStyleBackColor = true;
      // 
      // rdbDistance
      // 
      this.rdbDistance.AutoSize = true;
      this.rdbDistance.Location = new System.Drawing.Point(7, 42);
      this.rdbDistance.Name = "rdbDistance";
      this.rdbDistance.Size = new System.Drawing.Size(67, 17);
      this.rdbDistance.TabIndex = 0;
      this.rdbDistance.Text = "Distance";
      this.rdbDistance.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtSavePath);
      this.groupBox1.Controls.Add(this.btnSavePath);
      this.groupBox1.Location = new System.Drawing.Point(446, 280);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(220, 80);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Save results";
      // 
      // listBoxTaxa
      // 
      this.listBoxTaxa.FormattingEnabled = true;
      this.listBoxTaxa.Location = new System.Drawing.Point(273, 34);
      this.listBoxTaxa.Name = "listBoxTaxa";
      this.listBoxTaxa.Size = new System.Drawing.Size(167, 342);
      this.listBoxTaxa.TabIndex = 13;
      this.listBoxTaxa.SelectedIndexChanged += new System.EventHandler(this.listBoxTaxa_SelectedIndexChanged);
      this.listBoxTaxa.DoubleClick += new System.EventHandler(this.listBoxTaxa_DoubleClick);
      // 
      // txtTaxonName
      // 
      this.txtTaxonName.Location = new System.Drawing.Point(273, 7);
      this.txtTaxonName.Name = "txtTaxonName";
      this.txtTaxonName.Size = new System.Drawing.Size(167, 20);
      this.txtTaxonName.TabIndex = 14;
      // 
      // btnNeighborJoining
      // 
      this.btnNeighborJoining.Location = new System.Drawing.Point(581, 366);
      this.btnNeighborJoining.Name = "btnNeighborJoining";
      this.btnNeighborJoining.Size = new System.Drawing.Size(75, 23);
      this.btnNeighborJoining.TabIndex = 15;
      this.btnNeighborJoining.Text = "Do the thing";
      this.btnNeighborJoining.UseVisualStyleBackColor = true;
      this.btnNeighborJoining.Click += new System.EventHandler(this.btnNeighborJoining_Click);
      // 
      // grbOptions
      // 
      this.grbOptions.Controls.Add(this.controlOptions);
      this.grbOptions.Location = new System.Drawing.Point(446, 118);
      this.grbOptions.Name = "grbOptions";
      this.grbOptions.Size = new System.Drawing.Size(133, 76);
      this.grbOptions.TabIndex = 14;
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
      // listSequencesSelected
      // 
      this.listSequencesSelected.FormattingEnabled = true;
      this.listSequencesSelected.Location = new System.Drawing.Point(446, 34);
      this.listSequencesSelected.Name = "listSequencesSelected";
      this.listSequencesSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listSequencesSelected.ShowPiece = false;
      this.listSequencesSelected.Size = new System.Drawing.Size(209, 82);
      this.listSequencesSelected.TabIndex = 7;
      // 
      // controlSequences
      // 
      this.controlSequences.Location = new System.Drawing.Point(12, 7);
      this.controlSequences.Name = "controlSequences";
      this.controlSequences.Size = new System.Drawing.Size(210, 369);
      this.controlSequences.TabIndex = 16;
      // 
      // DialogNeighborJoining
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(675, 399);
      this.Controls.Add(this.controlSequences);
      this.Controls.Add(this.grbOptions);
      this.Controls.Add(this.btnNeighborJoining);
      this.Controls.Add(this.txtTaxonName);
      this.Controls.Add(this.listBoxTaxa);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBoxSettings);
      this.Controls.Add(this.btnSelectSequence);
      this.Controls.Add(this.listSequencesSelected);
      this.Name = "DialogNeighborJoining";
      this.Text = "Neighbor Joining";
      this.groupBoxSettings.ResumeLayout(false);
      this.groupBoxSettings.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.grbOptions.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private ListSequences listSequencesSelected;
    private System.Windows.Forms.Button btnSelectSequence;
    private System.Windows.Forms.TextBox txtSavePath;
    private System.Windows.Forms.Button btnSavePath;
    private System.Windows.Forms.SaveFileDialog saveFileDir;
    private System.Windows.Forms.GroupBox groupBoxSettings;
    private System.Windows.Forms.RadioButton rdbChanges;
    private System.Windows.Forms.RadioButton rdbDistance;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox listBoxTaxa;
    private System.Windows.Forms.TextBox txtTaxonName;
    private System.Windows.Forms.Button btnNeighborJoining;
    private System.Windows.Forms.GroupBox grbOptions;
    private ControlOptions controlOptions;
    private ControlSequences controlSequences;
  }
}