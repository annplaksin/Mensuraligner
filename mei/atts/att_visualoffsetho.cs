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
  /// Interface for att.visualoffset.ho
  /// </summary>
  public interface IAttVisualoffsetHo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset.ho
  /// </summary>
  public static class AttVisualoffsetHo_extensions
  {
    #region ho
    
    public static void SetHo(this IAttVisualoffsetHo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ho", _val);
    }

    public static XAttribute GetHoAttribute(this IAttVisualoffsetHo e)
    {
      return MeiAtt_controller.GetAttribute(e, "ho");
    }

    public static string GetHoValue(this IAttVisualoffsetHo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ho");
    }

    public static bool HasHo(this IAttVisualoffsetHo e)
    {
      return MeiAtt_controller.HasAttribute(e, "ho");
    }

    public static void RemoveHo(this IAttVisualoffsetHo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ho");
    }
    #endregion

  }

}