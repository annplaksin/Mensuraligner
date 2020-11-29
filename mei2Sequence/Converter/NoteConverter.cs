using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;

namespace mei2Sequence
{
  public class NoteConverter : RestConverter
  {
    /// <summary>
    /// Adds properties to Note
    /// </summary>
    /// <param name="_note">MEI note element</param>
    /// <param name="_noteObject">Empty note object</param>
    /// <returns>Note object with content</returns>
    public static Model.Note ConvertNote(Model.Note _noteObject, mei.Note _note)
    {
      _noteObject.Coloration = GetColoration(_note);
      _noteObject.Fermata = GetFermata(_note);
      _noteObject.WrittenPitch = ConvertWrittenpitch(_note);
      _noteObject.Duration = ConvertDuration(_note);
      _noteObject.Num = ConverterHelper.ConvertNumNumbase(_note.GetNumAttribute());
      _noteObject.Numbase = ConverterHelper.ConvertNumNumbase(_note.GetNumbaseAttribute());
      _noteObject.Stem = ConvertStem(_note);
      if (_note.HasAccidGes())
      {
        _noteObject.AccidGes = ConverterHelper.ConvertAccid(_note.GetAccidGesAttribute());
      }
      
      return _noteObject;
    }
    
    /// <summary>
    /// Converts the pitch information of a note element into base-40 without accidentals
    /// </summary>
    /// <param name="_note">MEI note element</param>
    /// <returns>Base-40 value as integer</returns>
    private static int ConvertWrittenpitch(mei.Note _note)
    {
      //Conversion without accidentals
      return ConverterHelper.ConvertToBase40(_note.GetPnameValue(), _note.GetOctValue());
    }

    /// <summary>
    /// Check if note has @colored="true"
    /// </summary>
    /// <param name="_note">MEI note element</param>
    /// <returns>Return if note element is colored</returns>
    private static bool GetColoration(mei.Note _note)
    {
      if (_note.HasColored())
      {
        if (_note.GetColoredValue() == "true")
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      else
      {
        return false;
      }
    }

    /// <summary>
    /// Check if note has @fermata attribute
    /// </summary>
    /// <param name="_note">MEI note element</param>
    /// <returns>True if note has fermata</returns>
    private static bool GetFermata(mei.Note _note)
    {
      if (_note.HasFermata())
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    /// <summary>
    /// Converts @stem.pos and @stem.dir into StemDesc
    /// </summary>
    /// <param name="_note">mei.Note element</param>
    /// <returns>Stem description</returns>
    private static Model.StemDesc ConvertStem(mei.Note _note)
    {
      string pos = null;
      string dir = null;

      if (_note.HasStemDir())
      {
        dir = _note.GetStemDirValue();
      }
      if (_note.HasStemPos())
      {
        pos = _note.GetStemPosValue();
      }

      if (Enum.TryParse(pos + dir, true, out Model.StemDesc Stem))
      {
        return Stem;
      }
      else
      {
        return StemDesc.Null;
      }
    }
  }
}
