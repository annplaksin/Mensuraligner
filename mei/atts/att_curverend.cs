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
  /// Interface for att.curverend
  /// </summary>
  public interface IAttCurverend : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.curverend
  /// </summary>
  public static class AttCurverend_extensions
  {
    #region lform
    
    public static void SetLform(this IAttCurverend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lform", _val);
    }

    public static XAttribute GetLformAttribute(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lform");
    }
    
    public static string GetLformValue(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lform");
    }
    
    public static bool HasLform(this IAttCurverend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lform");
    }

    public static void RemoveLform(this IAttCurverend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lform");
    }
    #endregion

    #region lwidth
    
    public static void SetLwidth(this IAttCurverend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lwidth", _val);
    }

    public static XAttribute GetLwidthAttribute(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lwidth");
    }
    
    public static string GetLwidthValue(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lwidth");
    }
    
    public static bool HasLwidth(this IAttCurverend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lwidth");
    }

    public static void RemoveLwidth(this IAttCurverend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lwidth");
    }
    #endregion

  }

}