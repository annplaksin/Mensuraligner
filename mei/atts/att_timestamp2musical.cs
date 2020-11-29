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
  /// Interface for att.timestamp2.musical
  /// </summary>
  public interface IAttTimestamp2Musical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.timestamp2.musical
  /// </summary>
  public static class AttTimestamp2Musical_extensions
  {
    #region tstamp2
    
    public static void SetTstamp2(this IAttTimestamp2Musical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tstamp2", _val);
    }

    public static XAttribute GetTstamp2Attribute(this IAttTimestamp2Musical e)
    {
      return MeiAtt_controller.GetAttribute(e, "tstamp2");
    }

    public static string GetTstamp2Value(this IAttTimestamp2Musical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tstamp2");
    }

    public static bool HasTstamp2(this IAttTimestamp2Musical e)
    {
      return MeiAtt_controller.HasAttribute(e, "tstamp2");
    }

    public static void RemoveTstamp2(this IAttTimestamp2Musical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tstamp2");
    }
    #endregion

  }

}