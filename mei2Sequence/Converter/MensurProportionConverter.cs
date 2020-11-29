using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei2Sequence.Model;
using mei;
using System.Xml.Linq;

namespace mei2Sequence
{
  public static class MensurProportionConverter
  {
    #region Mensur
    /// <summary>
    /// Adds properties to a Mensur object.
    /// </summary>
    /// <param name="_mensobj">Empty mensur object</param>
    /// <param name="_meimensur">MEI mensur element</param>
    /// <returns>Mensur object with data</returns>
    public static Model.Mensur ConvertMensur(Model.Mensur _mensobj, mei.Mensur _meimensur)
    {
      //Convert logic mensural values
      //If Modus and modusmaior are null, set value to 2
      _mensobj.Maximodus = ConvertLogicMensurAttribute(_meimensur.GetModusmaiorAttribute(), false, 2);
      _mensobj.Modus = ConvertLogicMensurAttribute(_meimensur.GetModusminorAttribute(), false, 2);
      //Tempus and Prolatio are not allowed to be null
      _mensobj.Tempus = ConvertLogicMensurAttribute(_meimensur.GetTempusAttribute());
      _mensobj.Prolatio = ConvertLogicMensurAttribute(_meimensur.GetProlatioAttribute());

      //Get sign
      _mensobj.Sign = GetSign(_meimensur);

      return _mensobj;
    }

    /// <summary>
    /// Converts @modusmaior, @modusminor, @tempus, and @prolatio
    /// </summary>
    /// <param name="_attMensural">Attribute</param>
    /// <param name="_throwErrorOnNull">Should exception be thrown if attribute is null</param>
    /// <param name="_default">Default value if attribute is null</param>
    /// <returns>Parsed value as int</returns>
    private static int ConvertLogicMensurAttribute(XAttribute _attMensural, bool _throwErrorOnNull = true, int _default = 0)
    {
      if (_attMensural == null && _throwErrorOnNull == false)
      {
        return _default;
      }
      else if (Int32.TryParse(_attMensural.Value, out int value))
      {
        if (value == 2 || value == 3)
        {
          return value;
        }
        else
        {
          throw new InvalidOperationException($"Parsed value of {_attMensural.Name.LocalName} is invalid!");
        }
      }
      else
      {
        throw new InvalidOperationException($"Parsing of {_attMensural.Name.LocalName} failed!");
      }
    }
    #endregion

    #region Proportion
    /// <summary>
    /// Adds properties to a Proportion object.
    /// </summary>
    /// <param name="_propobj">Empty proportion object</param>
    /// <param name="_meiprop">MEI proport element</param>
    /// <returns>Proportion object with data</returns>
    public static Model.Proportion ConvertProportion(Model.Proportion _propobj, mei.Proport _meiprop)
    {
      _propobj.Sign = GetSign(_meiprop);
      _propobj.Affected = ConvertAffected(_meiprop);

      if (_meiprop.HasNum() && _meiprop.HasNumbase())
      {
        _propobj.Num = ConverterHelper.ConvertNumNumbase(_meiprop.GetNumAttribute());
        _propobj.Numbase = ConverterHelper.ConvertNumNumbase(_meiprop.GetNumbaseAttribute());
      }
      else
      {
        throw new NullReferenceException($"<proport> doesn't have @num or @numbase!");
      }

      return _propobj;
    }

    /// <summary>
    /// Converts value of @mse:affected into Enum Duration
    /// </summary>
    /// <param name="_prop">MEI proport element</param>
    /// <returns>Model.Duration</returns>
    private static Duration ConvertAffected(mei.Proport _prop)
    {
      return ConverterHelper.ConvertDuration(_prop.GetAffectedAttribute());
    }

    /// <summary>
    /// Converts @altsym
    /// </summary>
    /// <param name="_meiSignElement">MEI element with @altsym</param>
    /// <returns>Sign value</returns>
    private static Sign GetSign(IAttAltsym _meiSignElement)
    {
      if (_meiSignElement.GetAltsymValue() == null)
      {
        return Sign.None;
      }
      else if(Enum.TryParse(_meiSignElement.GetAltsymValue().Substring(1), true, out Sign sign))
      {
        return sign;
      }
      else
      {
        return Sign.Invalid;
      }
    }
    #endregion
  }
}
