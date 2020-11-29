using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei2Sequence.Model;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// Static class for writing <see cref="ObjectInSequence"/> in an <see cref="System.Windows.Forms.DataGridView"/>
  /// </summary>
  public static class ObjectWriter
  {
    internal static readonly string[] HEADERS = { "Position", "ObjectType", "Evidence", "Classification", "PitchPosition", "VisualFeatures", "BrevePosition", "InflectedPitch" };

    internal static string[] GetStringData(ObjectInSequence _obj)
    {
      object[] objData = WriteToDataRow(_obj);
      string[] strArrReturn = new string[objData.Length];
      for (int intIndex = 0; intIndex < objData.Length; intIndex++)
      {
        strArrReturn[intIndex] = objData[intIndex]?.ToString();
      }

      return strArrReturn;
    }

    internal static object[] WriteToDataRow (ObjectInSequence _obj)
    {
      //Get Evidence value
      decimal evidence = ConvertEvidence(_obj.Evidence);
      //Get Classification
      string classification = GetClassification(_obj);
      //Get Pitch Position
      int? pitchPos = GetPitchPosition(_obj);
      //Get Visual Features
      string visual = GetVisualFeatures(_obj);
      //Get Breve Position
      string strBrevePos = GetBrevePos(_obj);
      //Get inflected Pitch
      int? infPitch = GetInflectedPitch(_obj);
      
      //Position  ObjectType  Evidence  Classification  PitchPosition  VisualFeatures   BrevePosition   InflectedPitch
      object[] sequenceObj = { _obj.Position, _obj.Type, evidence, classification, pitchPos, visual, strBrevePos, infPitch};

      return sequenceObj;
    }

    private static decimal ConvertEvidence(Evidence evd)
    {
      switch (evd)
      {
        case Evidence.Clear:
          return 1;
        case Evidence.Invalid:
          return 0;
        case Evidence.Reg:
          return 0;
        case Evidence.Supplied:
          return 0;
        case Evidence.Unclear_high:
          return 0.8M;
        case Evidence.Unclear_low:
          return 0.3M;
        case Evidence.Unclear_medium:
          return 0.5M;
        case Evidence.Unclear_unknown:
          return 0.2M;
        default:
          throw new InvalidOperationException("Fatal error on reading evidence state!");
      }
    }

    /// <summary>
    /// Returns the classification of an ObjectInSequence
    /// </summary>
    /// <param name="_obj">ObjectInSequence</param>
    /// <returns>Classification value</returns>
    public static string GetClassification(ObjectInSequence _obj)
    {
      if (_obj is Rest rest)
      {
        if (rest is Note note && note.Coloration == true)
        {
          return "colored" + rest.Duration.ToString();
        }
        else
        {
          return rest.Duration.ToString();
        }
      }
      else if (_obj is Clef clef)
      {
        return clef.Shape.ToString() + "-" + clef.Line.ToString();
      }
      else if (_obj is KeyAccidental accid)
      {
        return accid.AccidentalType.ToString();
      }
      else
      {
        return string.Empty;
      }
    }

    /// <summary>
    /// Returns Pitch Position for an ObjectInSequence
    /// </summary>
    /// <param name="_obj">ObjectInSequence</param>
    /// <returns>Pitch Position value</returns>
    public static int? GetPitchPosition(ObjectInSequence _obj)
    {
      if (_obj is mei2Sequence.Model.Note note)
      {
        return note.WrittenPitch;
      }
      else if (_obj is KeyAccidental accid)
      {
        return accid.PitchLocation;
      }
      else if (_obj is Custos custos)
      {
        return custos.PitchLocation;
      }
      else
      {
        return null;
      }
    }

    /// <summary>
    /// Returns a list of visual features of an ObjectInSequence
    /// </summary>
    /// <param name="_obj">ObjectInSequence</param>
    /// <returns>Visual features column</returns>
    private static string GetVisualFeatures(ObjectInSequence _obj)
    {
      string visual = string.Empty;

      if (_obj is Barline bar)
      {
        visual = bar.BarlineType.ToString();
      }
      else if (_obj is Proportion prop)
      {
        visual = prop.Sign.ToString();
      }
      else if (_obj is Accidental accid)
      {
        visual = accid.AccidentalPosition != Position.Null ? accid.AccidentalPosition.ToString() : string.Empty;
      }
      else if (_obj is Note note)
      {
        string[] noteVisuals = new string[4];

        if (note.Fermata == true)
        {
          noteVisuals[0] = "Fermata";
        }
        if (note.LigatureForm != LigatureForm.Null)
        {
          noteVisuals[1] = note.LigatureForm.ToString();
        }
        if (note.LigaturePosition > 0)
        {
          noteVisuals[2] = note.LigaturePosition.ToString();
        }
        if (note.Stem != StemDesc.Null)
        {
          noteVisuals[3] = note.Stem.ToString();
        }

        foreach (string feature in noteVisuals.Where(item => item != null))
        {
          if (visual != string.Empty)
          {
            visual = visual + "; ";
          }

          visual = visual + feature;
        }
      }

      return visual;
    }

    /// <summary>
    /// Returns Breve Position of an ObjectInSequence if it is a Rest obejct or null.
    /// </summary>
    /// <param name="_obj">Object in Sequence</param>
    /// <returns>Value for Breve Position column</returns>
    private static string GetBrevePos(ObjectInSequence _obj)
    {
      if (_obj is mei2Sequence.Model.Rest rst)
      {
        if (rst.AfterGapPosition.IsNaN() == false)
        {
          return "+" + Math.Round(rst.AfterGapPosition.ToDouble(), 2).ToString("0.00");
        }
        else if (rst.BrevePosition.IsNaN() == false)
        {
          return Math.Round(rst.BrevePosition.ToDouble(), 2).ToString("0.00");
        }
        else
        {
          return null;
        }
      }
      else
      {
        return null;
      }
    }

    /// <summary>
    /// Returns Inlfected Pitch on an ObjectInSequence if it is a Note or null.
    /// </summary>
    /// <param name="_obj">Object in Sequence</param>
    /// <returns>Value for inflected pitch column</returns>
    private static int? GetInflectedPitch(ObjectInSequence _obj)
    {
      if (_obj is mei2Sequence.Model.Note note)
      {
        return note.PitchWithAccid;
      }
      else
      {
        return null;
      }
    }
  }
}
