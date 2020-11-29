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
  /// Interface for att.visibility
  /// </summary>
  public interface IAttVisibility : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visibility
  /// </summary>
  public static class AttVisibility_extensions
  {
    #region visible
    
    public static void SetVisible(this IAttVisibility e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "visible", _val);
    }

    public static XAttribute GetVisibleAttribute(this IAttVisibility e)
    {
      return MeiAtt_controller.GetAttribute(e, "visible");
    }

    public static string GetVisibleValue(this IAttVisibility e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "visible");
    }

    public static bool HasVisible(this IAttVisibility e)
    {
      return MeiAtt_controller.HasAttribute(e, "visible");
    }

    public static void RemoveVisible(this IAttVisibility e)
    {
      MeiAtt_controller.RemoveAttribute(e, "visible");
    }
    #endregion

  }

}