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
  /// Interface for att.color
  /// </summary>
  public interface IAttColor : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.color
  /// </summary>
  public static class AttColor_extensions
  {
    #region color
    
    public static void SetColor(this IAttColor e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "color", _val);
    }

    public static XAttribute GetColorAttribute(this IAttColor e)
    {
      return MeiAtt_controller.GetAttribute(e, "color");
    }

    public static string GetColorValue(this IAttColor e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "color");
    }

    public static bool HasColor(this IAttColor e)
    {
      return MeiAtt_controller.HasAttribute(e, "color");
    }

    public static void RemoveColor(this IAttColor e)
    {
      MeiAtt_controller.RemoveAttribute(e, "color");
    }
    #endregion

  }

}