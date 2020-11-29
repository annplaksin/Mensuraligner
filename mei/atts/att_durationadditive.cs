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
  /// Interface for att.duration.additive
  /// </summary>
  public interface IAttDurationAdditive : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.duration.additive
  /// </summary>
  public static class AttDurationAdditive_extensions
  {
    #region dur
    
    public static void SetDur(this IAttDurationAdditive e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dur", _val);
    }

    public static XAttribute GetDurAttribute(this IAttDurationAdditive e)
    {
      return MeiAtt_controller.GetAttribute(e, "dur");
    }

    public static string GetDurValue(this IAttDurationAdditive e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dur");
    }

    public static bool HasDur(this IAttDurationAdditive e)
    {
      return MeiAtt_controller.HasAttribute(e, "dur");
    }

    public static void RemoveDur(this IAttDurationAdditive e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dur");
    }
    #endregion

  }

}