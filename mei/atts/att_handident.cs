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
  /// Interface for att.handident
  /// </summary>
  public interface IAttHandident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.handident
  /// </summary>
  public static class AttHandident_extensions
  {
    #region hand
    
    public static void SetHand(this IAttHandident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "hand", _val);
    }

    public static XAttribute GetHandAttribute(this IAttHandident e)
    {
      return MeiAtt_controller.GetAttribute(e, "hand");
    }

    public static string GetHandValue(this IAttHandident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "hand");
    }

    public static bool HasHand(this IAttHandident e)
    {
      return MeiAtt_controller.HasAttribute(e, "hand");
    }

    public static void RemoveHand(this IAttHandident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "hand");
    }
    #endregion

  }

}