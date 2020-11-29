using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/////////////////////////////////////////////////////////////////////////////
// Authors:     Anna Plaksin
// Created:     2017
// Copyright (c) Authors and others. All rights reserved.
//
// Code generated using a modified version of libmei
// by Andrew Hankinson, Alastair Porter, and Others
/////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
  /// Interface for att.meterSig.log
  /// </summary>
  public interface IAttMeterSigLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meterSig.log
  /// </summary>
  public static class AttMeterSigLog_extensions
  {
    #region count
    
    public static void SetCount(this IAttMeterSigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "count", _val);
    }

    public static XAttribute GetCountAttribute(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "count");
    }

    public static string GetCountValue(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "count");
    }

    public static bool HasCount(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "count");
    }

    public static void RemoveCount(this IAttMeterSigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "count");
    }
    #endregion

    #region sym
    
    public static void SetSym(this IAttMeterSigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sym", _val);
    }

    public static XAttribute GetSymAttribute(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "sym");
    }

    public static string GetSymValue(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "sym");
    }

    public static bool HasSym(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "sym");
    }

    public static void RemoveSym(this IAttMeterSigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sym");
    }
    #endregion

    #region unit
    
    public static void SetUnit(this IAttMeterSigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "unit", _val);
    }

    public static XAttribute GetUnitAttribute(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "unit");
    }

    public static string GetUnitValue(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "unit");
    }

    public static bool HasUnit(this IAttMeterSigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "unit");
    }

    public static void RemoveUnit(this IAttMeterSigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "unit");
    }
    #endregion

  }

}