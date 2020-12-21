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
  /// Interface for att.commonPart
  /// </summary>
  public interface IAttCommonPart : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.commonPart
  /// </summary>
  public static class AttCommonPart_extensions
  {
    #region label
    
    public static void SetLabel(this IAttCommonPart e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "label", _val);
    }

    public static XAttribute GetLabelAttribute(this IAttCommonPart e)
    {
      return MeiAtt_controller.GetAttribute(e, "label");
    }
    
    public static string GetLabelValue(this IAttCommonPart e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "label");
    }
    
    public static bool HasLabel(this IAttCommonPart e)
    {
      return MeiAtt_controller.HasAttribute(e, "label");
    }

    public static void RemoveLabel(this IAttCommonPart e)
    {
      MeiAtt_controller.RemoveAttribute(e, "label");
    }
    #endregion

    #region xml:base
    
    public static void SetBase(this IAttCommonPart e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xml:base", _val);
    }

    public static XAttribute GetBaseAttribute(this IAttCommonPart e)
    {
      return MeiAtt_controller.GetAttribute(e, "xml:base");
    }
    
    public static string GetBaseValue(this IAttCommonPart e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xml:base");
    }
    
    public static bool HasBase(this IAttCommonPart e)
    {
      return MeiAtt_controller.HasAttribute(e, "xml:base");
    }

    public static void RemoveBase(this IAttCommonPart e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xml:base");
    }
    #endregion

  }

}