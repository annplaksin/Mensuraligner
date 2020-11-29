using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mensuraligner;
using System;
using System.Collections.Generic;
//using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence;
using mei2Sequence.Model;
using System.IO;
using System.Xml.Serialization;

namespace Mensuraligner.Tests
{
  [TestClass()]
  public class NeedlemanWunschTests
  {
    /*private TestContext testContextInstance;
    public TestContext TestContext
    {
      get { return testContextInstance; }
      set { testContextInstance = value; }
    }*/

      //Loading test cases from CSV file doesn't work, don't get the problem... o_O

    [TestMethod()]
    [DataRow("..\\..\\files\\TinyAlignA.xml", "..\\..\\files\\TinyAlignB.xml", "MensurAlignLogical", "..\\..\\files\\TinyAlign_resultMatrix.txt")]
    [DataRow("..\\..\\files\\MensurAlignA.xml", "..\\..\\files\\MensurAlignB.xml", "MensurAlignVisual", "..\\..\\files\\MensurAlignVisual_resultMatrix.txt")]
    [DataRow("..\\..\\files\\MensurAlignA.xml", "..\\..\\files\\MensurAlignB.xml", "MensurAlignLogical", "..\\..\\files\\MensurAlignLogical_resultMatrix.txt")]
    //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "..\\..\\files\\tests.csv", "..\\..\\files\\tests#csv", DataAccessMethod.Sequential)]
    public void NeedlemanWunschMatrixTest(string seqDirA, string seqDirB, string optionSet, string resultDir)
    {
      //List<Sequence> seqA = Controller.GetSequences(TestContext.DataRow["seqA"].ToString());
      List<Sequence> seqA = Controller.GetSequences(seqDirA);
      ConvertSequences(seqA);

      //List<Sequence> seqB = Controller.GetSequences(TestContext.DataRow["seqB"].ToString());
      List<Sequence> seqB = Controller.GetSequences(seqDirB);
      ConvertSequences(seqB);

      decimal[,] expectedResult = ReadResultMatrix(resultDir);

      NeedlemanWunschOptions options = ReadOptionsFromFile(optionSet);

      NeedlemanWunsch matrix = new NeedlemanWunsch(seqA.ToList(), seqB.ToList(), options);

      decimal[,] alignmatrix = GetAlignmatrix(matrix);

      CollectionAssert.AreEqual(expectedResult, alignmatrix);
    }

    [TestMethod()]
    [DataRow("..\\..\\files\\TinyAlignA.xml", "..\\..\\files\\TinyAlignB.xml", "MensurAlignLogical", "..\\..\\files\\TinyAlign_resultDirections.txt")]
    [DataRow("..\\..\\files\\MensurAlignA.xml", "..\\..\\files\\MensurAlignB.xml", "MensurAlignVisual", "..\\..\\files\\MensurAlignVisual_resultDirections.txt")]
    [DataRow("..\\..\\files\\MensurAlignA.xml", "..\\..\\files\\MensurAlignB.xml", "MensurAlignLogical", "..\\..\\files\\MensurAlignLogical_resultDirections.txt")]
    public void NeedlemanWunschDirectionTest(string seqDirA, string seqDirB, string optionSet, string resultDir)
    {
      List<Sequence> seqA = Controller.GetSequences(seqDirA);
      ConvertSequences(seqA);
      List<Sequence> seqB = Controller.GetSequences(seqDirB);
      ConvertSequences(seqB);

      decimal[,] resultArr = ReadResultMatrix(resultDir);
      int[,] expectedDirs = new int[resultArr.GetLength(0), resultArr.GetLength(1)];
      for (int i = 0; i < resultArr.GetLength(0); i++)
      {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
          expectedDirs[i, j] = (int)resultArr[i, j];
        }
      }

      NeedlemanWunschOptions options = ReadOptionsFromFile(optionSet);

      NeedlemanWunsch matrix = new NeedlemanWunsch(seqA.ToList(), seqB.ToList(), options);
      int[,] actualDirs = GetAlignDirections(matrix);

      CollectionAssert.AreEqual(expectedDirs, actualDirs);
    }

    #region Helping methods
    /// <summary>
    /// Read NeedlemanWunschOptions from settings file
    /// </summary>
    /// <param name="_optionSet">Set of options</param>
    /// <returns>NeedlemanWunschOptions object</returns>
    private NeedlemanWunschOptions ReadOptionsFromFile(string _optionSet)
    {
      List<NeedlemanWunschOptions> lstOptions = new List<NeedlemanWunschOptions>();
      string settingsFile = "..\\..\\files\\Settings.xml";

      // Check if the user has saved Settings
      if (File.Exists(settingsFile))
      {
        XmlSerializer serializer = new XmlSerializer(typeof(List<NeedlemanWunschOptions>));
        using (FileStream fs = new FileStream(settingsFile, FileMode.Open))
        {
          lstOptions = (List<NeedlemanWunschOptions>)serializer.Deserialize(fs);
          fs.Close();
        }

      }
      else
      {
        throw new Exception("No Settings.xml available!");
      }

      return lstOptions.Find(i => i.Name == _optionSet);
    }

    /// <summary>
    /// Reads the expexted matrix from text file
    /// </summary>
    /// <param name="_filepath">Location of expected matrix file</param>
    /// <returns>decimal array</returns>
    private decimal[,] ReadResultMatrix(string _filepath)
    {
      List<List<decimal>> lstArrDecimals = new List<List<decimal>>();

      //System.IO.StreamReader file = new System.IO.StreamReader(TestContext.DataRow["result"].ToString());
      System.IO.StreamReader file = new System.IO.StreamReader(_filepath);
      while (file.EndOfStream == false)
      {
        List<decimal> lstLine = new List<decimal>();
        string line = file.ReadLine();

        string[] strSplit = line.Split(';');

        foreach (string strAktuell in strSplit)
        {
          decimal decValue = decimal.Parse(strAktuell);
          lstLine.Add(decValue);
        }

        lstArrDecimals.Add(lstLine);
      }

      decimal[,] arrDecimals = new decimal[lstArrDecimals.Count, lstArrDecimals.Max(item => item.Count)];

      for (int intIndexI = 0; intIndexI < lstArrDecimals.Count; intIndexI++)
      {
        List<decimal> lstAktuell = lstArrDecimals[intIndexI];
        for (int intIndexJ = 0; intIndexJ < lstAktuell.Count; intIndexJ++)
        {
          arrDecimals[intIndexI, intIndexJ] = lstAktuell[intIndexJ];
        }
      }

      return arrDecimals;
    }

    /// <summary>
    /// Converts matrix in NeedlemanWunsch object to array
    /// </summary>
    /// <param name="_matrix">NeedlemanWunsch object</param>
    /// <returns>decimal array</returns>
    private decimal[,] GetAlignmatrix(NeedlemanWunsch _matrix)
    {
      decimal[,] alignmatrix = new decimal[_matrix.Alignments.GetLength(0), _matrix.Alignments.GetLength(1)];

      //Lines
      for (int i = 0; i < _matrix.Alignments.GetLength(1); i++)
      {
        //Rows
        for (int j = 0; j < _matrix.Alignments.GetLength(0); j++)
        {
          alignmatrix[i, j] = _matrix.Alignments[i, j].Alignment;
        }
      }

      return alignmatrix;
    }

    /// <summary>
    /// Converts alignment directions in NeedlemanWunsch object to array
    /// </summary>
    /// <param name="_matrix">Needleman Wunsch object</param>
    /// <returns>int array</returns>
    private int[,] GetAlignDirections(NeedlemanWunsch _matrix)
    {
      int[,] alignDirs = new int[_matrix.Alignments.GetLength(0), _matrix.Alignments.GetLength(1)];

      //Lines
      for (int i = 0; i < _matrix.Alignments.GetLength(0); i++)
      {
        //Rows
        for (int j = 0; j < _matrix.Alignments.GetLength(1); j++)
        {
          alignDirs[i, j] = (int)_matrix.Alignments[i, j].AlignDirection;
        }
      }

      return alignDirs;
    }

    /// <summary>
    /// Builds each sequence in list and calculates logical parameters
    /// </summary>
    /// <param name="_sequences">List of unconverted sequences</param>
    private void ConvertSequences(List<Sequence> _sequences)
    {
      foreach (Sequence seq in _sequences)
      {
        Controller.BuildSequence(seq);
        SequenceConversion.ConvertBrevePosition(seq);
        SequenceConversion.ConvertAbsolutePitch(seq);
      }
    }
    #endregion


  }
}