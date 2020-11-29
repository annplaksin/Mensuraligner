using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace mei.Tests
{
  [TestClass()]
  public class MeiDocumentTests
  {
    [TestMethod()]
    public void SetSchemaLocationTest()
    {
      string schemaLoc = "bla";
      MeiDocument testDoc = new MeiDocument(new Mei(new XAttribute("label","foo")));

      testDoc.SetSchemaLocation(schemaLoc);

      Assert.AreEqual(schemaLoc, testDoc.SchemaLocation);
    }

    [TestMethod()]
    public void MeiDocumentTest()
    {
      Mei blubb = new Mei();
      MeiDocument testDoc = new MeiDocument(blubb);

      Assert.IsNotNull(testDoc);
    }

    [TestMethod()]
    public void SaveDocumentTest()
    {
      if(File.Exists("test.xml"))
      {
        File.Delete("test.xml");
      }

      MeiDocument testDoc = new MeiDocument(new Mei(new XAttribute("label", "foo")));
      testDoc.SetSchemaLocation("foobarfoobarfoo");

      testDoc.Save("test.xml");

      bool check = File.Exists("test.xml");

      Assert.IsTrue(check);
    }
  }
}