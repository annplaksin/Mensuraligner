using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei2Sequence;
using mei2Sequence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class SequenceHandlerTests
  {
    [TestMethod()]
    [DataRow("kind of mass", "Kyrie", "154v", "Tenor", 3)]
    public void CreateNewSequenceTest(string piece, string part, string page, string voice, int nr)
    {
      Sequence test = SequenceHandler.CreateNewSequence(piece, part, page, voice, nr);

      Assert.IsNotNull(test);
      Assert.AreEqual(piece, test.Piece);
      Assert.AreEqual(part, test.PartOfPiece);
      Assert.AreEqual(page, test.Page);
      Assert.AreEqual(voice, test.Voice);
      Assert.AreEqual(nr, test.VoiceNr);
    }

    [TestMethod()]
    public void GetMetadataTest()
    {
      mei.Panel testPanel = mei.MeiImport.ImportDocument("..\\..\\files\\VatS-13a-TuSolus.xml").Root.Descendants<mei.Panel>().FirstOrDefault();

      SequenceHandler.GetMetadata(testPanel, out string part, out string page, out string voice, out int nr);

      Assert.IsNotNull(part);
      Assert.IsNotNull(page);
      Assert.IsNotNull(voice);
      Assert.IsNotNull(nr);
    }

    [TestMethod()]
    public void FlattenMeiToSequenceTest()
    {
      mei.Panel testPanel = mei.MeiImport.ImportDocument("..\\..\\files\\VatS-13a-TuSolus.xml").Root.Descendants<mei.Panel>().FirstOrDefault();

      int counter = 0;

      foreach (Layer layer in testPanel.Descendants<Layer>())
      {
        foreach (MeiElement element in layer.Elements())
        {
          counter++;
        }
      }

      Sequence test = SequenceHandler.CreateNewSequence("kind of mass", "Kyrie", "noPage","Tenor", 3);

      SequenceHandler.FlattenMeiToSequence(testPanel, test);

      Assert.AreEqual(counter, test.MeiObjects.Count());
    }

    [TestMethod()]
    public void MultipleStateTest()
    {
      List<Sequence> testList = Controller.GetSequences("..\\..\\files\\FlorBN-Panc27.xml");

      Assert.AreEqual(5, testList.Count);

      Sequence stateBefore = testList.Find(seq => seq.State == State.Before);
      Sequence stateAfter = testList.Find(seq => seq.State == State.After);

      Assert.AreNotEqual(stateBefore.MeiObjects, stateAfter.MeiObjects);
    }
  }
}