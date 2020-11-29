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
  /// Interface for att.xy2
  /// </summary>
  public interface IAttXy2 : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.xy2
  /// </summary>
  public static class AttXy2_extensions
  {
    #region x2
    
    public static void SetX2(this IAttXy2 e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "x2", _val);
    }

    public static XAttribute GetX2Attribute(this IAttXy2 e)
    {
      return MeiAtt_controller.GetAttribute(e, "x2");
    }

    public static string GetX2Value(this IAttXy2 e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "x2");
    }

    public static bool HasX2(this IAttXy2 e)
    {
      return MeiAtt_controller.HasAttribute(e, "x2");
    }

    public static void RemoveX2(this IAttXy2 e)
    {
      MeiAtt_controller.RemoveAttribute(e, "x2");
    }
    #endregion

    #region y2
    
    public static void SetY2(this IAttXy2 e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "y2", _val);
    }

    public static XAttribute GetY2Attribute(this IAttXy2 e)
    {
      return MeiAtt_controller.GetAttribute(e, "y2");
    }

    public static string GetY2Value(this IAttXy2 e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "y2");
    }

    public static bool HasY2(this IAttXy2 e)
    {
      return MeiAtt_controller.HasAttribute(e, "y2");
    }

    public static void RemoveY2(this IAttXy2 e)
    {
      MeiAtt_controller.RemoveAttribute(e, "y2");
    }
    #endregion

  }

}