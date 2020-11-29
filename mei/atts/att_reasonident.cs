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
  /// Interface for att.reasonident
  /// </summary>
  public interface IAttReasonident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.reasonident
  /// </summary>
  public static class AttReasonident_extensions
  {
    #region reason
    
    public static void SetReason(this IAttReasonident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "reason", _val);
    }

    public static XAttribute GetReasonAttribute(this IAttReasonident e)
    {
      return MeiAtt_controller.GetAttribute(e, "reason");
    }

    public static string GetReasonValue(this IAttReasonident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "reason");
    }

    public static bool HasReason(this IAttReasonident e)
    {
      return MeiAtt_controller.HasAttribute(e, "reason");
    }

    public static void RemoveReason(this IAttReasonident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "reason");
    }
    #endregion

  }

}