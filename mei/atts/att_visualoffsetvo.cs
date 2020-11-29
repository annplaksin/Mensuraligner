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
  /// Interface for att.visualoffset.vo
  /// </summary>
  public interface IAttVisualoffsetVo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset.vo
  /// </summary>
  public static class AttVisualoffsetVo_extensions
  {
    #region vo
    
    public static void SetVo(this IAttVisualoffsetVo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "vo", _val);
    }

    public static XAttribute GetVoAttribute(this IAttVisualoffsetVo e)
    {
      return MeiAtt_controller.GetAttribute(e, "vo");
    }

    public static string GetVoValue(this IAttVisualoffsetVo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "vo");
    }

    public static bool HasVo(this IAttVisualoffsetVo e)
    {
      return MeiAtt_controller.HasAttribute(e, "vo");
    }

    public static void RemoveVo(this IAttVisualoffsetVo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "vo");
    }
    #endregion

  }

}