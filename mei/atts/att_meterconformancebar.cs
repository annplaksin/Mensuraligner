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
  /// Interface for att.meterconformance.bar
  /// </summary>
  public interface IAttMeterconformanceBar : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meterconformance.bar
  /// </summary>
  public static class AttMeterconformanceBar_extensions
  {
    #region metcon
    
    public static void SetMetcon(this IAttMeterconformanceBar e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "metcon", _val);
    }

    public static XAttribute GetMetconAttribute(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.GetAttribute(e, "metcon");
    }
    
    public static string GetMetconValue(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "metcon");
    }
    
    public static bool HasMetcon(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.HasAttribute(e, "metcon");
    }

    public static void RemoveMetcon(this IAttMeterconformanceBar e)
    {
      MeiAtt_controller.RemoveAttribute(e, "metcon");
    }
    #endregion

    #region control
    
    public static void SetControl(this IAttMeterconformanceBar e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "control", _val);
    }

    public static XAttribute GetControlAttribute(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.GetAttribute(e, "control");
    }
    
    public static string GetControlValue(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "control");
    }
    
    public static bool HasControl(this IAttMeterconformanceBar e)
    {
      return MeiAtt_controller.HasAttribute(e, "control");
    }

    public static void RemoveControl(this IAttMeterconformanceBar e)
    {
      MeiAtt_controller.RemoveAttribute(e, "control");
    }
    #endregion

  }

}