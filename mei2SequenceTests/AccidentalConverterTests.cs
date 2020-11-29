using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei2Sequence;
using mei2Sequence.Model;
using mei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class AccidentalConverterTests
  {
    mei.Accid meiaccid;
    Model.Accidental convertedAccid;
    mei.KeyAccid meikey;
    Model.KeyAccidental convertedkey;

    [TestInitialize]
    public void Init()
    {
      meiaccid = new Accid();
      convertedAccid = new Accidental();
      meikey = new KeyAccid();
      convertedkey = new KeyAccidental();
    }
    
    [TestMethod()]
    [DataRow("above", Position.Above)]
    [DataRow("below", Position.Below)]
    [DataRow("before", Position.Null)]
    [DataRow(null, Position.Null)]
    public void ConvertAccidentalTest_Position(string meipos, Model.Position convertedPos)
    {
      if (meipos != null)
      {
        meiaccid.SetAccidPos(meipos);
      }
      
      AccidentalConverter.ConvertAccidental(convertedAccid, meiaccid);

      Assert.AreEqual(convertedPos, convertedAccid.AccidentalPosition);
    }

    [TestMethod()]
    [DataRow("f", AccidType.Flat)]
    [DataRow("s", AccidType.Sharp)]
    [DataRow(null, AccidType.Null)]
    public void ConvertAccidentalTest_AccidType(string meitype, Model.AccidType convertedType)
    {
      if (meitype != null)
      {
        meiaccid.SetAccid(meitype);
      }

      AccidentalConverter.ConvertAccidental(convertedAccid, meiaccid);

      Assert.AreEqual(convertedType, convertedAccid.AccidentalType);
    }

    [TestMethod()]
    [DataRow("f", AccidType.Flat)]
    [DataRow("s", AccidType.Sharp)]
    [DataRow(null, AccidType.Null)]
    public void ConvertKeyAccidentalTest_AccidType(string meitype, Model.AccidType convertedType)
    {
      if (meitype != null)
      {
        meikey.SetAccid(meitype);
      }

      AccidentalConverter.ConvertKeyAccidental(convertedkey, meikey);

      Assert.AreEqual(convertedType, convertedkey.AccidentalType);
    }

    [TestMethod()]
    [ExpectedException(typeof(InvalidOperationException))]
    [DataRow("bla")]
    [DataRow("ss")]
    [DataRow("ff")]
    public void ConvertKeyAccidentalTest_InvalidAccidType(string meitype)
    {
      meikey.SetAccid(meitype);

      AccidentalConverter.ConvertKeyAccidental(convertedkey, meikey);
    }

    [TestMethod()]
    [ExpectedException(typeof(InvalidOperationException))]
    [DataRow("bla")]
    [DataRow("ss")]
    [DataRow("ff")]
    public void ConvertAccidentalTest_InvalidAccidType(string meitype)
    {
      meiaccid.SetAccid(meitype);

      AccidentalConverter.ConvertAccidental(convertedAccid, meiaccid);
    }

    // pitch = octave * 40 + chroma
    //G4 = 4 * 40 + 25 = 160 + 25 = 185
    //C4 is 162 while C5 is 162+40=202
    [TestMethod()]
    [DataRow("g", "4", 185)]
    [DataRow("c", "4", 162)]
    [DataRow("c", "5", 202)]
    [DataRow("b", "4", 197)]
    public void ConvertAccidentalTest_PitchLocation(string _pname, string _oct, int _base40)
    {
      if (_pname != null)
      {
        meiaccid.SetPloc(_pname);
      }
      if (_oct != null)
      {
        meiaccid.SetOloc(_oct);
      }

      AccidentalConverter.ConvertAccidental(convertedAccid, meiaccid);

      Assert.AreEqual(_base40, convertedAccid.PitchLocation);
    }

    [TestMethod()]
    [DataRow("g", "4", 185)]
    [DataRow("c", "4", 162)]
    [DataRow("c", "5", 202)]
    [DataRow("b", "4", 197)]
    public void ConvertKeyAccidentalTest_PitchLocation(string _pname, string _oct, int _base40)
    {
      if (_pname != null)
      {
        meikey.SetPname(_pname);
      }
      if (_oct != null)
      {
        meikey.SetOct(_oct);
      }

      AccidentalConverter.ConvertKeyAccidental(convertedkey, meikey);

      Assert.AreEqual(_base40, convertedkey.PitchLocation);
    }

    [TestCleanup()]
    public void Cleanup()
    {
      meiaccid = null;
      convertedAccid = null;
      meikey = null;
      convertedkey = null;
    }
  }
}