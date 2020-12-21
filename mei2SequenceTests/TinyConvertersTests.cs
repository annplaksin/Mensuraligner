using mei2Sequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;


namespace mei2Sequence.Tests
{
  [TestClass()]
  public class TinyConvertersTests
  {
    Model.Clef clefobj;
    mei.Clef meiclef;

    Model.Barline barline;
    mei.BarLine meibarline;

    mei.Unclear unclear;

    mei.Custos meicustos;
    Model.Custos custos;

    [TestInitialize]
    public void Init()
    {
      clefobj = new Model.Clef();
      meiclef = new mei.Clef();

      barline = new Model.Barline();
      meibarline = new mei.BarLine();

      unclear = new mei.Unclear();

      meicustos = new mei.Custos();
      custos = new Model.Custos();
    }

    [TestCleanup]
    public void Cleanup()
    {
      clefobj = null;
      meiclef = null;

      barline = null;
      meibarline = null;

      unclear = null;

      meicustos = null;
      custos = null;
    }

    [TestMethod()]
    public void ConvertClefTest_Line()
    {
      meiclef.SetLine("4");
      meiclef.SetShape("F");

      TinyConverters.ConvertClef(clefobj, meiclef);

      Assert.AreEqual(4, clefobj.Line);
    }

    [TestMethod()]
    [ExpectedException(typeof(NullReferenceException))]
    public void ConvertClef_LineNull()
    {
      meiclef.SetShape("F");

      TinyConverters.ConvertClef(clefobj, meiclef);
    }

    [TestMethod()]
    public void ConvertClef_LineNullException()
    {
      TinyConverters.ConvertClef(clefobj, meiclef);

      Assert.AreEqual(0, clefobj.Line);
    }

    [TestMethod()]
    [ExpectedException(typeof(InvalidOperationException))]
    public void ConvertClef_LineInvalid()
    {
      meiclef.SetLine("bla");
      meiclef.SetShape("F");

      TinyConverters.ConvertClef(clefobj, meiclef);
    }

    [TestMethod()]
    [DataRow("C", Model.Clefshape.C)]
    [DataRow("F", Model.Clefshape.F)]
    [DataRow("G", Model.Clefshape.G)]
    [DataRow(null, Model.Clefshape.Null)]
    public void CovertClef_Shape(string meishape, Model.Clefshape shape)
    {
      if (meishape != null)
      {
        meiclef.SetShape(meishape);
      }

      meiclef.SetLine("4");

      TinyConverters.ConvertClef(clefobj, meiclef);

      Assert.AreEqual(shape, clefobj.Shape);
    }

    [TestMethod()]
    [ExpectedException(typeof(InvalidOperationException))]
    public void ConvertClef_InvalidShape()
    {
      meiclef.SetShape("bla");
      meiclef.SetLine("4");

      TinyConverters.ConvertClef(clefobj, meiclef);
    }

    [TestMethod()]
    [ExpectedException(typeof(NullReferenceException))]
    public void ConvertClef_ShapeNoLine()
    {
      meiclef.SetShape("bla");

      TinyConverters.ConvertClef(clefobj, meiclef);
    }

    [TestMethod()]
    [DataRow("dbl", Model.BarlineType.Double)]
    [DataRow("single", Model.BarlineType.Single)]
    [DataRow("rptboth", Model.BarlineType.Rptboth)]
    [DataRow("blaaaaa", Model.BarlineType.Invalid)]
    [DataRow(null, Model.BarlineType.Null)]
    public void ConvertBarlineTest(string meilinetype, Model.BarlineType linetype)
    {
      if (meilinetype != null)
      {
        meibarline.SetForm(meilinetype);
      }

      TinyConverters.ConvertBarline(barline, meibarline);

      Assert.AreEqual(linetype, barline.BarlineType);
    }

    [TestMethod()]
    [DataRow(null, Model.Evidence.Unclear_unknown)]
    [DataRow("blaaaaaaa", Model.Evidence.Invalid)]
    [DataRow("high", Model.Evidence.Unclear_high)]
    [DataRow("medium", Model.Evidence.Unclear_medium)]
    [DataRow("low", Model.Evidence.Unclear_low)]
    [DataRow("unknown", Model.Evidence.Unclear_unknown)]
    public void GetEvidenceTest(string meicert, Model.Evidence evd)
    {
      if (meicert != null)
      {
        unclear.SetCert(meicert);
      }

      Assert.AreEqual(evd, TinyConverters.GetEvidence(unclear));
    }

    [TestMethod()]
    [DataRow(true, Model.GapType.Damage, null)]
    [DataRow(true, Model.GapType.Damage, "waaaaaaaaah!")]
    [DataRow(false, Model.GapType.Gap, null)]
    [DataRow(false, Model.GapType.Gap, "hui!")]
    public void ConvertGapTest(bool _damage, Model.GapType _gapType, string _reason)
    {
      Model.Gap gap = new Model.Gap();

      if (_damage == true)
      {
        mei.Damage meidamage = new Damage();

        if (_reason != null)
        {
          meidamage.SetAgent(_reason);
        }

        TinyConverters.ConvertGap(gap, meidamage);
      }
      else
      {
        mei.Gap meigap = new mei.Gap();

        if (_reason != null)
        {
          meigap.SetReason(_reason);
        }

        TinyConverters.ConvertGap(gap, meigap);
      }

      Assert.AreEqual(_gapType, gap.GapType);
      Assert.AreEqual(_reason, gap.Reason);
    }

    [TestMethod()]
    [DataRow("g", "4", 185)]
    [DataRow("c", "4", 162)]
    [DataRow("c", "5", 202)]
    [DataRow("b", "4", 197)]
    public void ConvertCustosTest(string pitch, string oct, int base40)
    {
      meicustos.SetPname(pitch);
      meicustos.SetOct(oct);

      custos = TinyConverters.ConvertCustos(custos, meicustos);

      Assert.AreEqual(base40, custos.PitchLocation);
    }
  }
}