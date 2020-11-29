using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei2Sequence;
using mei2Sequence.Model;
using mei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Mehroz;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class NoteConverterTests
  {
    mei.Note meinote;
    Model.Note convertedNote;

    [TestInitialize()]
    public void Init()
    {
      meinote = new mei.Note();
      convertedNote = new Model.Note();
    }

    [TestMethod()]
    [DataRow("true",true)]
    [DataRow("false", false)]
    [DataRow(null, false)]
    public void ConvertNoteTest_Coloration(string colored, bool assert)
    {
      if (colored != null)
      {
        meinote.SetColored(colored);
      }
      
      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(assert, convertedNote.Coloration);
    }

    [TestMethod()]
    [DataRow("above", true)]
    [DataRow("below", true)]
    [DataRow(null, false)]
    public void ConvertNoteTest_Fermata(string fermata, bool assert)
    {
      if (fermata != null)
      {
        meinote.SetFermata(fermata);
      }

      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(assert, convertedNote.Fermata);
    }

    // pitch = octave * 40 + chroma
    //G4 = 4 * 40 + 25 = 160 + 25 = 185
    //C4 is 162 while C5 is 162+40=202
    [TestMethod()]
    [DataRow("g","4",185)]
    [DataRow("c","4",162)]
    [DataRow("c","5",202)]
    [DataRow("b","4",197)]
    public void ConvertNoteTest_WrittenPitch(string _pname, string _oct, int _base40)
    {
      if (_pname != null)
      {
        meinote.SetPname(_pname);
      }
      if (_oct != null)
      {
        meinote.SetOct(_oct);
      }

      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(_base40, convertedNote.WrittenPitch);
    }

    [TestMethod()]
    [DataRow("maxima",Model.Duration.Maxima)]
    [DataRow("longa", Model.Duration.Longa)]
    [DataRow("brevis", Model.Duration.Brevis)]
    [DataRow("semibrevis", Model.Duration.Semibrevis)]
    [DataRow("minima", Model.Duration.Minima)]
    [DataRow("semiminima", Model.Duration.Semiminima)]
    [DataRow(null, Model.Duration.Null)]
    [DataRow("foo", Duration.Invalid)]
    public void ConvertNoteTest_Duration(string meidur, Model.Duration dur)
    {
      if (meidur != null)
      {
        meinote.SetDur(meidur);
      }
      
      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(dur, convertedNote.Duration);
    }

    [TestMethod()]
    [DataRow(null, null, StemDesc.Null)]
    [DataRow("left", "up", StemDesc.LeftUp)]
    [DataRow("left", "down", StemDesc.LeftDown)]
    [DataRow("center", "up", StemDesc.CenterUp)]
    [DataRow("center", "down", StemDesc.CenterDown)]
    [DataRow("right", "up", StemDesc.RightUp)]
    [DataRow("right", "down", StemDesc.RightDown)]
    [DataRow("waaah", "blaaa", StemDesc.Null)]
    public void ConvertNoteTest_Stem(string pos, string dir, Model.StemDesc stem)
    {
      if (dir != null)
      {
        meinote.SetStemDir(dir);
      }
      if (pos != null)
      {
        meinote.SetStemPos(pos);
      }

      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(stem, convertedNote.Stem);
    }

    [TestMethod()]
    [DataRow(2, 3)]
    [DataRow(1, 3)]
    [DataRow(1, 4)]
    [DataRow(4, 9)]
    public void ConvertNoteTest_Ratio(int num, int numbase)
    {
      meinote.SetNum(num.ToString());
      meinote.SetNumbase(numbase.ToString());

      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(new Fraction(num, numbase), convertedNote.Ratio);
    }

    [TestMethod()]
    [DataRow("s", AccidType.Sharp)]
    [DataRow("f", AccidType.Flat)]
    [DataRow("n", AccidType.Neutral)]
    public void ConvertNote_AccidGes(string accid, Model.AccidType accidType)
    {
      meinote.SetAccidGes(accid);

      NoteConverter.ConvertNote(convertedNote, meinote);

      Assert.AreEqual(accidType, convertedNote.AccidGes);
    }

    [TestCleanup()]
    public void CleanUp()
    {
      meinote = null;
      convertedNote = null;
    }
  }
}