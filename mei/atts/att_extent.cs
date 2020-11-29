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
  /// Interface for att.extent
  /// </summary>
  public interface IAttExtent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.extent
  /// </summary>
  public static class AttExtent_extensions
  {
    #region extent
    
    public static void SetExtent(this IAttExtent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "extent", _val);
    }

    public static XAttribute GetExtentAttribute(this IAttExtent e)
    {
      return MeiAtt_controller.GetAttribute(e, "extent");
    }

    public static string GetExtentValue(this IAttExtent e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "extent");
    }

    public static bool HasExtent(this IAttExtent e)
    {
      return MeiAtt_controller.HasAttribute(e, "extent");
    }

    public static void RemoveExtent(this IAttExtent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "extent");
    }
    #endregion

  }

}