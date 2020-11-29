using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;

namespace mei2Sequence
{
  public class RestConverter
  {
    /// <summary>
    /// Adds properties to a rest object
    /// </summary>
    /// <param name="_restobj">Empty Rest object</param>
    /// <param name="_meirest">MEI rest element</param>
    /// <returns>Rest object with properties</returns>
    public static Model.Rest ConvertRest(Model.Rest _restobj, mei.Rest _meirest)
    {
      _restobj.Duration = ConvertDuration(_meirest);
      _restobj.Num = ConverterHelper.ConvertNumNumbase(_meirest.GetNumAttribute());
      _restobj.Numbase = ConverterHelper.ConvertNumNumbase(_meirest.GetNumbaseAttribute());

      return _restobj;
    }
    
    /// <summary>
    /// Converts value of @dur into Enum Duration
    /// </summary>
    /// <param name="_element">MEI note/rest element</param>
    /// <returns>Model.Duration</returns>
    protected static Model.Duration ConvertDuration(mei.IAttDurationMusical _element)
    {
      return ConverterHelper.ConvertDuration(_element.GetDurAttribute());
    }
  }
}
