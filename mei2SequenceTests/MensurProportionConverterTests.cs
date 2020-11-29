using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei2Sequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;
using Mehroz;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class MensurProportionConverterTests
  {
    mei.Proport test_meiprop;
    Model.Proportion prop_obj;

    mei.Mensur test_meimensur;
    Model.Mensur mensur_obj;

    [TestInitialize]
    public void Init()
    {
      test_meiprop = new Proport();
      prop_obj = new Proportion();

      test_meimensur = new mei.Mensur();
      mensur_obj = new Model.Mensur();
    }

    [TestCleanup]
    public void Cleanup()
    {
      test_meiprop = null;
      prop_obj = null;

      test_meimensur = null;
      mensur_obj = null;
    }

    [TestMethod()]
    [DataRow("#Mensur_Ccut", Model.Sign.Mensur_Ccut)]
    [DataRow("#Mensur_C", Model.Sign.Mensur_C)]
    [DataRow("#Mensur_Cdot", Model.Sign.Mensur_Cdot)]
    [DataRow("#Mensur_Circle", Model.Sign.Mensur_Circle)]
    [DataRow("#Mensur_CircleDot", Model.Sign.Mensur_CircleDot)]
    [DataRow("#Mensur_CircleCut", Model.Sign.Mensur_CircleCut)]
    [DataRow("#Mensur_CircleDotCut", Model.Sign.Mensur_CircleDotCut)]
    [DataRow("#Mensur_Cinverted", Model.Sign.Mensur_Cinverted)]
    [DataRow("#Mensur_CinvertedCut", Model.Sign.Mensur_CinvertedCut)]
    [DataRow("waaaaaah", Model.Sign.Invalid)]
    [DataRow(null, Model.Sign.None)]
    public void ConvertMensurTest_Sign(string altsym, Sign sign)
    {
      if (altsym != null)
      {
        test_meimensur.SetAltsym(altsym);
      }

      test_meimensur.SetTempus("2");
      test_meimensur.SetProlatio("2");

      MensurProportionConverter.ConvertMensur(mensur_obj, test_meimensur);

      Assert.AreEqual(sign, mensur_obj.Sign);
    }

    [TestMethod()]
    [DataRow(2, 2, 2, 2)]
    [DataRow(2, 3, 2, 2)]
    [DataRow(2, 2, 3, 2)]
    [DataRow(2, 2, 2, 3)]
    public void ConvertMensurTest_logicStandard(int maximodus, int modus, int tempus, int prolatio)
    {
      test_meimensur.SetModusmaior(maximodus.ToString());
      test_meimensur.SetModusminor(modus.ToString());
      test_meimensur.SetTempus(tempus.ToString());
      test_meimensur.SetProlatio(prolatio.ToString());

      MensurProportionConverter.ConvertMensur(mensur_obj, test_meimensur);

      Assert.AreEqual(maximodus, mensur_obj.Maximodus);
      Assert.AreEqual(modus, mensur_obj.Modus);
      Assert.AreEqual(tempus, mensur_obj.Tempus);
      Assert.AreEqual(prolatio, mensur_obj.Prolatio);
    }

    [TestMethod()]
    [DataRow(2, 2, 2, 2)]
    [DataRow(0, 0, 2, 2)]
    public void ConvertMensurTest_logicSpecial(int maximodus, int modus, int tempus, int prolatio)
    {
      if (maximodus != 0)
      {
        test_meimensur.SetModusmaior(maximodus.ToString());
      }
      if (modus != 0)
      {
        test_meimensur.SetModusminor(modus.ToString());
      }
      test_meimensur.SetTempus(tempus.ToString());
      test_meimensur.SetProlatio(prolatio.ToString());

      MensurProportionConverter.ConvertMensur(mensur_obj, test_meimensur);

      Assert.AreEqual(2, mensur_obj.Maximodus);
      Assert.AreEqual(2, mensur_obj.Modus);
      Assert.AreEqual(2, mensur_obj.Tempus);
      Assert.AreEqual(2, mensur_obj.Prolatio);
    }

    [TestMethod()]
    [ExpectedException(typeof(InvalidOperationException))]
    [DataRow("4", "5", "6", "7")]
    [DataRow("bla", "bla", "bla", "bla")]
    [DataRow(null, null, "bla", "bla")]
    public void ConvertMensurTest_logicParseError(string maximodus, string modus, string tempus, string prolatio)
    {
      if (maximodus != null)
      {
        test_meimensur.SetModusmaior(maximodus.ToString());
      }
      if (modus != null)
      {
        test_meimensur.SetModusminor(modus.ToString());
      }
      test_meimensur.SetTempus(tempus.ToString());
      test_meimensur.SetProlatio(prolatio.ToString());

      MensurProportionConverter.ConvertMensur(mensur_obj, test_meimensur);
    }

    [TestMethod()]
    [ExpectedException(typeof(NullReferenceException))]
    public void ConvertMensurTest_logicEmptyError()
    {
      test_meimensur.SetModusmaior(2.ToString());
      test_meimensur.SetModusminor(3.ToString());

      MensurProportionConverter.ConvertMensur(mensur_obj, test_meimensur);
    }

    [TestMethod()]
    [DataRow("#Proportion_3CircleAbove", Model.Sign.Proportion_3CircleAbove)]
    [DataRow("#Proportion_3", Model.Sign.Proportion_3)]
    [DataRow("waaaaaah", Model.Sign.Invalid)]
    [DataRow(null, Model.Sign.None)]
    public void ConvertProportionTest_Sign(string altsym, Sign sign)
    {
      if (altsym != null)
      {
        test_meiprop.SetAltsym(altsym);
      }

      test_meiprop.SetNum("1");
      test_meiprop.SetNumbase("1");

      MensurProportionConverter.ConvertProportion(prop_obj, test_meiprop);

      Assert.AreEqual(sign, prop_obj.Sign);
    }

    [TestMethod()]
    [DataRow("brevis", Duration.Brevis)]
    [DataRow("semibrevis", Duration.Semibrevis)]
    [DataRow("mimima", Duration.Invalid)]
    [DataRow(null, Duration.Null)]
    public void ConvertProportionTest_Affected(string affected, Duration dur)
    {
      if (affected != null)
      {
        test_meiprop.SetAffected(affected);
      }

      test_meiprop.SetNum("1");
      test_meiprop.SetNumbase("1");

      MensurProportionConverter.ConvertProportion(prop_obj, test_meiprop);

      Assert.AreEqual(dur, prop_obj.Affected);
    }

    [TestMethod()]
    [DataRow(2, 3)]
    [DataRow(1, 3)]
    [DataRow(1, 4)]
    [DataRow(4, 9)]
    public void ConvertProportionTest_ratio(int num, int numbase)
    {
      test_meiprop.SetNum(num.ToString());
      test_meiprop.SetNumbase(numbase.ToString());

      MensurProportionConverter.ConvertProportion(prop_obj, test_meiprop);

      Assert.AreEqual(new Fraction(num, numbase), prop_obj.Ratio);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void ConvertProportionTest_ratio_ConvertError()
    {
      test_meiprop.SetNum("bla");
      test_meiprop.SetNumbase("blubb");

      MensurProportionConverter.ConvertProportion(prop_obj, test_meiprop);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void ConvertProportionTest_RatioError()
    {
      test_meiprop.SetNum("3");

      MensurProportionConverter.ConvertProportion(prop_obj, test_meiprop);
    }
  }
}