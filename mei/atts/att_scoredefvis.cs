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
  /// Interface for att.scoreDef.vis
  /// </summary>
  public interface IAttScoreDefVis : IMEiAtt, IAttBarplacement, IAttCleffingVis, IAttDistances, IAttKeySigDefaultVis, IAttLyricstyle, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttOnelinestaff, IAttTextstyle, IAttScoreDefVisMensural
  {

  }


    /// <summary>
  /// Extension methods for att.scoreDef.vis
  /// </summary>
  public static class AttScoreDefVis_extensions
  {
    #region ending.rend
    
    public static void SetEndingRend(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ending.rend", _val);
    }

    public static XAttribute GetEndingRendAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "ending.rend");
    }

    public static string GetEndingRendValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ending.rend");
    }

    public static bool HasEndingRend(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "ending.rend");
    }

    public static void RemoveEndingRend(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ending.rend");
    }
    #endregion

    #region mnum.visible
    
    public static void SetMnumVisible(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mnum.visible", _val);
    }

    public static XAttribute GetMnumVisibleAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mnum.visible");
    }

    public static string GetMnumVisibleValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mnum.visible");
    }

    public static bool HasMnumVisible(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mnum.visible");
    }

    public static void RemoveMnumVisible(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mnum.visible");
    }
    #endregion

    #region music.name
    
    public static void SetMusicName(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "music.name", _val);
    }

    public static XAttribute GetMusicNameAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "music.name");
    }

    public static string GetMusicNameValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "music.name");
    }

    public static bool HasMusicName(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "music.name");
    }

    public static void RemoveMusicName(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "music.name");
    }
    #endregion

    #region music.size
    
    public static void SetMusicSize(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "music.size", _val);
    }

    public static XAttribute GetMusicSizeAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "music.size");
    }

    public static string GetMusicSizeValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "music.size");
    }

    public static bool HasMusicSize(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "music.size");
    }

    public static void RemoveMusicSize(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "music.size");
    }
    #endregion

    #region optimize
    
    public static void SetOptimize(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "optimize", _val);
    }

    public static XAttribute GetOptimizeAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "optimize");
    }

    public static string GetOptimizeValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "optimize");
    }

    public static bool HasOptimize(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "optimize");
    }

    public static void RemoveOptimize(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "optimize");
    }
    #endregion

    #region page.height
    
    public static void SetPageHeight(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.height", _val);
    }

    public static XAttribute GetPageHeightAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.height");
    }

    public static string GetPageHeightValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.height");
    }

    public static bool HasPageHeight(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.height");
    }

    public static void RemovePageHeight(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.height");
    }
    #endregion

    #region page.width
    
    public static void SetPageWidth(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.width", _val);
    }

    public static XAttribute GetPageWidthAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.width");
    }

    public static string GetPageWidthValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.width");
    }

    public static bool HasPageWidth(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.width");
    }

    public static void RemovePageWidth(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.width");
    }
    #endregion

    #region page.topmar
    
    public static void SetPageTopmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.topmar", _val);
    }

    public static XAttribute GetPageTopmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.topmar");
    }

    public static string GetPageTopmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.topmar");
    }

    public static bool HasPageTopmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.topmar");
    }

    public static void RemovePageTopmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.topmar");
    }
    #endregion

    #region page.botmar
    
    public static void SetPageBotmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.botmar", _val);
    }

    public static XAttribute GetPageBotmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.botmar");
    }

    public static string GetPageBotmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.botmar");
    }

    public static bool HasPageBotmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.botmar");
    }

    public static void RemovePageBotmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.botmar");
    }
    #endregion

    #region page.leftmar
    
    public static void SetPageLeftmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.leftmar", _val);
    }

    public static XAttribute GetPageLeftmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.leftmar");
    }

    public static string GetPageLeftmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.leftmar");
    }

    public static bool HasPageLeftmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.leftmar");
    }

    public static void RemovePageLeftmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.leftmar");
    }
    #endregion

    #region page.rightmar
    
    public static void SetPageRightmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.rightmar", _val);
    }

    public static XAttribute GetPageRightmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.rightmar");
    }

    public static string GetPageRightmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.rightmar");
    }

    public static bool HasPageRightmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.rightmar");
    }

    public static void RemovePageRightmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.rightmar");
    }
    #endregion

    #region page.panels
    
    public static void SetPagePanels(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.panels", _val);
    }

    public static XAttribute GetPagePanelsAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.panels");
    }

    public static string GetPagePanelsValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.panels");
    }

    public static bool HasPagePanels(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.panels");
    }

    public static void RemovePagePanels(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.panels");
    }
    #endregion

    #region page.scale
    
    public static void SetPageScale(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.scale", _val);
    }

    public static XAttribute GetPageScaleAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.scale");
    }

    public static string GetPageScaleValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "page.scale");
    }

    public static bool HasPageScale(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.scale");
    }

    public static void RemovePageScale(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.scale");
    }
    #endregion

    #region spacing.packexp
    
    public static void SetSpacingPackexp(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.packexp", _val);
    }

    public static XAttribute GetSpacingPackexpAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.packexp");
    }

    public static string GetSpacingPackexpValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.packexp");
    }

    public static bool HasSpacingPackexp(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.packexp");
    }

    public static void RemoveSpacingPackexp(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.packexp");
    }
    #endregion

    #region spacing.packfact
    
    public static void SetSpacingPackfact(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.packfact", _val);
    }

    public static XAttribute GetSpacingPackfactAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.packfact");
    }

    public static string GetSpacingPackfactValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.packfact");
    }

    public static bool HasSpacingPackfact(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.packfact");
    }

    public static void RemoveSpacingPackfact(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.packfact");
    }
    #endregion

    #region spacing.staff
    
    public static void SetSpacingStaff(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.staff", _val);
    }

    public static XAttribute GetSpacingStaffAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.staff");
    }

    public static string GetSpacingStaffValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.staff");
    }

    public static bool HasSpacingStaff(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.staff");
    }

    public static void RemoveSpacingStaff(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.staff");
    }
    #endregion

    #region spacing.system
    
    public static void SetSpacingSystem(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.system", _val);
    }

    public static XAttribute GetSpacingSystemAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.system");
    }

    public static string GetSpacingSystemValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.system");
    }

    public static bool HasSpacingSystem(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.system");
    }

    public static void RemoveSpacingSystem(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.system");
    }
    #endregion

    #region system.leftmar
    
    public static void SetSystemLeftmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.leftmar", _val);
    }

    public static XAttribute GetSystemLeftmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.leftmar");
    }

    public static string GetSystemLeftmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.leftmar");
    }

    public static bool HasSystemLeftmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.leftmar");
    }

    public static void RemoveSystemLeftmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.leftmar");
    }
    #endregion

    #region system.rightmar
    
    public static void SetSystemRightmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.rightmar", _val);
    }

    public static XAttribute GetSystemRightmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.rightmar");
    }

    public static string GetSystemRightmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.rightmar");
    }

    public static bool HasSystemRightmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.rightmar");
    }

    public static void RemoveSystemRightmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.rightmar");
    }
    #endregion

    #region system.topmar
    
    public static void SetSystemTopmar(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.topmar", _val);
    }

    public static XAttribute GetSystemTopmarAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.topmar");
    }

    public static string GetSystemTopmarValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.topmar");
    }

    public static bool HasSystemTopmar(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.topmar");
    }

    public static void RemoveSystemTopmar(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.topmar");
    }
    #endregion

    #region vu.height
    
    public static void SetVuHeight(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "vu.height", _val);
    }

    public static XAttribute GetVuHeightAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "vu.height");
    }

    public static string GetVuHeightValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "vu.height");
    }

    public static bool HasVuHeight(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "vu.height");
    }

    public static void RemoveVuHeight(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "vu.height");
    }
    #endregion

  }

}