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
  /// Interface for att.common
  /// </summary>
  public interface IAttCommon : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.common
  /// </summary>
  public static class AttCommon_extensions
  {
    #region n
    
    public static void SetN(this IAttCommon e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "n", _val);
    }

    public static XAttribute GetNAttribute(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttribute(e, "n");
    }

    public static string GetNValue(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "n");
    }

    public static bool HasN(this IAttCommon e)
    {
      return MeiAtt_controller.HasAttribute(e, "n");
    }

    public static void RemoveN(this IAttCommon e)
    {
      MeiAtt_controller.RemoveAttribute(e, "n");
    }
    #endregion

    #region label
    
    public static void SetLabel(this IAttCommon e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "label", _val);
    }

    public static XAttribute GetLabelAttribute(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttribute(e, "label");
    }

    public static string GetLabelValue(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "label");
    }

    public static bool HasLabel(this IAttCommon e)
    {
      return MeiAtt_controller.HasAttribute(e, "label");
    }

    public static void RemoveLabel(this IAttCommon e)
    {
      MeiAtt_controller.RemoveAttribute(e, "label");
    }
    #endregion

    #region xml:base
    
    public static void SetBase(this IAttCommon e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xml:base", _val);
    }

    public static XAttribute GetBaseAttribute(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttribute(e, "xml:base");
    }

    public static string GetBaseValue(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xml:base");
    }

    public static bool HasBase(this IAttCommon e)
    {
      return MeiAtt_controller.HasAttribute(e, "xml:base");
    }

    public static void RemoveBase(this IAttCommon e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xml:base");
    }
    #endregion

  }

}