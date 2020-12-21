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
  /// Interface for att.meterSigDefault.vis
  /// </summary>
  public interface IAttMeterSigDefaultVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meterSigDefault.vis
  /// </summary>
  public static class AttMeterSigDefaultVis_extensions
  {
    #region meter.rend
    
    public static void SetMeterRend(this IAttMeterSigDefaultVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meter.rend", _val);
    }

    public static XAttribute GetMeterRendAttribute(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "meter.rend");
    }
    
    public static string GetMeterRendValue(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meter.rend");
    }
    
    public static bool HasMeterRend(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "meter.rend");
    }

    public static void RemoveMeterRend(this IAttMeterSigDefaultVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meter.rend");
    }
    #endregion

    #region meter.showchange
    
    public static void SetMeterShowchange(this IAttMeterSigDefaultVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meter.showchange", _val);
    }

    public static XAttribute GetMeterShowchangeAttribute(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "meter.showchange");
    }
    
    public static string GetMeterShowchangeValue(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meter.showchange");
    }
    
    public static bool HasMeterShowchange(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "meter.showchange");
    }

    public static void RemoveMeterShowchange(this IAttMeterSigDefaultVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meter.showchange");
    }
    #endregion

    #region meter.sym
    
    public static void SetMeterSym(this IAttMeterSigDefaultVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meter.sym", _val);
    }

    public static XAttribute GetMeterSymAttribute(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "meter.sym");
    }
    
    public static string GetMeterSymValue(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meter.sym");
    }
    
    public static bool HasMeterSym(this IAttMeterSigDefaultVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "meter.sym");
    }

    public static void RemoveMeterSym(this IAttMeterSigDefaultVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meter.sym");
    }
    #endregion

  }

}