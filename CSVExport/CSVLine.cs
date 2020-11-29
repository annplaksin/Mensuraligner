using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVExport
{
  /// <summary>
  /// Klasse für eine Ausgabezeile
  /// </summary>
  internal class CSVLine
  {
    private readonly string[] strArrData = null;

    #region Konstruktoren
    /// <summary>
    /// Konstruktor - initializes the Content
    /// </summary>
    /// <param name="_columns">Number of Columns in the Export</param>
    public CSVLine(int _columns)
    {
      this.strArrData = new string[_columns];
      // Write an empty string in each field
      for (int intIndex = 0; intIndex < _columns; intIndex++)
      {
        this.strArrData[intIndex] = string.Empty;
      }
    }

    /// <summary>
    /// Konstruktor - initializes the Content
    /// </summary>
    /// <param name="_columns">Number of Columns in the Export</param>
    /// <param name="_content">The Content for the Columns. Fills from the beginning - throws an Exception when there is more Content then Columns</param>
    public CSVLine(int _columns, params string[] _content) : this(_columns)
    {
      if (_content.Length > _columns)
      {
        throw new InvalidOperationException("You have more content then columns!");
      }

      for (int intIndex = 0; intIndex < _content.Length; intIndex++)
      {
        this.strArrData[intIndex] = _content[intIndex];
      }
    }
    #endregion

    /// <summary>
    /// Returns the Number of Columns in this line
    /// </summary>
    public int ColumnCount
    {
      get
      {
        return this.strArrData.Length;
      }
    }

    /// <summary>
    /// Gets the text for this line
    /// </summary>
    /// <param name="_delimiter"></param>
    /// <param name="_quote"></param>
    /// <param name="_escape"></param>
    /// <returns></returns>
    public string GetAusgabe(string _delimiter, string _quote, string _escape)
    {
      StringBuilder strBuilderReturn = new StringBuilder();

      for (int intIndex = 0; intIndex < this.strArrData.Length; intIndex++)
      {
        // When we are not at the first item write an delimiter
        if (intIndex > 0)
        {
          strBuilderReturn.Append(_delimiter);
        }
        // Check if the dataset contains something that needs to be quoted
        bool bolNeedQuote = CheckForQuoteCharacters(this.strArrData[intIndex], _delimiter, _quote);
        // If yes start with a quote
        if (bolNeedQuote)
        {
          strBuilderReturn.Append(_quote);
        }

        // If the string contains a quote we need to escape it
        strBuilderReturn.Append(this.strArrData[intIndex]?.Replace(_quote, _escape + _quote));

        // And the closing quote
        if (bolNeedQuote)
        {
          strBuilderReturn.Append(_quote);
        }
      }

      return strBuilderReturn.ToString();
    }

    private bool CheckForQuoteCharacters(string _strCheck, string _delimiter, string _quote)
    {
      return
        _strCheck != null
        && (_strCheck.Contains(_delimiter)
        || _strCheck.Contains(_quote)
        || _strCheck.Contains("\r")
        || _strCheck.Contains("\n"));
    }
  }
}
