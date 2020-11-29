using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;

namespace mei2Sequence
{
  public static class AccidentalConverter
  {
    /// <summary>
    /// Add properties to Accidental
    /// </summary>
    /// <param name="_accidobj">Empty accidental object</param>
    /// <param name="_accid">MEI accid element</param>
    /// <returns></returns>
    public static Accidental ConvertAccidental(Accidental _accidobj, Accid _accid)
    {
      _accidobj.AccidentalPosition = GetPosition(_accid);
      _accidobj.AccidentalType = GetAccidentalType(_accid);
      _accidobj.PitchLocation = GetAccidPitchLoc(_accid);

      return _accidobj;
    }

    public static KeyAccidental ConvertKeyAccidental(KeyAccidental _keyaccidobj, KeyAccid _keyaccid)
    {
      _keyaccidobj.AccidentalType = GetAccidentalType(_keyaccid);
      _keyaccidobj.PitchLocation = GetKeyAccidPitch(_keyaccid);

      return _keyaccidobj;
    }

    /// <summary>
    /// Reads @mse:accidPos
    /// </summary>
    /// <param name="_accid">MEI accid element</param>
    /// <returns>Position</returns>
    private static Position GetPosition(Accid _accid)
    {
      Enum.TryParse(_accid.GetAccidPosValue(), true, out Position pos);
      return pos;
    }

    /// <summary>
    /// Reads @accid and returns AccidentalType if matchable.
    /// Otherwise AccidType.Null if @accid doesn't exist and AccidType.Invalid if value of @accid doesn't match.
    /// </summary>
    /// <param name="_accid">MEI accid element</param>
    /// <returns>AccidType</returns>
    private static Model.AccidType GetAccidentalType(mei.IAttAccidental _accid)
    {
      if (_accid.HasAccid())
      {
        return ConverterHelper.ConvertAccid(_accid.GetAccidAttribute());
      }
      else
      {
        return Model.AccidType.Null;
      }
    }

    /// <summary>
    /// Gets base-40 pitch location for accid element
    /// </summary>
    /// <param name="_accid">MEI accid</param>
    /// <returns>Base-40 int</returns>
    private static int GetAccidPitchLoc(Accid _accid)
    {
      return ConverterHelper.ConvertToBase40(_accid.GetPlocValue(), _accid.GetOlocValue());
    }

    /// <summary>
    /// Gets base-40 diatonic pitch for keyAccid
    /// </summary>
    /// <param name="_keyaccid">MEI keyAccid</param>
    /// <returns>Base-40 int</returns>
    private static int GetKeyAccidPitch(KeyAccid _keyaccid)
    {
      return ConverterHelper.ConvertToBase40(_keyaccid.GetPnameValue(), _keyaccid.GetOctValue());
    }
  }
}
