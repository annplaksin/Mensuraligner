using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei2Sequence
{
  static class ConverterHelper
  {
    /// <summary>
    /// Returns for pitch name and oct a base-40 pitch
    /// </summary>
    /// <param name="_pitch">pitch name string</param>
    /// <param name="_oct">octave string</param>
    /// <returns>Base-40 int</returns>
    internal static int ConvertToBase40(string _pitch, string _oct)
    {
      //http://wiki.ccarh.org/wiki/Base_40
      //http://www.ccarh.org/publications/reprints/base40/

      int oct;

      if (Int32.TryParse(_oct, out int parseOct) == true)
      {
        oct = 40 * parseOct;
      }
      else
      {
        oct = 0;
      }

      int pitch;

      switch (_pitch)
      {
        case "c":
          pitch = 2;
          break;
        case "d":
          pitch = 8;
          break;
        case "e":
          pitch = 14;
          break;
        case "f":
          pitch = 19;
          break;
        case "g":
          pitch = 25;
          break;
        case "a":
          pitch = 31;
          break;
        case "b":
          pitch = 37;
          break;
        default:
          pitch = 0;
          break;
      }

      //Conversion without accidentals as diatonic step
      return oct + pitch;
    }



    /// <summary>
    /// Parse @num or @numbase as int
    /// </summary>
    /// <param name="_attRatio">Attribute @num or @numbase</param>
    /// <returns>Value as int</returns>
    internal static int ConvertNumNumbase(XAttribute _attRatio)
    {
      if (_attRatio == null)
      {
        return 0;
      }
      else if (Int32.TryParse(_attRatio.Value, out int value))
      {
        return value;
      }
      else
      {
        throw new InvalidOperationException($"Parsing of {_attRatio.Name.LocalName} failed!");
      }
    }

    /// <summary>
    /// Converts value of an attribute (like @dur) into Enum Duration
    /// </summary>
    /// <param name="_dur">XAttribute</param>
    /// <returns>Model.Duration</returns>
    internal static Model.Duration ConvertDuration(XAttribute _dur)
    {
      if (_dur == null)
      {
        return Model.Duration.Null;
      }
      else if (Enum.TryParse(_dur.Value, true, out Model.Duration dur))
      {
        return dur;
      }
      else
      {
        return Model.Duration.Invalid;
      }

    }

    internal static Model.AccidType ConvertAccid(XAttribute _accid)
    {
      if (_accid.Value == "s")
      {
        return Model.AccidType.Sharp;
      }
      else if (_accid.Value == "f")
      {
        return Model.AccidType.Flat;
      }
      else if (_accid.Value == "n")
      {
        return Model.AccidType.Neutral;
      }
      else
      {
        throw new InvalidOperationException("Invalid accidental value!");
      }
    }
  }
}
