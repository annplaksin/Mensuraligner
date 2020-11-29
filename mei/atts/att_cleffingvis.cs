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
  /// Interface for att.cleffing.vis
  /// </summary>
  public interface IAttCleffingVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.cleffing.vis
  /// </summary>
  public static class AttCleffingVis_extensions
  {
    #region clef.color
    
    public static void SetClefColor(this IAttCleffingVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.color", _val);
    }

    public static XAttribute GetClefColorAttribute(this IAttCleffingVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.color");
    }

    public static string GetClefColorValue(this IAttCleffingVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.color");
    }

    public static bool HasClefColor(this IAttCleffingVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.color");
    }

    public static void RemoveClefColor(this IAttCleffingVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.color");
    }
    #endregion

    #region clef.visible
    
    public static void SetClefVisible(this IAttCleffingVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.visible", _val);
    }

    public static XAttribute GetClefVisibleAttribute(this IAttCleffingVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.visible");
    }

    public static string GetClefVisibleValue(this IAttCleffingVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.visible");
    }

    public static bool HasClefVisible(this IAttCleffingVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.visible");
    }

    public static void RemoveClefVisible(this IAttCleffingVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.visible");
    }
    #endregion

  }

}