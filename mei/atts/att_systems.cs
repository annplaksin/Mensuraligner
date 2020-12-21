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
  /// Interface for att.systems
  /// </summary>
  public interface IAttSystems : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.systems
  /// </summary>
  public static class AttSystems_extensions
  {
    #region system.leftline
    
    public static void SetSystemLeftline(this IAttSystems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.leftline", _val);
    }

    public static XAttribute GetSystemLeftlineAttribute(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.leftline");
    }
    
    public static string GetSystemLeftlineValue(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.leftline");
    }
    
    public static bool HasSystemLeftline(this IAttSystems e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.leftline");
    }

    public static void RemoveSystemLeftline(this IAttSystems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.leftline");
    }
    #endregion

    #region system.leftmar
    
    public static void SetSystemLeftmar(this IAttSystems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.leftmar", _val);
    }

    public static XAttribute GetSystemLeftmarAttribute(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.leftmar");
    }
    
    public static string GetSystemLeftmarValue(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.leftmar");
    }
    
    public static bool HasSystemLeftmar(this IAttSystems e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.leftmar");
    }

    public static void RemoveSystemLeftmar(this IAttSystems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.leftmar");
    }
    #endregion

    #region system.rightmar
    
    public static void SetSystemRightmar(this IAttSystems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.rightmar", _val);
    }

    public static XAttribute GetSystemRightmarAttribute(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.rightmar");
    }
    
    public static string GetSystemRightmarValue(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.rightmar");
    }
    
    public static bool HasSystemRightmar(this IAttSystems e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.rightmar");
    }

    public static void RemoveSystemRightmar(this IAttSystems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.rightmar");
    }
    #endregion

    #region system.topmar
    
    public static void SetSystemTopmar(this IAttSystems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "system.topmar", _val);
    }

    public static XAttribute GetSystemTopmarAttribute(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttribute(e, "system.topmar");
    }
    
    public static string GetSystemTopmarValue(this IAttSystems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "system.topmar");
    }
    
    public static bool HasSystemTopmar(this IAttSystems e)
    {
      return MeiAtt_controller.HasAttribute(e, "system.topmar");
    }

    public static void RemoveSystemTopmar(this IAttSystems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "system.topmar");
    }
    #endregion

  }

}