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
  /// Interface for att.typography
  /// </summary>
  public interface IAttTypography : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.typography
  /// </summary>
  public static class AttTypography_extensions
  {
    #region fontfam
    
    public static void SetFontfam(this IAttTypography e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fontfam", _val);
    }

    public static XAttribute GetFontfamAttribute(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttribute(e, "fontfam");
    }
    
    public static string GetFontfamValue(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fontfam");
    }
    
    public static bool HasFontfam(this IAttTypography e)
    {
      return MeiAtt_controller.HasAttribute(e, "fontfam");
    }

    public static void RemoveFontfam(this IAttTypography e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fontfam");
    }
    #endregion

    #region fontname
    
    public static void SetFontname(this IAttTypography e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fontname", _val);
    }

    public static XAttribute GetFontnameAttribute(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttribute(e, "fontname");
    }
    
    public static string GetFontnameValue(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fontname");
    }
    
    public static bool HasFontname(this IAttTypography e)
    {
      return MeiAtt_controller.HasAttribute(e, "fontname");
    }

    public static void RemoveFontname(this IAttTypography e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fontname");
    }
    #endregion

    #region fontsize
    
    public static void SetFontsize(this IAttTypography e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fontsize", _val);
    }

    public static XAttribute GetFontsizeAttribute(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttribute(e, "fontsize");
    }
    
    public static string GetFontsizeValue(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fontsize");
    }
    
    public static bool HasFontsize(this IAttTypography e)
    {
      return MeiAtt_controller.HasAttribute(e, "fontsize");
    }

    public static void RemoveFontsize(this IAttTypography e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fontsize");
    }
    #endregion

    #region fontstyle
    
    public static void SetFontstyle(this IAttTypography e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fontstyle", _val);
    }

    public static XAttribute GetFontstyleAttribute(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttribute(e, "fontstyle");
    }
    
    public static string GetFontstyleValue(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fontstyle");
    }
    
    public static bool HasFontstyle(this IAttTypography e)
    {
      return MeiAtt_controller.HasAttribute(e, "fontstyle");
    }

    public static void RemoveFontstyle(this IAttTypography e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fontstyle");
    }
    #endregion

    #region fontweight
    
    public static void SetFontweight(this IAttTypography e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fontweight", _val);
    }

    public static XAttribute GetFontweightAttribute(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttribute(e, "fontweight");
    }
    
    public static string GetFontweightValue(this IAttTypography e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fontweight");
    }
    
    public static bool HasFontweight(this IAttTypography e)
    {
      return MeiAtt_controller.HasAttribute(e, "fontweight");
    }

    public static void RemoveFontweight(this IAttTypography e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fontweight");
    }
    #endregion

  }

}