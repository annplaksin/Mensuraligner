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
  /// Interface for att.textstyle
  /// </summary>
  public interface IAttTextstyle : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.textstyle
  /// </summary>
  public static class AttTextstyle_extensions
  {
    #region text.fam
    
    public static void SetTextFam(this IAttTextstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.fam", _val);
    }

    public static XAttribute GetTextFamAttribute(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.fam");
    }

    public static string GetTextFamValue(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "text.fam");
    }

    public static bool HasTextFam(this IAttTextstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.fam");
    }

    public static void RemoveTextFam(this IAttTextstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.fam");
    }
    #endregion

    #region text.name
    
    public static void SetTextName(this IAttTextstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.name", _val);
    }

    public static XAttribute GetTextNameAttribute(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.name");
    }

    public static string GetTextNameValue(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "text.name");
    }

    public static bool HasTextName(this IAttTextstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.name");
    }

    public static void RemoveTextName(this IAttTextstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.name");
    }
    #endregion

    #region text.size
    
    public static void SetTextSize(this IAttTextstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.size", _val);
    }

    public static XAttribute GetTextSizeAttribute(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.size");
    }

    public static string GetTextSizeValue(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "text.size");
    }

    public static bool HasTextSize(this IAttTextstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.size");
    }

    public static void RemoveTextSize(this IAttTextstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.size");
    }
    #endregion

    #region text.style
    
    public static void SetTextStyle(this IAttTextstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.style", _val);
    }

    public static XAttribute GetTextStyleAttribute(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.style");
    }

    public static string GetTextStyleValue(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "text.style");
    }

    public static bool HasTextStyle(this IAttTextstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.style");
    }

    public static void RemoveTextStyle(this IAttTextstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.style");
    }
    #endregion

    #region text.weight
    
    public static void SetTextWeight(this IAttTextstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.weight", _val);
    }

    public static XAttribute GetTextWeightAttribute(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.weight");
    }

    public static string GetTextWeightValue(this IAttTextstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "text.weight");
    }

    public static bool HasTextWeight(this IAttTextstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.weight");
    }

    public static void RemoveTextWeight(this IAttTextstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.weight");
    }
    #endregion

  }

}