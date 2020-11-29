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
  /// Interface for att.sb.vis
  /// </summary>
  public interface IAttSbVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.sb.vis
  /// </summary>
  public static class AttSbVis_extensions
  {
    #region rend
    
    public static void SetRend(this IAttSbVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rend", _val);
    }

    public static XAttribute GetRendAttribute(this IAttSbVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "rend");
    }

    public static string GetRendValue(this IAttSbVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "rend");
    }

    public static bool HasRend(this IAttSbVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "rend");
    }

    public static void RemoveRend(this IAttSbVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rend");
    }
    #endregion

  }

}