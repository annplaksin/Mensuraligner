namespace Mensuraligner.Gui
{
  partial class ShowSequences
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.SequenceList = new ListSequences();
      this.SequenceGridView = new System.Windows.Forms.DataGridView();
      this.sequencePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sequenceObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SequenceEvidence = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RestDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NoteWrittenPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.KeyAccidentalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RestBrevePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NotePitchWithAccid = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      ((System.ComponentModel.ISupportInitialize)(this.SequenceGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // SequenceList
      // 
      this.SequenceList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SequenceList.FormattingEnabled = true;
      this.SequenceList.Location = new System.Drawing.Point(0, 0);
      this.SequenceList.Name = "SequenceList";
      this.SequenceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.SequenceList.Size = new System.Drawing.Size(308, 549);
      this.SequenceList.TabIndex = 1;
      this.SequenceList.SelectedIndexChanged += new System.EventHandler(this.SequenceList_SelectedIndexChanged);
      // 
      // SequenceGridView
      // 
      this.SequenceGridView.AllowUserToAddRows = false;
      this.SequenceGridView.AllowUserToDeleteRows = false;
      this.SequenceGridView.AllowUserToResizeRows = false;
      this.SequenceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SequenceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencePosition,
            this.sequenceObjectType,
            this.SequenceEvidence,
            this.RestDuration,
            this.NoteWrittenPitch,
            this.KeyAccidentalType,
            this.RestBrevePos,
            this.NotePitchWithAccid});
      this.SequenceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SequenceGridView.Location = new System.Drawing.Point(0, 0);
      this.SequenceGridView.Name = "SequenceGridView";
      this.SequenceGridView.ReadOnly = true;
      this.SequenceGridView.RowHeadersVisible = false;
      this.SequenceGridView.Size = new System.Drawing.Size(617, 549);
      this.SequenceGridView.TabIndex = 2;
      // 
      // sequencePosition
      // 
      this.sequencePosition.Frozen = true;
      this.sequencePosition.HeaderText = "Position";
      this.sequencePosition.Name = "sequencePosition";
      this.sequencePosition.ReadOnly = true;
      // 
      // sequenceObjectType
      // 
      this.sequenceObjectType.HeaderText = "Object Type";
      this.sequenceObjectType.Name = "sequenceObjectType";
      this.sequenceObjectType.ReadOnly = true;
      this.sequenceObjectType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // SequenceEvidence
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.SequenceEvidence.DefaultCellStyle = dataGridViewCellStyle1;
      this.SequenceEvidence.HeaderText = "Evidence";
      this.SequenceEvidence.Name = "SequenceEvidence";
      this.SequenceEvidence.ReadOnly = true;
      this.SequenceEvidence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // RestDuration
      // 
      this.RestDuration.HeaderText = "Classification";
      this.RestDuration.Name = "RestDuration";
      this.RestDuration.ReadOnly = true;
      this.RestDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // NoteWrittenPitch
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.NoteWrittenPitch.DefaultCellStyle = dataGridViewCellStyle2;
      this.NoteWrittenPitch.HeaderText = "Pitch Position";
      this.NoteWrittenPitch.Name = "NoteWrittenPitch";
      this.NoteWrittenPitch.ReadOnly = true;
      this.NoteWrittenPitch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // KeyAccidentalType
      // 
      this.KeyAccidentalType.HeaderText = "Visual Features";
      this.KeyAccidentalType.Name = "KeyAccidentalType";
      this.KeyAccidentalType.ReadOnly = true;
      this.KeyAccidentalType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // RestBrevePos
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.RestBrevePos.DefaultCellStyle = dataGridViewCellStyle3;
      this.RestBrevePos.HeaderText = "Breve Position";
      this.RestBrevePos.Name = "RestBrevePos";
      this.RestBrevePos.ReadOnly = true;
      this.RestBrevePos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // NotePitchWithAccid
      // 
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.NotePitchWithAccid.DefaultCellStyle = dataGridViewCellStyle4;
      this.NotePitchWithAccid.HeaderText = "Inflected Pitch";
      this.NotePitchWithAccid.Name = "NotePitchWithAccid";
      this.NotePitchWithAccid.ReadOnly = true;
      this.NotePitchWithAccid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.SequenceList);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.SequenceGridView);
      this.splitContainer1.Size = new System.Drawing.Size(929, 549);
      this.splitContainer1.SplitterDistance = 308;
      this.splitContainer1.TabIndex = 3;
      // 
      // ShowSequences
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "ShowSequences";
      this.Size = new System.Drawing.Size(929, 549);
      ((System.ComponentModel.ISupportInitialize)(this.SequenceGridView)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private ListSequences SequenceList;
    private System.Windows.Forms.DataGridView SequenceGridView;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridViewTextBoxColumn sequencePosition;
    private System.Windows.Forms.DataGridViewTextBoxColumn sequenceObjectType;
    private System.Windows.Forms.DataGridViewTextBoxColumn SequenceEvidence;
    private System.Windows.Forms.DataGridViewTextBoxColumn RestDuration;
    private System.Windows.Forms.DataGridViewTextBoxColumn NoteWrittenPitch;
    private System.Windows.Forms.DataGridViewTextBoxColumn KeyAccidentalType;
    private System.Windows.Forms.DataGridViewTextBoxColumn RestBrevePos;
    private System.Windows.Forms.DataGridViewTextBoxColumn NotePitchWithAccid;
  }
}
