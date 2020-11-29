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
  /// Interface for att.proport.log
  /// </summary>
  public interface IAttProportLog : IMEiAtt, IAttDurationRatio
  {

  }


    /// <summary>
  /// Extension methods for att.proport.log
  /// </summary>
  public static class AttProportLog_extensions
  {
    #region affected
    private static readonly XNamespace ns_affected = "http://github.com/annplaksin/mensural_sourceEncoding";

    public static void SetAffected(this IAttProportLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "affected", ns_affected, _val);
    }

    public static XAttribute GetAffectedAttribute(this IAttProportLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "affected", ns_affected);
    }

    public static string GetAffectedValue(this IAttProportLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "affected", ns_affected);
    }

    public static bool HasAffected(this IAttProportLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "affected", ns_affected);
    }

    public static void RemoveAffected(this IAttProportLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "affected", ns_affected);
    }
    #endregion

  }

}