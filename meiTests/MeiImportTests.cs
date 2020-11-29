using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace mei.Tests
{
  [TestClass()]
  public class MeiImportTests
  {
    [TestMethod()]
    public void ImportDocumentTest1()
    {
      MeiDocument testDoc = MeiImport.ImportDocument("..\\..\\files\\MeiImportTest1.xml");

      Assert.IsNotNull(testDoc);
    }

    [TestMethod()]
    public void ImportDocumentTest2()
    {
      MeiDocument testDoc = MeiImport.ImportDocument("..\\..\\files\\MeiImportTest2.xml");

      Assert.IsNotNull(testDoc.SchemaLocation);
      Assert.IsNotNull(from node in testDoc.Nodes().OfType<XProcessingInstruction>() select node.Target != "xml-model");
    }

    [TestMethod()]
    public void ImportDocumentTest3()
    {
      MeiDocument testDoc = MeiImport.ImportDocument("..\\..\\files\\MeiImportTest3.xml");

      IEnumerable<XProcessingInstruction> models = from node in testDoc.Nodes().OfType<XProcessingInstruction>().Where(node => node.Target == "xml-model") select node;

      List<string> href_compare = new List<string>();

      Match hrefs;

      foreach (XProcessingInstruction model in models)
      {
        //Get schemaLocation from pImodel.Data
        //See example here: https://msdn.microsoft.com/de-de/library/t9e807fx(v=vs.110).aspx

        string HRefPattern = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";

        try
        {
          hrefs = Regex.Match(model.Data, HRefPattern,
                      RegexOptions.IgnoreCase | RegexOptions.Compiled,
                      TimeSpan.FromSeconds(1));
          while (hrefs.Success)
          {
            href_compare.Add(hrefs.Groups[1].ToString());
            hrefs = hrefs.NextMatch();
          }
        }

        catch (RegexMatchTimeoutException)
        {
          break;
        }

      }

      Assert.AreEqual(testDoc.SchemaLocation, string.Empty);
      CollectionAssert.AllItemsAreUnique(href_compare);
    }

    [TestMethod()]
    public void ImportExportCompare()
    {
      XDocument xDoc = XDocument.Load("..\\..\\files\\MeiImportTest2.xml");
      MeiDocument meiDoc = MeiImport.ImportDocument("..\\..\\files\\MeiImportTest2.xml");

      string xString = xDoc.ToString();
      string meiString = meiDoc.ToString();

      Equals(xString, meiString);
    }

    [TestMethod()]
    public void XmlToMeiTest()
    {
      XElement testelement = new XElement("ligature", new XElement("note","bla"));

      MeiElement compare = new Ligature();

      MeiElement test = MeiImport.XmlToMei(testelement);
      
      Assert.IsInstanceOfType(test, compare.GetType());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidCastException))]
    public void InvalidRootTest()
    {
      XElement testelement = new XElement("blubb", new XElement("note"));

      MeiElement conversion_test = MeiImport.XmlToMei(testelement);
    }

    [TestMethod()]
    public void TestIDHandling()
    {
      XElement testelement = new XElement("ligature", new XElement("note", new XAttribute("label","test")), new XAttribute(XNamespace.Xml + "id", "t-123"));

      MeiElement test = MeiImport.XmlToMei(testelement);

      Assert.AreEqual(test.GetId(), "t-123");
      Assert.IsNotNull(test.Element<Note>().GetId());
    }
  }
}