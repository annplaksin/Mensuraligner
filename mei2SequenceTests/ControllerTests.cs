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
  public class ControllerTests
  {
    //private Sequence testSequence;
    //private Panel testPanel;
    private List<Sequence> testList;
    private IEnumerable<Panel> testPanels;

    [TestInitialize()]
    public void Init()
    {
      //this.testSequence = SequenceHandler.CreateNewSequence("kind of mass", "Kyrie", "Tenor", 3);
      //this.testPanel = MeiImport.ImportDocument("..\\..\\files\\Capp.Sist.41-13a-TuSous_clean.xml").Root.Descendants<Panel>().FirstOrDefault(panel => panel.GetNValue() == "2");

      //SequenceHandler.FlattenMeiToSequence(this.testPanel, this.testSequence);
      //Controller.BuildSequence(this.testSequence);

      testPanels = MeiImport.ImportDocument("..\\..\\files\\VatS-13a-TuSolus.xml").Root.Descendants<Panel>();

      this.testList = Controller.GetSequences("..\\..\\files\\VatS-13a-TuSolus.xml");
      foreach (Sequence sequence in testList)
      {
        Controller.BuildSequence(sequence);
      }
    }

    [TestCleanup()]
    public void CleanUp()
    {
      //this.testPanel = null;
      //this.testSequence = null;

      this.testList = null;
      this.testPanels = null;
    }

    [TestMethod()]
    public void BuildSequence_objHasParentSequence()
    {
      foreach (Sequence testsequence in testList)
      {
        foreach (ObjectInSequence obj in testsequence.ObjectsInSequence)
        {
          Assert.AreSame(testsequence, obj.ParentSequence);
        }
      }
      
    }

    [TestMethod()]
    public void BuildSequence_checkConversion()
    {
      foreach (Sequence testSequence in testList)
      {
        foreach (ObjectInSequence obj in testSequence.ObjectsInSequence)
        {

          Assert.AreNotEqual(obj.Evidence, Evidence.Invalid);

          switch (obj.Type)
          {
            case ObjectType.Accidental:
              Accidental accid = (Accidental)obj;
              Assert.AreNotEqual(Model.AccidType.Null, accid.AccidentalType);
              break;
            case ObjectType.Barline:
              Barline bl = (Barline)obj;
              Assert.AreNotEqual(Model.BarlineType.Null, bl.BarlineType);
              break;
            case ObjectType.Clef:
              Model.Clef clef = (Model.Clef)obj;
              Assert.AreNotEqual(Model.Clefshape.Null, clef.Shape);
              break;
            case ObjectType.KeyAccidental:
              KeyAccidental keyacc = (KeyAccidental)obj;
              Assert.AreNotEqual(Model.AccidType.Null, keyacc.AccidentalType);
              break;
            case ObjectType.Mensur:
              Model.Mensur mens = (Model.Mensur)obj;
              Assert.AreNotEqual(0, mens.Tempus);
              break;
            case ObjectType.Note:
              Model.Note note = (Model.Note)obj;
              Assert.AreNotEqual(0, note.WrittenPitch);
              Assert.AreNotEqual(Model.Duration.Null, note.Duration);
              break;
            case ObjectType.Proportion:
              Proportion prop = (Proportion)obj;
              Assert.AreNotEqual(0, prop.Num);
              Assert.AreNotEqual(0, prop.Numbase);
              break;
            case ObjectType.Rest:
              Model.Rest rest = (Model.Rest)obj;
              Assert.AreNotEqual(Model.Duration.Null, rest.Duration);
              break;
            case ObjectType.Custos:
              break;
            case ObjectType.Dot:
              break;
            case ObjectType.Gap:
              Model.Gap gap = (Model.Gap)obj;
              Assert.AreNotEqual(Model.GapType.Null, gap.GapType);
              break;
            default:
              Assert.Fail($"Test of {obj.Type} {obj.ID} failed!");
              break;
          }
        }
      }
    }

    [TestMethod()]
    public void BuildSequence_countNotes()
    {
      foreach (Sequence testSequence in testList)
      {
        Panel testPanel = testPanels.First(p => p.GetNValue() == testSequence.VoiceNr.ToString());
          
        int countNotes = testPanel.Descendants<mei.Note>().Count();

        Assert.AreEqual(countNotes, testSequence.ObjectsInSequence.Where(o => o.Type == ObjectType.Note).Count());
      }
    }

    [TestMethod()]
    public void BuildSequence_countRests()
    {
      foreach (Sequence testSequence in testList)
      {
        Panel testPanel = testPanels.First(p => p.GetNValue() == testSequence.VoiceNr.ToString());

        int countRests = testPanel.Descendants<mei.Rest>().Count();

        Assert.AreEqual(countRests, testSequence.ObjectsInSequence.Where(o => o.Type == ObjectType.Rest).Count());
      }
    }

    [TestMethod()]
    public void BuildSequence_hasID()
    {
      foreach (Sequence testSequence in testList)
      {
        CollectionAssert.AllItemsAreInstancesOfType(testSequence.ObjectsInSequence, typeof(ObjectInSequence));

        foreach (ObjectInSequence sequenceItem in testSequence.ObjectsInSequence)
        {
          Assert.IsNotNull(sequenceItem.ID);
        }
      }
    }

    [TestMethod()]
    public void BuildSequence_isIDidentical()
    {
      foreach (Sequence testSequence in testList)
      {
        List<MeiElement> testList = new List<MeiElement>();

        foreach (MeiElement meiElement in testSequence.MeiObjects.Values)
        {
          if (meiElement is KeySig)
          {
            foreach (KeyAccid keyacc in meiElement.Elements<KeyAccid>())
            {
              testList.Add(keyacc);
            }
          }
          else if (meiElement is Chord)
          {
            foreach (MeiElement chordDesc in meiElement.Descendants())
            {
              if (chordDesc.Name.LocalName == "note" || chordDesc.Name.LocalName == "rest")
              {
                testList.Add(chordDesc);
              }
            }
          }
          else if (meiElement is Ligature)
          {
            foreach (MeiElement ligchild in meiElement.Elements())
            {
              testList.Add(ligchild);
            }
          }
          else if (meiElement is Unclear)
          {
            foreach (MeiElement unclearChild in meiElement.Elements())
            {
              testList.Add(unclearChild);
            }
          }
          else
          {
            testList.Add(meiElement);
          }
        }

        for (int i = 0; i < testList.Count(); i++)
        {
          Assert.AreEqual(testList[i].GetId(), testSequence.ObjectsInSequence[i].ID);
        }
      }
    }

    [TestMethod()]
    public void BuildSequence_TestPosition()
    {
      foreach (Sequence testSequence in testList)
      {
        List<MeiElement> testList = new List<MeiElement>();

        int countPos = 0;

        foreach (MeiElement meiElement in testSequence.MeiObjects.Values)
        {
          if (meiElement is KeySig)
          {
            foreach (KeyAccid keyacc in meiElement.Elements<KeyAccid>())
            {
              keyacc.SetAttributeValue("n", countPos);
              testList.Add(keyacc);
            }
            countPos++;
          }
          else if (meiElement is Chord)
          {
            foreach (MeiElement chordDesc in meiElement.Descendants())
            {
              if (chordDesc.Name.LocalName == "note" || chordDesc.Name.LocalName == "rest")
              {
                chordDesc.SetAttributeValue("n", countPos);
                testList.Add(chordDesc);
              }
            }
            countPos++;
          }
          else if (meiElement is Ligature)
          {
            foreach (MeiElement ligchild in meiElement.Elements())
            {
              ligchild.SetAttributeValue("n", countPos);
              testList.Add(ligchild);
              countPos++;
            }
          }
          else if (meiElement is Unclear)
          {
            foreach (MeiElement unclearChild in meiElement.Elements())
            {
              unclearChild.SetAttributeValue("n", countPos);
              testList.Add(unclearChild);
              countPos++;
            }
          }
          else
          {
            meiElement.SetAttributeValue("n", countPos);
            testList.Add(meiElement);
            countPos++;
          }

        }

        foreach (MeiElement compare in testList)
        {
          ObjectInSequence comparison = testSequence.ObjectsInSequence.FirstOrDefault(obj => obj.ID == compare.GetId());
          if (Int32.TryParse(compare.Attribute("n").Value, out int position) == true)
          {
            Assert.AreEqual(position, comparison.Position);
          }
        }
      }
    }

    [TestMethod()]
    public void BuildSequence_EvidenceTest()
    {
      foreach (Sequence testSequence in testList)
      {
        List<string> unclearObjectIDs = new List<string>();

        foreach (MeiElement element in testSequence.MeiObjects.Values)
        {
          if (element is Unclear)
          {
            foreach (MeiElement child in element.Elements())
            {
              unclearObjectIDs.Add(child.GetId());
            }
          }
        }

        foreach (ObjectInSequence obj in testSequence.ObjectsInSequence)
        {
          if (unclearObjectIDs.Contains(obj.ID))
          {
            Assert.AreNotEqual(Evidence.Clear, obj.Evidence);
          }
        }
      }
    }

    [TestMethod()]
    public void GetSequencesTest()
    {
      int countSequences = this.testList.Count();

      MeiElement root = MeiImport.ImportDocument("..\\..\\files\\VatS-13a-TuSolus.xml").Root;
      int countPanel = root.Descendants<Panel>().Count();

      Assert.AreEqual(countPanel,countSequences);
    }
  }
}