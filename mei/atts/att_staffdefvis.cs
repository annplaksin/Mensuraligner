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
  /// Interface for att.staffDef.vis
  /// </summary>
  public interface IAttStaffDefVis : IMEiAtt, IAttCleffingVis, IAttDistances, IAttKeySigDefaultVis, IAttLabelsAddl, IAttLyricstyle, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttOnelinestaff, IAttScalable, IAttTextstyle, IAttVisibility, IAttStaffDefVisMensural
  {

  }


    /// <summary>
  /// Extension methods for att.staffDef.vis
  /// </summary>
  public static class AttStaffDefVis_extensions
  {
    #region grid.show
    
    public static void SetGridShow(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "grid.show", _val);
    }

    public static XAttribute GetGridShowAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "grid.show");
    }

    public static string GetGridShowValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "grid.show");
    }

    public static bool HasGridShow(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "grid.show");
    }

    public static void RemoveGridShow(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "grid.show");
    }
    #endregion

    #region layerscheme
    
    public static void SetLayerscheme(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "layerscheme", _val);
    }

    public static XAttribute GetLayerschemeAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "layerscheme");
    }

    public static string GetLayerschemeValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "layerscheme");
    }

    public static bool HasLayerscheme(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "layerscheme");
    }

    public static void RemoveLayerscheme(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "layerscheme");
    }
    #endregion

    #region lines
    
    public static void SetLines(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lines", _val);
    }

    public static XAttribute GetLinesAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "lines");
    }

    public static string GetLinesValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lines");
    }

    public static bool HasLines(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "lines");
    }

    public static void RemoveLines(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lines");
    }
    #endregion

    #region lines.color
    
    public static void SetLinesColor(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lines.color", _val);
    }

    public static XAttribute GetLinesColorAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "lines.color");
    }

    public static string GetLinesColorValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lines.color");
    }

    public static bool HasLinesColor(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "lines.color");
    }

    public static void RemoveLinesColor(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lines.color");
    }
    #endregion

    #region lines.visible
    
    public static void SetLinesVisible(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lines.visible", _val);
    }

    public static XAttribute GetLinesVisibleAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "lines.visible");
    }

    public static string GetLinesVisibleValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lines.visible");
    }

    public static bool HasLinesVisible(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "lines.visible");
    }

    public static void RemoveLinesVisible(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lines.visible");
    }
    #endregion

    #region spacing
    
    public static void SetSpacing(this IAttStaffDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing", _val);
    }

    public static XAttribute GetSpacingAttribute(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing");
    }

    public static string GetSpacingValue(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing");
    }

    public static bool HasSpacing(this IAttStaffDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing");
    }

    public static void RemoveSpacing(this IAttStaffDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing");
    }
    #endregion

  }

}