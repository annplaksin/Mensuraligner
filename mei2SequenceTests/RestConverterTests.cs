using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei2Sequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using Mehroz;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class RestConverterTests
  {
    mei.Rest meirest;
    Model.Rest convertedRest;

    [TestInitialize]
    public void Init()
    {
      meirest = new mei.Rest();
      convertedRest = new Model.Rest();
    }

    [TestMethod()]
    [DataRow("maxima", Model.Duration.Maxima)]
    [DataRow("longa", Model.Duration.Longa)]
    [DataRow("brevis", Model.Duration.Brevis)]
    [DataRow("semibrevis", Model.Duration.Semibrevis)]
    [DataRow("minima", Model.Duration.Minima)]
    [DataRow("semiminima", Model.Duration.Semiminima)]
    [DataRow(null, Model.Duration.Null)]
    [DataRow("foo", Model.Duration.Invalid)]
    public void ConvertRestTest_Duration(string meidur, Model.Duration dur)
    {
      if (meidur != null)
      {
        meirest.SetDur(meidur);
      }

      RestConverter.ConvertRest(convertedRest, meirest);

      Assert.AreEqual(dur, convertedRest.Duration);
    }

    [TestMethod()]
    [DataRow(2, 3)]
    [DataRow(1, 3)]
    [DataRow(1, 4)]
    [DataRow(4, 9)]
    public void ConvertRestTest_Ratio(int num, int numbase)
    {
      meirest.SetNum(num.ToString());
      meirest.SetNumbase(numbase.ToString());

      RestConverter.ConvertRest(convertedRest, meirest);

      Assert.AreEqual(new Fraction(num, numbase), convertedRest.Ratio);
    }

    [TestCleanup]
    public void Cleanup()
    {
      meirest = null;
      convertedRest = null;
    }
  }
}