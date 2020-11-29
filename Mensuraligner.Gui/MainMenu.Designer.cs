namespace Mensuraligner.Gui
{
  partial class MainMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
      this.menuMain = new System.Windows.Forms.MenuStrip();
      this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dateiÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ordnerÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemCSVExport = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemAlignment = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemNeedlemanWunsch = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemNeighborJoining = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemRandomizer = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.FileStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.FileControl = new System.Windows.Forms.TabControl();
      this.menuMain.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuMain
      // 
      this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItemAlignment});
      this.menuMain.Location = new System.Drawing.Point(0, 0);
      this.menuMain.Name = "menuMain";
      this.menuMain.Size = new System.Drawing.Size(800, 24);
      this.menuMain.TabIndex = 0;
      this.menuMain.Text = "menuStrip1";
      // 
      // dateiToolStripMenuItem
      // 
      this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiÖffnenToolStripMenuItem,
            this.ordnerÖffnenToolStripMenuItem});
      this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      this.dateiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.dateiToolStripMenuItem.Text = "Open";
      // 
      // dateiÖffnenToolStripMenuItem
      // 
      this.dateiÖffnenToolStripMenuItem.Name = "dateiÖffnenToolStripMenuItem";
      this.dateiÖffnenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.dateiÖffnenToolStripMenuItem.Text = "Open file";
      this.dateiÖffnenToolStripMenuItem.Click += new System.EventHandler(this.dateiÖffnenToolStripMenuItem_Click);
      // 
      // ordnerÖffnenToolStripMenuItem
      // 
      this.ordnerÖffnenToolStripMenuItem.Name = "ordnerÖffnenToolStripMenuItem";
      this.ordnerÖffnenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.ordnerÖffnenToolStripMenuItem.Text = "Open directory";
      this.ordnerÖffnenToolStripMenuItem.Click += new System.EventHandler(this.ordnerÖffnenToolStripMenuItem_Click);
      // 
      // exportToolStripMenuItem
      // 
      this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCSVExport});
      this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
      this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.exportToolStripMenuItem.Text = "Export";
      // 
      // toolStripMenuItemCSVExport
      // 
      this.toolStripMenuItemCSVExport.Name = "toolStripMenuItemCSVExport";
      this.toolStripMenuItemCSVExport.Size = new System.Drawing.Size(95, 22);
      this.toolStripMenuItemCSVExport.Text = "CSV";
      this.toolStripMenuItemCSVExport.Click += new System.EventHandler(this.toolStripMenuItemCSVExport_Click);
      // 
      // toolStripMenuItemAlignment
      // 
      this.toolStripMenuItemAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNeedlemanWunsch,
            this.toolStripMenuItemNeighborJoining,
            this.toolStripMenuItemRandomizer});
      this.toolStripMenuItemAlignment.Name = "toolStripMenuItemAlignment";
      this.toolStripMenuItemAlignment.Size = new System.Drawing.Size(75, 20);
      this.toolStripMenuItemAlignment.Text = "Alignment";
      // 
      // toolStripMenuItemNeedlemanWunsch
      // 
      this.toolStripMenuItemNeedlemanWunsch.Name = "toolStripMenuItemNeedlemanWunsch";
      this.toolStripMenuItemNeedlemanWunsch.Size = new System.Drawing.Size(183, 22);
      this.toolStripMenuItemNeedlemanWunsch.Text = "Needleman-Wunsch";
      this.toolStripMenuItemNeedlemanWunsch.Click += new System.EventHandler(this.toolStripMenuItemNeedlemanWunsch_Click);
      // 
      // toolStripMenuItemNeighborJoining
      // 
      this.toolStripMenuItemNeighborJoining.Name = "toolStripMenuItemNeighborJoining";
      this.toolStripMenuItemNeighborJoining.Size = new System.Drawing.Size(183, 22);
      this.toolStripMenuItemNeighborJoining.Text = "Neighbor Joining";
      this.toolStripMenuItemNeighborJoining.Click += new System.EventHandler(this.toolStripMenuItemNeighborJoining_Click);
      // 
      // toolStripMenuItemRandomizer
      // 
      this.toolStripMenuItemRandomizer.Name = "toolStripMenuItemRandomizer";
      this.toolStripMenuItemRandomizer.Size = new System.Drawing.Size(183, 22);
      this.toolStripMenuItemRandomizer.Text = "Randomizer";
      this.toolStripMenuItemRandomizer.Click += new System.EventHandler(this.toolStripMenuItemRandomizer_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog";
      this.openFileDialog.Filter = "MEI files|*.mei;*.xml";
      this.openFileDialog.Multiselect = true;
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStatus});
      this.statusStrip.Location = new System.Drawing.Point(0, 428);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(800, 22);
      this.statusStrip.TabIndex = 1;
      this.statusStrip.Text = "statusStrip";
      // 
      // FileStatus
      // 
      this.FileStatus.Name = "FileStatus";
      this.FileStatus.Size = new System.Drawing.Size(44, 17);
      this.FileStatus.Text = "No File";
      // 
      // FileControl
      // 
      this.FileControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FileControl.Location = new System.Drawing.Point(0, 24);
      this.FileControl.Name = "FileControl";
      this.FileControl.SelectedIndex = 0;
      this.FileControl.Size = new System.Drawing.Size(800, 404);
      this.FileControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.FileControl.TabIndex = 2;
      this.FileControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.SelectTab);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.FileControl);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuMain;
      this.MinimumSize = new System.Drawing.Size(816, 489);
      this.Name = "MainMenu";
      this.Text = "Mensuraligner";
      this.menuMain.ResumeLayout(false);
      this.menuMain.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuMain;
    private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dateiÖffnenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ordnerÖffnenToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.FolderBrowserDialog openFolder;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel FileStatus;
    private System.Windows.Forms.TabControl FileControl;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCSVExport;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlignment;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeedlemanWunsch;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighborJoining;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRandomizer;
  }
}

