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
  /// Interface for att.visualoffset2.ho
  /// </summary>
  public interface IAttVisualoffset2Ho : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset2.ho
  /// </summary>
  public static class AttVisualoffset2Ho_extensions
  {
    #region startho
    
    public static void SetStartho(this IAttVisualoffset2Ho e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startho", _val);
    }

    public static XAttribute GetStarthoAttribute(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.GetAttribute(e, "startho");
    }

    public static string GetStarthoValue(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "startho");
    }

    public static bool HasStartho(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.HasAttribute(e, "startho");
    }

    public static void RemoveStartho(this IAttVisualoffset2Ho e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startho");
    }
    #endregion

    #region endho
    
    public static void SetEndho(this IAttVisualoffset2Ho e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endho", _val);
    }

    public static XAttribute GetEndhoAttribute(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.GetAttribute(e, "endho");
    }

    public static string GetEndhoValue(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "endho");
    }

    public static bool HasEndho(this IAttVisualoffset2Ho e)
    {
      return MeiAtt_controller.HasAttribute(e, "endho");
    }

    public static void RemoveEndho(this IAttVisualoffset2Ho e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endho");
    }
    #endregion

  }

}