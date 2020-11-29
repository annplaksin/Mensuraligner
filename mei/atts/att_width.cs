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
  /// Interface for att.width
  /// </summary>
  public interface IAttWidth : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.width
  /// </summary>
  public static class AttWidth_extensions
  {
    #region width
    
    public static void SetWidth(this IAttWidth e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "width", _val);
    }

    public static XAttribute GetWidthAttribute(this IAttWidth e)
    {
      return MeiAtt_controller.GetAttribute(e, "width");
    }

    public static string GetWidthValue(this IAttWidth e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "width");
    }

    public static bool HasWidth(this IAttWidth e)
    {
      return MeiAtt_controller.HasAttribute(e, "width");
    }

    public static void RemoveWidth(this IAttWidth e)
    {
      MeiAtt_controller.RemoveAttribute(e, "width");
    }
    #endregion

  }

}