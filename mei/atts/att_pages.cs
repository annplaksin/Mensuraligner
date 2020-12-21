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
  /// Interface for att.pages
  /// </summary>
  public interface IAttPages : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pages
  /// </summary>
  public static class AttPages_extensions
  {
    #region page.height
    
    public static void SetPageHeight(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.height", _val);
    }

    public static XAttribute GetPageHeightAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.height");
    }
    
    public static string GetPageHeightValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.height");
    }
    
    public static bool HasPageHeight(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.height");
    }

    public static void RemovePageHeight(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.height");
    }
    #endregion

    #region page.width
    
    public static void SetPageWidth(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.width", _val);
    }

    public static XAttribute GetPageWidthAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.width");
    }
    
    public static string GetPageWidthValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.width");
    }
    
    public static bool HasPageWidth(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.width");
    }

    public static void RemovePageWidth(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.width");
    }
    #endregion

    #region page.topmar
    
    public static void SetPageTopmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.topmar", _val);
    }

    public static XAttribute GetPageTopmarAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.topmar");
    }
    
    public static string GetPageTopmarValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.topmar");
    }
    
    public static bool HasPageTopmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.topmar");
    }

    public static void RemovePageTopmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.topmar");
    }
    #endregion

    #region page.botmar
    
    public static void SetPageBotmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.botmar", _val);
    }

    public static XAttribute GetPageBotmarAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.botmar");
    }
    
    public static string GetPageBotmarValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.botmar");
    }
    
    public static bool HasPageBotmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.botmar");
    }

    public static void RemovePageBotmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.botmar");
    }
    #endregion

    #region page.leftmar
    
    public static void SetPageLeftmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.leftmar", _val);
    }

    public static XAttribute GetPageLeftmarAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.leftmar");
    }
    
    public static string GetPageLeftmarValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.leftmar");
    }
    
    public static bool HasPageLeftmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.leftmar");
    }

    public static void RemovePageLeftmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.leftmar");
    }
    #endregion

    #region page.rightmar
    
    public static void SetPageRightmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.rightmar", _val);
    }

    public static XAttribute GetPageRightmarAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.rightmar");
    }
    
    public static string GetPageRightmarValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.rightmar");
    }
    
    public static bool HasPageRightmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.rightmar");
    }

    public static void RemovePageRightmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.rightmar");
    }
    #endregion

    #region page.panels
    
    public static void SetPagePanels(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.panels", _val);
    }

    public static XAttribute GetPagePanelsAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.panels");
    }
    
    public static string GetPagePanelsValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.panels");
    }
    
    public static bool HasPagePanels(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.panels");
    }

    public static void RemovePagePanels(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.panels");
    }
    #endregion

    #region page.scale
    
    public static void SetPageScale(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.scale", _val);
    }

    public static XAttribute GetPageScaleAttribute(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.scale");
    }
    
    public static string GetPageScaleValue(this IAttPages e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.scale");
    }
    
    public static bool HasPageScale(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.scale");
    }

    public static void RemovePageScale(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.scale");
    }
    #endregion

  }

}