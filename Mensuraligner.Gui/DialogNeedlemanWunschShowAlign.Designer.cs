namespace Mensuraligner.Gui
{
  partial class DialogNeedlemanWunschShowAlign
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNeedlemanWunschShowAlign));
      this.dataGridViewAlignment = new System.Windows.Forms.DataGridView();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageMatrix = new System.Windows.Forms.TabPage();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlignment)).BeginInit();
      this.tabControl.SuspendLayout();
      this.tabPageMatrix.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridViewAlignment
      // 
      this.dataGridViewAlignment.AllowUserToAddRows = false;
      this.dataGridViewAlignment.AllowUserToDeleteRows = false;
      this.dataGridViewAlignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewAlignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewAlignment.ColumnHeadersVisible = false;
      this.dataGridViewAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewAlignment.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewAlignment.Name = "dataGridViewAlignment";
      this.dataGridViewAlignment.RowHeadersVisible = false;
      this.dataGridViewAlignment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.dataGridViewAlignment.ShowEditingIcon = false;
      this.dataGridViewAlignment.Size = new System.Drawing.Size(786, 418);
      this.dataGridViewAlignment.TabIndex = 0;
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPageMatrix);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(800, 450);
      this.tabControl.TabIndex = 1;
      // 
      // tabPageMatrix
      // 
      this.tabPageMatrix.Controls.Add(this.dataGridViewAlignment);
      this.tabPageMatrix.Location = new System.Drawing.Point(4, 22);
      this.tabPageMatrix.Name = "tabPageMatrix";
      this.tabPageMatrix.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMatrix.Size = new System.Drawing.Size(792, 424);
      this.tabPageMatrix.TabIndex = 1;
      this.tabPageMatrix.Text = "Matrix";
      this.tabPageMatrix.UseVisualStyleBackColor = true;
      // 
      // DialogNeedlemanWunschShowAlign
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DialogNeedlemanWunschShowAlign";
      this.Text = "Show alignments";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlignment)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.tabPageMatrix.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewAlignment;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageMatrix;
  }
}