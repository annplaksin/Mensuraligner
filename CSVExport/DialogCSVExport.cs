using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVExport
{
  /// <summary>
  /// Dialog to show the Export-Options and ask for the destination
  /// </summary>
  public partial class DialogCSVExport : Form
  {
    private CSVExporter varExporter = null;

    /// <summary>
    /// Contructor
    /// </summary>
    public DialogCSVExport()
    {
      InitializeComponent();

      // Fill the Encoding ComboBox
      foreach (EncodingInfo encodingAktuell in Encoding.GetEncodings())
      {
        this.cmbEncoding.Items.Add(encodingAktuell.GetEncoding());
      }
      this.cmbEncoding.DisplayMember = nameof(Encoding.EncodingName);
    }

    #region Properties
    /// <summary>
    /// Get/Set the Exporter to use
    /// </summary>
    public CSVExporter Exporter
    {
      get
      {
        this.varExporter.Delimiter = this.txtDelimiter.Text;
        this.varExporter.Encoding = (Encoding)this.cmbEncoding.SelectedItem;
        this.varExporter.Escape = this.txtEscape.Text;
        this.varExporter.Quote = this.txtQuote.Text;
        this.varExporter.WriteHeaders = this.cbxWriteheaders.Checked;

        return this.varExporter;
      }
      set
      {
        this.varExporter = value;

        this.txtDelimiter.Text = this.varExporter.Delimiter;
        this.cmbEncoding.SelectedItem = this.varExporter.Encoding;
        this.txtEscape.Text = this.varExporter.Escape;
        this.txtQuote.Text = this.varExporter.Quote;
        this.cbxWriteheaders.Checked = this.varExporter.WriteHeaders;
      }
    }
    #endregion

    #region Eventhandler
    private void btnSearch_Click(object sender, EventArgs e)
    {
      this.saveFileDialog.FileName = this.txtSavepath.Text;
      if (this.saveFileDialog.ShowDialog(this.FindForm()) == DialogResult.OK)
      {
        this.txtSavepath.Text = this.saveFileDialog.FileName;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      // Nothing else todo
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.Exporter.WriteCSV(this.txtSavepath.Text);
      this.Close();
    }
    #endregion
  }
}
