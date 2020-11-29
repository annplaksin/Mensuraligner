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
  /// Interface for att.lineloc
  /// </summary>
  public interface IAttLineloc : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lineloc
  /// </summary>
  public static class AttLineloc_extensions
  {
    #region line
    
    public static void SetLine(this IAttLineloc e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "line", _val);
    }

    public static XAttribute GetLineAttribute(this IAttLineloc e)
    {
      return MeiAtt_controller.GetAttribute(e, "line");
    }

    public static string GetLineValue(this IAttLineloc e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "line");
    }

    public static bool HasLine(this IAttLineloc e)
    {
      return MeiAtt_controller.HasAttribute(e, "line");
    }

    public static void RemoveLine(this IAttLineloc e)
    {
      MeiAtt_controller.RemoveAttribute(e, "line");
    }
    #endregion

  }

}