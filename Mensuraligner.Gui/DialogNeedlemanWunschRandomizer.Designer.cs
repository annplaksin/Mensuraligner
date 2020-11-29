namespace Mensuraligner.Gui
{
  /// <summary>
  /// Dialog for randomization of sequences
  /// </summary>
  partial class DialogNeedlemanWunschRandomizer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNeedlemanWunschRandomizer));
      this.btnLoadA = new System.Windows.Forms.Button();
      this.btnRandomSequenceModel = new System.Windows.Forms.Button();
      this.nudRandomSequenceModel = new System.Windows.Forms.NumericUpDown();
      this.lblRandomSequenceModelTimes = new System.Windows.Forms.Label();
      this.btnLoadB = new System.Windows.Forms.Button();
      this.btnUnloadA = new System.Windows.Forms.Button();
      this.btnUnloadB = new System.Windows.Forms.Button();
      this.listBoxChosenCompares = new System.Windows.Forms.ListBox();
      this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
      this.grbOptions = new System.Windows.Forms.GroupBox();
      this.lblRandomize = new System.Windows.Forms.Label();
      this.btnAddCompare = new System.Windows.Forms.Button();
      this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
      this.txtSavePath = new System.Windows.Forms.TextBox();
      this.btnChoseSafepath = new System.Windows.Forms.Button();
      this.grbExistingSequences = new System.Windows.Forms.GroupBox();
      this.lblRandomizedSequencesB = new System.Windows.Forms.Label();
      this.lblRandomizedSequencesA = new System.Windows.Forms.Label();
      this.btnLockSequences = new System.Windows.Forms.Button();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanelSequences = new System.Windows.Forms.TableLayoutPanel();
      this.controlSequencesA = new ControlSequences();
      this.controlSequencesB = new ControlSequences();
      this.controlOptions = new ControlOptions();
      ((System.ComponentModel.ISupportInitialize)(this.nudRandomSequenceModel)).BeginInit();
      this.grbOptions.SuspendLayout();
      this.grbExistingSequences.SuspendLayout();
      this.tableLayoutPanelSequences.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnLoadA
      // 
      this.btnLoadA.Location = new System.Drawing.Point(6, 36);
      this.btnLoadA.Name = "btnLoadA";
      this.btnLoadA.Size = new System.Drawing.Size(75, 23);
      this.btnLoadA.TabIndex = 1;
      this.btnLoadA.Text = "Load";
      this.btnLoadA.UseVisualStyleBackColor = true;
      this.btnLoadA.Click += new System.EventHandler(this.btnLoadA_Click);
      // 
      // btnRandomSequenceModel
      // 
      this.btnRandomSequenceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRandomSequenceModel.Location = new System.Drawing.Point(550, 357);
      this.btnRandomSequenceModel.Name = "btnRandomSequenceModel";
      this.btnRandomSequenceModel.Size = new System.Drawing.Size(75, 75);
      this.btnRandomSequenceModel.TabIndex = 9;
      this.btnRandomSequenceModel.Text = "Randomize";
      this.toolTip.SetToolTip(this.btnRandomSequenceModel, "Randomizes the chosen Compares");
      this.btnRandomSequenceModel.UseVisualStyleBackColor = true;
      this.btnRandomSequenceModel.Click += new System.EventHandler(this.btnRandomSequenceModel_Click);
      // 
      // nudRandomSequenceModel
      // 
      this.nudRandomSequenceModel.Location = new System.Drawing.Point(6, 98);
      this.nudRandomSequenceModel.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.nudRandomSequenceModel.Name = "nudRandomSequenceModel";
      this.nudRandomSequenceModel.Size = new System.Drawing.Size(56, 20);
      this.nudRandomSequenceModel.TabIndex = 4;
      // 
      // lblRandomSequenceModelTimes
      // 
      this.lblRandomSequenceModelTimes.AutoSize = true;
      this.lblRandomSequenceModelTimes.Location = new System.Drawing.Point(68, 100);
      this.lblRandomSequenceModelTimes.Name = "lblRandomSequenceModelTimes";
      this.lblRandomSequenceModelTimes.Size = new System.Drawing.Size(34, 13);
      this.lblRandomSequenceModelTimes.TabIndex = 5;
      this.lblRandomSequenceModelTimes.Text = "times.";
      // 
      // btnLoadB
      // 
      this.btnLoadB.Location = new System.Drawing.Point(6, 78);
      this.btnLoadB.Name = "btnLoadB";
      this.btnLoadB.Size = new System.Drawing.Size(75, 23);
      this.btnLoadB.TabIndex = 4;
      this.btnLoadB.Text = "Load";
      this.btnLoadB.UseVisualStyleBackColor = true;
      this.btnLoadB.Click += new System.EventHandler(this.btnLoadB_Click);
      // 
      // btnUnloadA
      // 
      this.btnUnloadA.Enabled = false;
      this.btnUnloadA.Location = new System.Drawing.Point(87, 36);
      this.btnUnloadA.Name = "btnUnloadA";
      this.btnUnloadA.Size = new System.Drawing.Size(75, 23);
      this.btnUnloadA.TabIndex = 2;
      this.btnUnloadA.Text = "Unload";
      this.btnUnloadA.UseVisualStyleBackColor = true;
      this.btnUnloadA.Click += new System.EventHandler(this.btnUnloadA_Click);
      // 
      // btnUnloadB
      // 
      this.btnUnloadB.Enabled = false;
      this.btnUnloadB.Location = new System.Drawing.Point(87, 78);
      this.btnUnloadB.Name = "btnUnloadB";
      this.btnUnloadB.Size = new System.Drawing.Size(75, 23);
      this.btnUnloadB.TabIndex = 5;
      this.btnUnloadB.Text = "Unload";
      this.btnUnloadB.UseVisualStyleBackColor = true;
      this.btnUnloadB.Click += new System.EventHandler(this.btnUnloadB_Click);
      // 
      // listBoxChosenCompares
      // 
      this.listBoxChosenCompares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBoxChosenCompares.FormattingEnabled = true;
      this.listBoxChosenCompares.Location = new System.Drawing.Point(12, 337);
      this.listBoxChosenCompares.Name = "listBoxChosenCompares";
      this.listBoxChosenCompares.Size = new System.Drawing.Size(434, 95);
      this.listBoxChosenCompares.TabIndex = 5;
      // 
      // saveFileDialogCSV
      // 
      this.saveFileDialogCSV.DefaultExt = "csv";
      this.saveFileDialogCSV.Filter = "Komma-Seperated-Files|*.csv";
      this.saveFileDialogCSV.Title = "Export results to csv";
      // 
      // grbOptions
      // 
      this.grbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.grbOptions.Controls.Add(this.controlOptions);
      this.grbOptions.Controls.Add(this.lblRandomize);
      this.grbOptions.Controls.Add(this.nudRandomSequenceModel);
      this.grbOptions.Controls.Add(this.lblRandomSequenceModelTimes);
      this.grbOptions.Location = new System.Drawing.Point(452, 12);
      this.grbOptions.Name = "grbOptions";
      this.grbOptions.Size = new System.Drawing.Size(173, 129);
      this.grbOptions.TabIndex = 6;
      this.grbOptions.TabStop = false;
      this.grbOptions.Text = "Options";
      // 
      // lblRandomize
      // 
      this.lblRandomize.AutoSize = true;
      this.lblRandomize.Location = new System.Drawing.Point(6, 82);
      this.lblRandomize.Name = "lblRandomize";
      this.lblRandomize.Size = new System.Drawing.Size(117, 13);
      this.lblRandomize.TabIndex = 3;
      this.lblRandomize.Text = "Randomize Sequences";
      // 
      // btnAddCompare
      // 
      this.btnAddCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAddCompare.Location = new System.Drawing.Point(12, 308);
      this.btnAddCompare.Name = "btnAddCompare";
      this.btnAddCompare.Size = new System.Drawing.Size(79, 23);
      this.btnAddCompare.TabIndex = 2;
      this.btnAddCompare.Text = "Add Compare";
      this.btnAddCompare.UseVisualStyleBackColor = true;
      this.btnAddCompare.Click += new System.EventHandler(this.btnAddCompare_Click);
      // 
      // openFileDialogXML
      // 
      this.openFileDialogXML.DefaultExt = "xml";
      this.openFileDialogXML.Filter = "Xml-Files|*.xml";
      // 
      // saveFileDialogXML
      // 
      this.saveFileDialogXML.DefaultExt = "xml";
      this.saveFileDialogXML.Filter = "Xml-Files|*.xml";
      // 
      // txtSavePath
      // 
      this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSavePath.Location = new System.Drawing.Point(97, 310);
      this.txtSavePath.Name = "txtSavePath";
      this.txtSavePath.Size = new System.Drawing.Size(318, 20);
      this.txtSavePath.TabIndex = 3;
      // 
      // btnChoseSafepath
      // 
      this.btnChoseSafepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnChoseSafepath.Location = new System.Drawing.Point(421, 308);
      this.btnChoseSafepath.Name = "btnChoseSafepath";
      this.btnChoseSafepath.Size = new System.Drawing.Size(25, 23);
      this.btnChoseSafepath.TabIndex = 4;
      this.btnChoseSafepath.Text = "...";
      this.btnChoseSafepath.UseVisualStyleBackColor = true;
      this.btnChoseSafepath.Click += new System.EventHandler(this.btnChoseSafepath_Click);
      // 
      // grbExistingSequences
      // 
      this.grbExistingSequences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.grbExistingSequences.Controls.Add(this.lblRandomizedSequencesB);
      this.grbExistingSequences.Controls.Add(this.lblRandomizedSequencesA);
      this.grbExistingSequences.Controls.Add(this.btnLoadA);
      this.grbExistingSequences.Controls.Add(this.btnUnloadB);
      this.grbExistingSequences.Controls.Add(this.btnUnloadA);
      this.grbExistingSequences.Controls.Add(this.btnLoadB);
      this.grbExistingSequences.Location = new System.Drawing.Point(452, 147);
      this.grbExistingSequences.Name = "grbExistingSequences";
      this.grbExistingSequences.Size = new System.Drawing.Size(173, 117);
      this.grbExistingSequences.TabIndex = 7;
      this.grbExistingSequences.TabStop = false;
      this.grbExistingSequences.Text = "Existing Sequences";
      // 
      // lblRandomizedSequencesB
      // 
      this.lblRandomizedSequencesB.AutoSize = true;
      this.lblRandomizedSequencesB.Location = new System.Drawing.Point(6, 62);
      this.lblRandomizedSequencesB.Name = "lblRandomizedSequencesB";
      this.lblRandomizedSequencesB.Size = new System.Drawing.Size(143, 13);
      this.lblRandomizedSequencesB.TabIndex = 3;
      this.lblRandomizedSequencesB.Text = "Randomized sequence set B";
      // 
      // lblRandomizedSequencesA
      // 
      this.lblRandomizedSequencesA.AutoSize = true;
      this.lblRandomizedSequencesA.Location = new System.Drawing.Point(6, 20);
      this.lblRandomizedSequencesA.Name = "lblRandomizedSequencesA";
      this.lblRandomizedSequencesA.Size = new System.Drawing.Size(143, 13);
      this.lblRandomizedSequencesA.TabIndex = 0;
      this.lblRandomizedSequencesA.Text = "Randomized sequence set A";
      // 
      // btnLockSequences
      // 
      this.btnLockSequences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLockSequences.Location = new System.Drawing.Point(469, 357);
      this.btnLockSequences.Name = "btnLockSequences";
      this.btnLockSequences.Size = new System.Drawing.Size(75, 75);
      this.btnLockSequences.TabIndex = 8;
      this.btnLockSequences.Text = "Lock";
      this.toolTip.SetToolTip(this.btnLockSequences, "Creates the randomized sequences and keeps them in memory to reuse them");
      this.btnLockSequences.UseVisualStyleBackColor = true;
      this.btnLockSequences.Click += new System.EventHandler(this.btnLockSequences_Click);
      // 
      // tableLayoutPanelSequences
      // 
      this.tableLayoutPanelSequences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanelSequences.ColumnCount = 2;
      this.tableLayoutPanelSequences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanelSequences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanelSequences.Controls.Add(this.controlSequencesA, 0, 0);
      this.tableLayoutPanelSequences.Controls.Add(this.controlSequencesB, 1, 0);
      this.tableLayoutPanelSequences.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanelSequences.Name = "tableLayoutPanelSequences";
      this.tableLayoutPanelSequences.RowCount = 1;
      this.tableLayoutPanelSequences.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanelSequences.Size = new System.Drawing.Size(434, 290);
      this.tableLayoutPanelSequences.TabIndex = 10;
      // 
      // controlSequencesA
      // 
      this.controlSequencesA.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlSequencesA.Location = new System.Drawing.Point(3, 3);
      this.controlSequencesA.Name = "controlSequencesA";
      this.controlSequencesA.Size = new System.Drawing.Size(211, 284);
      this.controlSequencesA.TabIndex = 0;
      // 
      // controlSequencesB
      // 
      this.controlSequencesB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlSequencesB.Location = new System.Drawing.Point(220, 3);
      this.controlSequencesB.Name = "controlSequencesB";
      this.controlSequencesB.Size = new System.Drawing.Size(211, 284);
      this.controlSequencesB.TabIndex = 1;
      // 
      // controlOptions
      // 
      this.controlOptions.Location = new System.Drawing.Point(6, 19);
      this.controlOptions.Name = "controlOptions";
      this.controlOptions.Size = new System.Drawing.Size(113, 51);
      this.controlOptions.TabIndex = 6;
      // 
      // DialogNeedlemanWunschRandomizer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 450);
      this.Controls.Add(this.tableLayoutPanelSequences);
      this.Controls.Add(this.btnLockSequences);
      this.Controls.Add(this.grbExistingSequences);
      this.Controls.Add(this.btnRandomSequenceModel);
      this.Controls.Add(this.btnChoseSafepath);
      this.Controls.Add(this.txtSavePath);
      this.Controls.Add(this.btnAddCompare);
      this.Controls.Add(this.grbOptions);
      this.Controls.Add(this.listBoxChosenCompares);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(653, 489);
      this.Name = "DialogNeedlemanWunschRandomizer";
      this.Text = "Randomizer";
      ((System.ComponentModel.ISupportInitialize)(this.nudRandomSequenceModel)).EndInit();
      this.grbOptions.ResumeLayout(false);
      this.grbOptions.PerformLayout();
      this.grbExistingSequences.ResumeLayout(false);
      this.grbExistingSequences.PerformLayout();
      this.tableLayoutPanelSequences.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLoadA;
    private System.Windows.Forms.Button btnRandomSequenceModel;
    private System.Windows.Forms.NumericUpDown nudRandomSequenceModel;
    private System.Windows.Forms.Label lblRandomSequenceModelTimes;
    private System.Windows.Forms.Button btnLoadB;
    private System.Windows.Forms.Button btnUnloadA;
    private System.Windows.Forms.Button btnUnloadB;
    private ControlSequences controlSequencesB;
    private ControlSequences controlSequencesA;
    private System.Windows.Forms.ListBox listBoxChosenCompares;
    private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
    private System.Windows.Forms.GroupBox grbOptions;
    private System.Windows.Forms.Button btnAddCompare;
    private System.Windows.Forms.OpenFileDialog openFileDialogXML;
    private System.Windows.Forms.SaveFileDialog saveFileDialogXML;
    private System.Windows.Forms.TextBox txtSavePath;
    private System.Windows.Forms.Button btnChoseSafepath;
    private System.Windows.Forms.Label lblRandomize;
    private System.Windows.Forms.GroupBox grbExistingSequences;
    private System.Windows.Forms.Label lblRandomizedSequencesB;
    private System.Windows.Forms.Label lblRandomizedSequencesA;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.Button btnLockSequences;
    private ControlOptions controlOptions;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSequences;
  }
}