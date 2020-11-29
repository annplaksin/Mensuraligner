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
  /// Interface for att.mmtempo
  /// </summary>
  public interface IAttMmtempo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.mmtempo
  /// </summary>
  public static class AttMmtempo_extensions
  {
    #region mm
    
    public static void SetMm(this IAttMmtempo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mm", _val);
    }

    public static XAttribute GetMmAttribute(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttribute(e, "mm");
    }

    public static string GetMmValue(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mm");
    }

    public static bool HasMm(this IAttMmtempo e)
    {
      return MeiAtt_controller.HasAttribute(e, "mm");
    }

    public static void RemoveMm(this IAttMmtempo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mm");
    }
    #endregion

    #region mm.unit
    
    public static void SetMmUnit(this IAttMmtempo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mm.unit", _val);
    }

    public static XAttribute GetMmUnitAttribute(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttribute(e, "mm.unit");
    }

    public static string GetMmUnitValue(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mm.unit");
    }

    public static bool HasMmUnit(this IAttMmtempo e)
    {
      return MeiAtt_controller.HasAttribute(e, "mm.unit");
    }

    public static void RemoveMmUnit(this IAttMmtempo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mm.unit");
    }
    #endregion

    #region mm.dots
    
    public static void SetMmDots(this IAttMmtempo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mm.dots", _val);
    }

    public static XAttribute GetMmDotsAttribute(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttribute(e, "mm.dots");
    }

    public static string GetMmDotsValue(this IAttMmtempo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mm.dots");
    }

    public static bool HasMmDots(this IAttMmtempo e)
    {
      return MeiAtt_controller.HasAttribute(e, "mm.dots");
    }

    public static void RemoveMmDots(this IAttMmtempo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mm.dots");
    }
    #endregion

  }

}