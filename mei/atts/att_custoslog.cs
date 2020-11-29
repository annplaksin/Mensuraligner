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
  /// Interface for att.custos.log
  /// </summary>
  public interface IAttCustosLog : IMEiAtt, IAttPitched
  {

  }


    /// <summary>
  /// Extension methods for att.custos.log
  /// </summary>
  public static class AttCustosLog_extensions
  {
    #region target
    
    public static void SetTarget(this IAttCustosLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "target", _val);
    }

    public static XAttribute GetTargetAttribute(this IAttCustosLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "target");
    }

    public static string GetTargetValue(this IAttCustosLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "target");
    }

    public static bool HasTarget(this IAttCustosLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "target");
    }

    public static void RemoveTarget(this IAttCustosLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "target");
    }
    #endregion

  }

}