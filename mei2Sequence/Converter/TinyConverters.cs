using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;

namespace mei2Sequence
{
  public static class TinyConverters
  {
    #region Evidence
    public static Model.Evidence GetEvidence(MeiElement _evd)
    {
      if (_evd is mei.Unclear unclear)
      {
        if (unclear.HasCert() == false)
        {
          return Model.Evidence.Unclear_unknown;
        }
        else
        {
          string cert = "Unclear_" + unclear.GetCertValue();
          if (Enum.TryParse(cert, true, out Model.Evidence evidence))
          {
            return evidence;
          }
          else
          {
            return Model.Evidence.Invalid;
          }
        }
      }
      else if (_evd is mei.Supplied)
      {
        return Model.Evidence.Supplied;
      }
      else
      {
        throw new InvalidOperationException("Ops! The current element should be <unclear> or <supplied>!");
      }
    }
    #endregion

    #region Gap
    /// <summary>
    /// Converts mei.Damage or mei.Gap into Model.Gap and sets GapType and Reason.
    /// </summary>
    /// <param name="_gap">Empty Model.Gap object</param>
    /// <param name="_meigap">MeiElement, needs to be mei.Damage or mei.Gap</param>
    /// <returns>Model.Gap object with data</returns>
    public static Model.Gap ConvertGap(Model.Gap _gap, MeiElement _meigap)
    {
      if (_meigap is mei.Gap _gapgap)
      {
        _gap.GapType = Model.GapType.Gap;
        _gap.Reason = _gapgap.GetReasonValue();
      }
      else if (_meigap is mei.Damage _damagegap)
      {
        _gap.GapType = Model.GapType.Damage;
        _gap.Reason = _damagegap.GetAgentValue();
      }
      else
      {
        _gap.GapType = Model.GapType.Null;
      }

      return _gap;
    }
    #endregion

    #region Ligature
    /// <summary>
    /// Adds ligature information to a Model.Note object
    /// </summary>
    /// <param name="_note">Model.Note object</param>
    /// <param name="_ligaturePos">Position in ligature</param>
    /// <param name="_ligForm">mei.Ligature @form as string</param>
    /// <returns>Model.Note object</returns>
    public static Model.Note LigatureHandler(Model.Note _note, int _ligaturePos, string _ligForm)
    {
      _note.LigaturePosition = _ligaturePos;

      if (Enum.TryParse(_ligForm, true, out Model.LigatureForm ligatureForm))
      {
        _note.LigatureForm = ligatureForm;
      }
      else
      {
        _note.LigatureForm = Model.LigatureForm.Null;
      }

      return _note;
    }
    #endregion

    #region Clef
    /// <summary>
    /// Adds clef information to an empty Clef object
    /// </summary>
    /// <param name="_clefobj">Empty clef object</param>
    /// <param name="_meiclef">MEI clef element</param>
    /// <returns>Clef with data</returns>
    public static Model.Clef ConvertClef(Model.Clef _clefobj, mei.Clef _meiclef)
    {
      _clefobj.Line = ReadLine(_meiclef);
      _clefobj.Shape = ConvertClefshape(_meiclef);

      return _clefobj;
    }

    /// <summary>
    /// Reads @line and converts to int
    /// </summary>
    /// <param name="_meiclef">MEI clef element</param>
    /// <returns>parsed @line value as int</returns>
    private static int ReadLine(mei.Clef _meiclef)
    {
      if (_meiclef.GetShapeValue() != null)
      {
        if (_meiclef.GetLineValue() == null)
        {
          throw new NullReferenceException("Clef has no line!");
        }
        else if (Int32.TryParse(_meiclef.GetLineValue(), out int value))
        {
          return value;
        }
        else
        {
          throw new InvalidOperationException($"Parsing {_meiclef.GetLineAttribute().Name.LocalName} of clef failed!");
        }
      }
      else
      {
        return 0;
      }
    }

    /// <summary>
    /// Parse celf/@shape into Model.Clefshape
    /// </summary>
    /// <param name="_meiclef">MEI clef element</param>
    /// <returns>Model.Clefshape</returns>
    private static Model.Clefshape ConvertClefshape(mei.Clef _meiclef)
    {
      if (_meiclef.GetShapeValue() == null)
      {
        return Model.Clefshape.Null;
      }
      else if (Enum.TryParse(_meiclef.GetShapeValue(), true, out Model.Clefshape shape))
      {
        return shape;
      }
      else
      {
        throw new InvalidOperationException("Invalid value of clef/@shape!");
      }
    }
    #endregion

    #region BarLine
    /// <summary>
    /// Adds barline information to empty barline object.
    /// </summary>
    /// <param name="_barline">Empty barline object</param>
    /// <param name="_meibarline">MEI BarLine element</param>
    /// <returns>Filled barline object</returns>
    public static Model.Barline ConvertBarline(Model.Barline _barline, mei.BarLine _meibarline)
    {
      _barline.BarlineType = ConvertBarlineType(_meibarline);

      return _barline;
    }

    private static Model.BarlineType ConvertBarlineType(mei.BarLine _meibarline)
    {
      string rend = _meibarline.GetFormValue();

      if (rend == null)
      {
        return Model.BarlineType.Null;
      }
      else if (rend == "dbl")
      {
        return Model.BarlineType.Double;
      }
      else if (Enum.TryParse(rend, true, out Model.BarlineType linetype))
      {
        return linetype;
      }
      else
      {
        return Model.BarlineType.Invalid;
      }
    }
    #endregion

    #region Custos
    public static Model.Custos ConvertCustos(Model.Custos _custos, mei.Custos _meiCustos)
    {
      _custos.PitchLocation = ConverterHelper.ConvertToBase40(_meiCustos.GetPnameValue(), _meiCustos.GetOctValue());
      return _custos;
    }
    #endregion
  }
}
