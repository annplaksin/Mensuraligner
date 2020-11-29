using CSVExport;
using mei2Sequence.Model;
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
  /// The Main Form to display the opened files and do things with them
  /// Icon taken from http://www.iconninja.com/oct-icon-sets-762
  /// </summary>
  public partial class MainMenu : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public MainMenu()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Calls OpenFileTabs for a List
    /// </summary>
    /// <param name="_fileNameList">List with file names</param>
    private void OpenFileTabs(List<string> _fileNameList)
    {
      OpenFileTabs(_fileNameList.ToArray());
    }

    /// <summary>
    /// Opens a tab per file
    /// </summary>
    /// <param name="_fileNames">File names as string array</param>
    private void OpenFileTabs(string[] _fileNames)
    {
      foreach (string fileName in _fileNames)
      {
        FileTabPage fileTab = new FileTabPage(fileName);
        this.FileControl.TabPages.Add(fileTab);
      }

      this.FileStatus.Text = this.FileControl.SelectedTab.Name;
      
    }

    /// <summary>
    /// Sets status bar text to file name
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SelectTab(object sender, EventArgs e)
    {
      this.FileStatus.Text = this.FileControl.SelectedTab.Name;
    }

    /// <summary>
    /// Gets all *.xml and *.mei file names in a directory and subdirectories
    /// </summary>
    /// <param name="_dir">Chosen directory</param>
    private List<string> OpenMeiFiles(string _dir)
    {
      List<string> meiFiles = new List<string>();

      string[] fileNames = Directory.GetFiles(_dir);
      foreach (string fileName in fileNames)
      {
        if (fileName.EndsWith(".xml") || fileName.EndsWith(".mei"))
        {
          meiFiles.Add(fileName);
        }
      }

      string[] dirNames = Directory.GetDirectories(_dir);
      foreach (string dirName in dirNames)
      {
        List<string> subMeiDirs = OpenMeiFiles(dirName);
        foreach (string subMeiFile in subMeiDirs)
        {
          meiFiles.Add(subMeiFile);
        }
        
      }

      return meiFiles;
    }

    #region Eventhandler
    private void dateiÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.openFileDialog.ShowDialog(this.FindForm()) == System.Windows.Forms.DialogResult.OK)
      {
        OpenFileTabs(this.openFileDialog.FileNames);
      }
    }

    private void ordnerÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.openFolder.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        string selectedFolder = this.openFolder.SelectedPath;

        List<string> meiFiles = OpenMeiFiles(selectedFolder);

        OpenFileTabs(meiFiles);
      }
    }

    private void toolStripMenuItemCSVExport_Click(object sender, EventArgs e)
    {
      if (this.FileControl.SelectedTab is FileTabPage tabPageSelected)
      {
        var itemsSelected = tabPageSelected.SequencesSelected;
        
        CSVExporter exporter = new CSVExporter(ObjectWriter.HEADERS);

        foreach (Sequence sequenceAktuell in itemsSelected)
        {
          foreach (ObjectInSequence obj in sequenceAktuell.ObjectsInSequence)
          {
            exporter.AddLine(ObjectWriter.GetStringData(obj));
          }
        }
        
        using (DialogCSVExport dialogExport = new DialogCSVExport())
        {
          dialogExport.Exporter = exporter;

          dialogExport.ShowDialog(this.FindForm());
        }
        // exporter.WriteCSV(@"d:\temp\test.csv");
      }
      else
      {
        // Nothing selected...every TabPage should be a FileTabPage
        MessageBox.Show("Please select a Page to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void toolStripMenuItemNeedlemanWunsch_Click(object sender, EventArgs e)
    {
      using (DialogNeedlemanWunschAlign dialog = new DialogNeedlemanWunschAlign())
      {
        // Set the Data
        Dictionary<string, List<Sequence>> dicSequences2Filename = new Dictionary<string, List<Sequence>>();
        foreach (FileTabPage tabPageAktuell in this.FileControl.TabPages)
        {
          dicSequences2Filename.Add(tabPageAktuell.Filename, new List<Sequence>(tabPageAktuell.SequencesShown));
        }
        dialog.SetData(dicSequences2Filename);
        // Show the dialog
        dialog.ShowDialog(this.FindForm());
      }
    }

    private void toolStripMenuItemNeighborJoining_Click(object sender, EventArgs e)
    {
      using (DialogNeighborJoining dialog = new DialogNeighborJoining())
      {
        // Set the Data
        Dictionary<string, List<Sequence>> dicSequences2Filename = new Dictionary<string, List<Sequence>>();
        foreach (FileTabPage tabPageAktuell in this.FileControl.TabPages)
        {
          dicSequences2Filename.Add(tabPageAktuell.Filename, new List<Sequence>(tabPageAktuell.SequencesShown));
        }
        dialog.SetData(dicSequences2Filename);
        // Show the dialog
        dialog.ShowDialog(this.FindForm());
      }
    }
    
    private void toolStripMenuItemRandomizer_Click(object sender, EventArgs e)
    {
      using (DialogNeedlemanWunschRandomizer dialog = new DialogNeedlemanWunschRandomizer())
      {
        // Set the Data
        Dictionary<string, List<Sequence>> dicSequences2Filename = new Dictionary<string, List<Sequence>>();
        foreach (FileTabPage tabPageAktuell in this.FileControl.TabPages)
        {
          dicSequences2Filename.Add(tabPageAktuell.Filename, new List<Sequence>(tabPageAktuell.SequencesShown));
        }
        dialog.SetData(dicSequences2Filename);
        // Show the dialog
        dialog.ShowDialog(this.FindForm());
      }
    }
    #endregion
  }
}
