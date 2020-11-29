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
  /// Interface for att.pointing
  /// </summary>
  public interface IAttPointing : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pointing
  /// </summary>
  public static class AttPointing_extensions
  {
    #region xlink:actuate
    
    public static void SetActuate(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:actuate", _val);
    }

    public static XAttribute GetActuateAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:actuate");
    }

    public static string GetActuateValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xlink:actuate");
    }

    public static bool HasActuate(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:actuate");
    }

    public static void RemoveActuate(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:actuate");
    }
    #endregion

    #region xlink:role
    
    public static void SetRole(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:role", _val);
    }

    public static XAttribute GetRoleAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:role");
    }

    public static string GetRoleValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xlink:role");
    }

    public static bool HasRole(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:role");
    }

    public static void RemoveRole(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:role");
    }
    #endregion

    #region xlink:show
    
    public static void SetShow(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:show", _val);
    }

    public static XAttribute GetShowAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:show");
    }

    public static string GetShowValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xlink:show");
    }

    public static bool HasShow(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:show");
    }

    public static void RemoveShow(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:show");
    }
    #endregion

    #region target
    
    public static void SetTarget(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "target", _val);
    }

    public static XAttribute GetTargetAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "target");
    }

    public static string GetTargetValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "target");
    }

    public static bool HasTarget(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "target");
    }

    public static void RemoveTarget(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "target");
    }
    #endregion

    #region targettype
    
    public static void SetTargettype(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "targettype", _val);
    }

    public static XAttribute GetTargettypeAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "targettype");
    }

    public static string GetTargettypeValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "targettype");
    }

    public static bool HasTargettype(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "targettype");
    }

    public static void RemoveTargettype(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "targettype");
    }
    #endregion

    #region xlink:title
    
    public static void SetTitle(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:title", _val);
    }

    public static XAttribute GetTitleAttribute(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:title");
    }

    public static string GetTitleValue(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xlink:title");
    }

    public static bool HasTitle(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:title");
    }

    public static void RemoveTitle(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:title");
    }
    #endregion

  }

}