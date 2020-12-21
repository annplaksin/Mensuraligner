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
  /// Interface for att.linerend.base
  /// </summary>
  public interface IAttLinerendBase : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.linerend.base
  /// </summary>
  public static class AttLinerendBase_extensions
  {
    #region lform
    
    public static void SetLform(this IAttLinerendBase e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lform", _val);
    }

    public static XAttribute GetLformAttribute(this IAttLinerendBase e)
    {
      return MeiAtt_controller.GetAttribute(e, "lform");
    }
    
    public static string GetLformValue(this IAttLinerendBase e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lform");
    }
    
    public static bool HasLform(this IAttLinerendBase e)
    {
      return MeiAtt_controller.HasAttribute(e, "lform");
    }

    public static void RemoveLform(this IAttLinerendBase e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lform");
    }
    #endregion

    #region lwidth
    
    public static void SetLwidth(this IAttLinerendBase e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lwidth", _val);
    }

    public static XAttribute GetLwidthAttribute(this IAttLinerendBase e)
    {
      return MeiAtt_controller.GetAttribute(e, "lwidth");
    }
    
    public static string GetLwidthValue(this IAttLinerendBase e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lwidth");
    }
    
    public static bool HasLwidth(this IAttLinerendBase e)
    {
      return MeiAtt_controller.HasAttribute(e, "lwidth");
    }

    public static void RemoveLwidth(this IAttLinerendBase e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lwidth");
    }
    #endregion

  }

}