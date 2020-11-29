using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVExport
{
  /// <summary>
  /// A Class to do an csv-export
  /// </summary>
  public class CSVExporter
  {
    #region Private Member
    private readonly List<CSVLine> lstLines = new List<CSVLine>();
    #endregion

    #region Public-Member
    /// <summary>
    /// The delimiter between two datasets
    /// </summary>
    public string Delimiter
    {
      get;
      set;
    } = ";";

    /// <summary>
    /// The quote for quoting a dataset
    /// </summary>
    public string Quote
    {
      get;
      set;
    } = "\"";

    /// <summary>
    /// The Escape-Sign for a <see cref="Quote"/> inside a dataset
    /// </summary>
    public string Escape
    {
      get;
      set;
    } = "\"";

    /// <summary>
    /// The Encoding of the file
    /// </summary>
    public Encoding Encoding
    {
      get;
      set;
    } = Encoding.UTF8;

    /// <summary>
    /// Should the Headers be written in the first line?
    /// </summary>
    public bool WriteHeaders
    {
      get;
      set;
    } = true;
    #endregion

    #region Konstruktor
    /// <summary>
    /// Konstruktor - initializes the columns
    /// </summary>
    /// <param name="_columns"></param>
    public CSVExporter(params string[] _columns)
    {
      // Add the header to the lines
      this.lstLines.Add(new CSVLine(_columns.Length, _columns));
    }
    #endregion

    /// <summary>
    /// Adds a line of data to the csv
    /// </summary>
    /// <param name="_items"></param>
    public void AddLine(params string[] _items)
    {
      this.lstLines.Add(new CSVLine(this.lstLines[0].ColumnCount, _items));
    }

    /// <summary>
    /// Writes the csv-file to the given location
    /// </summary>
    /// <param name="_filePath"></param>
    public void WriteCSV(string _filePath)
    {
      using (TextWriter writer = new StreamWriter(File.Open(_filePath, FileMode.Create), this.Encoding))
      {
        for (int intLine = this.WriteHeaders ? 0 : 1; intLine < this.lstLines.Count; intLine++)
        {
          writer.WriteLine(this.lstLines[intLine].GetAusgabe(this.Delimiter, this.Quote, this.Escape));
        }

        writer.Flush();
        writer.Close();
      }
    }
  }
}
