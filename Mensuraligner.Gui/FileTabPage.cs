using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using mei2Sequence.Model;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// TabPage to shown a sequence
  /// </summary>
  public partial class FileTabPage : TabPage
  {
    private string strFilename;
    private readonly ShowSequences show;

    /// <summary>
    /// Constructor - Reads the file and initializes the Sequences
    /// </summary>
    /// <param name="_filename"></param>
    public FileTabPage(string _filename)
    {
      InitializeComponent();
      this.Name = _filename;
      this.Text = Path.GetFileName(_filename);

      show = new ShowSequences(_filename);
      show.Dock = DockStyle.Fill;
      this.Controls.Add(show);

      this.strFilename = Path.GetFileNameWithoutExtension(_filename);
    }

    /// <summary>
    /// Gets the selected Sequences
    /// </summary>
    public List<Sequence> SequencesSelected
    {
      get
      {
        return this.show.SequencesSelected;
      }
    }

    /// <summary>
    /// Gets the shown Sequences of this tab
    /// </summary>
    public List<Sequence> SequencesShown
    {
      get
      {
        return this.show.SequencesShown;
      }
    }

    /// <summary>
    /// Returns the Filename from which the Sequences were loaded - without Path or extension
    /// </summary>
    public string Filename
    {
      get
      {
        return this.strFilename;
      }
    }
  }
}
