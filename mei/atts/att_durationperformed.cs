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
  /// Interface for att.duration.performed
  /// </summary>
  public interface IAttDurationPerformed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.duration.performed
  /// </summary>
  public static class AttDurationPerformed_extensions
  {
    #region dur.ges
    
    public static void SetDurGes(this IAttDurationPerformed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dur.ges", _val);
    }

    public static XAttribute GetDurGesAttribute(this IAttDurationPerformed e)
    {
      return MeiAtt_controller.GetAttribute(e, "dur.ges");
    }

    public static string GetDurGesValue(this IAttDurationPerformed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dur.ges");
    }

    public static bool HasDurGes(this IAttDurationPerformed e)
    {
      return MeiAtt_controller.HasAttribute(e, "dur.ges");
    }

    public static void RemoveDurGes(this IAttDurationPerformed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dur.ges");
    }
    #endregion

  }

}