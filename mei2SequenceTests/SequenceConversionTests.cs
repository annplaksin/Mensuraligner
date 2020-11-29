using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei2Sequence;
using mei2Sequence.Model;
using mei;
using Mehroz;

namespace mei2Sequence.Tests
{
  [TestClass()]
  public class SequenceConversionTests
  {
    [TestMethod()]
    public void ConvertBrevePosition()
    {
      Sequence metricSequence = SequenceHandler.CreateNewSequence("kind of test", "Breve position", "noPage", "Tenor", 3);
      Panel metricPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\MetricSequence.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(metricPanel, metricSequence);
      Controller.BuildSequence(metricSequence);

      SequenceConversion.ConvertBrevePosition(metricSequence);

      foreach (ObjectInSequence obj in metricSequence.ObjectsInSequence)
      {
        IAttCommon corresp = (IAttCommon)metricPanel.Descendants().FirstOrDefault(element => element.GetId() == obj.ID);
        
        if(corresp.HasN())
        {
          Fraction exp = new Fraction(corresp.GetNValue());

          if (obj is Model.Rest rest)
          {
            //Check if expected value is not null and then compare
            Assert.IsNotNull(exp);
            Assert.AreEqual(exp, rest.BrevePosition);
          }
        }
      }

      metricPanel = null;
      metricSequence = null;
    }

    [TestMethod()]
    public void ConvertBrevePositionGap()
    {
      Sequence metricSequence = SequenceHandler.CreateNewSequence("kind of test", "Breve position with gaps", "noPage", "Tenor", 3);
      Panel metricPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\MetricSequenceDamage.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(metricPanel, metricSequence);
      Controller.BuildSequence(metricSequence);

      SequenceConversion.ConvertBrevePosition(metricSequence);

      foreach (ObjectInSequence obj in metricSequence.ObjectsInSequence)
      {
        if (obj is Model.Rest rest)
        {
          IAttCommon corresp = (IAttCommon)metricPanel.Descendants().FirstOrDefault(element => element.GetId() == obj.ID);

          Fraction expBP = 0;
          Fraction expPaG = 0;

          if (corresp.HasN())
          {
            expBP = new Fraction(corresp.GetNValue());
          }
          else if (corresp.HasLabel())
          {
            expPaG = new Fraction(corresp.GetLabelValue());
          }

          //Check if expected value is not null and then compare
          if (expBP != 0)
          {
            Assert.AreEqual(expBP, rest.BrevePosition);
          }
          else if (expPaG != 0)
          {
            Assert.AreEqual(expPaG, rest.AfterGapPosition);
          }
          else
          {
            Assert.Fail();
          }
        }
      }

      metricPanel = null;
      metricSequence = null;
    }

    [TestMethod()]
    public void ConvertBrevePositionChord()
    {
      Sequence metricSequence = SequenceHandler.CreateNewSequence("kind of test", "Breve position Chord", "noPage", "Tenor", 3);
      Panel metricPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\MetricSequenceChord.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(metricPanel, metricSequence);
      Controller.BuildSequence(metricSequence);

      SequenceConversion.ConvertBrevePosition(metricSequence);

      foreach (ObjectInSequence obj in metricSequence.ObjectsInSequence)
      {
        IAttCommon corresp = (IAttCommon)metricPanel.Descendants().FirstOrDefault(element => element.GetId() == obj.ID);

        if (corresp.HasN())
        {
          Fraction exp = new Fraction(corresp.GetNValue());

          if (obj is Model.Rest rest)
          {
            //Check if expected value is not null and then compare
            Assert.IsNotNull(exp);
            Assert.AreEqual(exp, rest.BrevePosition);
          }
        }
      }

      metricPanel = null;
      metricSequence = null;
    }

    [TestMethod()]
    public void ConvertGapTest()
    {
      Sequence gapSequence = SequenceHandler.CreateNewSequence("Test", "Gap", "noPage", "Tenor", 3);
      Panel gapPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\DamageTest.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(gapPanel, gapSequence);
      Controller.BuildSequence(gapSequence);

      Assert.IsInstanceOfType(gapSequence.ObjectsInSequence[4], typeof(Model.Gap));
      Model.Gap gap1 = (Model.Gap)gapSequence.ObjectsInSequence[4];
      Assert.AreEqual(gap1.GapType, GapType.Damage);

      Assert.IsInstanceOfType(gapSequence.ObjectsInSequence[6], typeof(Model.Gap));
      Model.Gap gap2 = (Model.Gap)gapSequence.ObjectsInSequence[6];
      Assert.AreEqual(gap2.GapType, GapType.Damage);

      Assert.IsInstanceOfType(gapSequence.ObjectsInSequence[7], typeof(Model.Gap));
      Model.Gap gap3 = (Model.Gap)gapSequence.ObjectsInSequence[7];
      Assert.AreEqual(gap3.GapType, GapType.Damage);

      Assert.IsInstanceOfType(gapSequence.ObjectsInSequence[20], typeof(Model.Gap));
      Model.Gap gap4 = (Model.Gap)gapSequence.ObjectsInSequence[20];
      Assert.AreEqual(gap4.GapType, GapType.Gap);
    }

    [TestMethod()]
    public void ConvertLigatureTest()
    {
      Sequence ligSequence = SequenceHandler.CreateNewSequence("Test", "Ligature", "noPage", "Tenor", 3);
      Panel ligPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\LigatureTest.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(ligPanel, ligSequence);
      Controller.BuildSequence(ligSequence);

      foreach (Model.Note note in ligSequence.ObjectsInSequence.Where(item => item is Model.Note))
      {
        Assert.IsNotNull(note.LigaturePosition);
        Assert.IsNotNull(note.LigatureForm);

        if (note.LigaturePosition == 1)
        {
          Assert.AreEqual(StemDesc.LeftUp, note.Stem);
        }

        if (note.Position == 3 || note.Position == 4 || note.Position == 10 || note.Position == 11)
        {
          Assert.AreEqual(LigatureForm.Obliqua, note.LigatureForm);
        }
        else
        {
          Assert.AreEqual(LigatureForm.Recta, note.LigatureForm);
        }
      }
    }

    [TestMethod()]
    public void ConvertAbsolutePitchTest()
    {
      Sequence aPitchSeq = SequenceHandler.CreateNewSequence("Test", "Absolute Pitch", "noPage", "AbsolutePitch", 1);
      Panel aPitchPanel = MeiImport.ImportDocument("..\\..\\files\\tests\\AbsolutePitch.xml").Root.Descendants<Panel>().FirstOrDefault();

      SequenceHandler.FlattenMeiToSequence(aPitchPanel, aPitchSeq);
      Controller.BuildSequence(aPitchSeq);
      SequenceConversion.ConvertAbsolutePitch(aPitchSeq);

      foreach (Model.Note note in aPitchSeq.ObjectsInSequence.Where(item => item is Model.Note))
      {
        Assert.IsNotNull(note.WrittenPitch);

        mei.Note corresp = (mei.Note)aPitchPanel.Descendants().FirstOrDefault(element => element.GetId() == note.ID);

        if (corresp.HasPnum())
        {
          if (Int32.TryParse(corresp.GetPnumValue(), out int pnum))
          {
            Assert.AreEqual(pnum, note.PitchWithAccid);
          }
          else
          {
            throw new ArgumentNullException("Pnum could not be parsed!");
          }
        }
      }
    }
  }
}
