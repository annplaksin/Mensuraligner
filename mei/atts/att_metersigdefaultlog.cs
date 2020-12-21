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

namespace mei
{
    /// <summary>
  /// Interface for att.meterSigDefault.log
  /// </summary>
  public interface IAttMeterSigDefaultLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meterSigDefault.log
  /// </summary>
  public static class AttMeterSigDefaultLog_extensions
  {
    #region meter.count
    
    public static void SetMeterCount(this IAttMeterSigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meter.count", _val);
    }

    public static XAttribute GetMeterCountAttribute(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "meter.count");
    }
    
    public static string GetMeterCountValue(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meter.count");
    }
    
    public static bool HasMeterCount(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "meter.count");
    }

    public static void RemoveMeterCount(this IAttMeterSigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meter.count");
    }
    #endregion

    #region meter.unit
    
    public static void SetMeterUnit(this IAttMeterSigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meter.unit", _val);
    }

    public static XAttribute GetMeterUnitAttribute(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "meter.unit");
    }
    
    public static string GetMeterUnitValue(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meter.unit");
    }
    
    public static bool HasMeterUnit(this IAttMeterSigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "meter.unit");
    }

    public static void RemoveMeterUnit(this IAttMeterSigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meter.unit");
    }
    #endregion

  }

}