namespace Mensuraligner.Gui
{
  partial class ControlSequences
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
      this.cmbFiles = new System.Windows.Forms.ComboBox();
      this.listSequences = new ListSequences();
      this.listSequencesSelected = new ListSequences();
      this.btnAllDown = new System.Windows.Forms.Button();
      this.btnOneDown = new System.Windows.Forms.Button();
      this.btnOneUp = new System.Windows.Forms.Button();
      this.btnAllUp = new System.Windows.Forms.Button();
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmbFiles
      // 
      this.cmbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel.SetColumnSpan(this.cmbFiles, 4);
      this.cmbFiles.FormattingEnabled = true;
      this.cmbFiles.Location = new System.Drawing.Point(0, 3);
      this.cmbFiles.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.cmbFiles.Name = "cmbFiles";
      this.cmbFiles.Size = new System.Drawing.Size(197, 21);
      this.cmbFiles.TabIndex = 2;
      this.cmbFiles.SelectedIndexChanged += new System.EventHandler(this.cmbFiles_SelectedIndexChanged);
      // 
      // listSequences
      // 
      this.listSequences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel.SetColumnSpan(this.listSequences, 4);
      this.listSequences.FormattingEnabled = true;
      this.listSequences.Location = new System.Drawing.Point(0, 30);
      this.listSequences.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.listSequences.Name = "listSequences";
      this.listSequences.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listSequences.ShowPiece = false;
      this.listSequences.Size = new System.Drawing.Size(197, 238);
      this.listSequences.TabIndex = 3;
      this.listSequences.DoubleClick += new System.EventHandler(this.listSequences_DoubleClick);
      // 
      // listSequencesSelected
      // 
      this.listSequencesSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel.SetColumnSpan(this.listSequencesSelected, 4);
      this.listSequencesSelected.FormattingEnabled = true;
      this.listSequencesSelected.Location = new System.Drawing.Point(0, 308);
      this.listSequencesSelected.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.listSequencesSelected.Name = "listSequencesSelected";
      this.listSequencesSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listSequencesSelected.ShowPiece = false;
      this.listSequencesSelected.Size = new System.Drawing.Size(197, 108);
      this.listSequencesSelected.TabIndex = 4;
      this.listSequencesSelected.DoubleClick += new System.EventHandler(this.listSequencesSelected_DoubleClick);
      // 
      // btnAllDown
      // 
      this.btnAllDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAllDown.Location = new System.Drawing.Point(43, 279);
      this.btnAllDown.Name = "btnAllDown";
      this.btnAllDown.Size = new System.Drawing.Size(23, 23);
      this.btnAllDown.TabIndex = 5;
      this.btnAllDown.UseVisualStyleBackColor = true;
      this.btnAllDown.Click += new System.EventHandler(this.btnAllDown_Click);
      // 
      // btnOneDown
      // 
      this.btnOneDown.Location = new System.Drawing.Point(72, 279);
      this.btnOneDown.Name = "btnOneDown";
      this.btnOneDown.Size = new System.Drawing.Size(23, 23);
      this.btnOneDown.TabIndex = 6;
      this.btnOneDown.UseVisualStyleBackColor = true;
      this.btnOneDown.Click += new System.EventHandler(this.btnOneDown_Click);
      // 
      // btnOneUp
      // 
      this.btnOneUp.Location = new System.Drawing.Point(101, 279);
      this.btnOneUp.Name = "btnOneUp";
      this.btnOneUp.Size = new System.Drawing.Size(23, 23);
      this.btnOneUp.TabIndex = 7;
      this.btnOneUp.UseVisualStyleBackColor = true;
      this.btnOneUp.Click += new System.EventHandler(this.btnOneUp_Click);
      // 
      // btnAllUp
      // 
      this.btnAllUp.Location = new System.Drawing.Point(130, 279);
      this.btnAllUp.Name = "btnAllUp";
      this.btnAllUp.Size = new System.Drawing.Size(23, 23);
      this.btnAllUp.TabIndex = 8;
      this.btnAllUp.UseVisualStyleBackColor = true;
      this.btnAllUp.Click += new System.EventHandler(this.btnAllUp_Click);
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 4;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel.Controls.Add(this.cmbFiles, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.listSequencesSelected, 0, 3);
      this.tableLayoutPanel.Controls.Add(this.btnAllUp, 3, 2);
      this.tableLayoutPanel.Controls.Add(this.listSequences, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.btnOneUp, 2, 2);
      this.tableLayoutPanel.Controls.Add(this.btnAllDown, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.btnOneDown, 1, 2);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 4;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(197, 428);
      this.tableLayoutPanel.TabIndex = 9;
      // 
      // ControlSequences
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel);
      this.Name = "ControlSequences";
      this.Size = new System.Drawing.Size(197, 428);
      this.tableLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbFiles;
    private ListSequences listSequences;
    private ListSequences listSequencesSelected;
    private System.Windows.Forms.Button btnAllDown;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Button btnAllUp;
    private System.Windows.Forms.Button btnOneUp;
    private System.Windows.Forms.Button btnOneDown;
  }
}
