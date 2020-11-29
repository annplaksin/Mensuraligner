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
  /// Interface for att.duration.default
  /// </summary>
  public interface IAttDurationDefault : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.duration.default
  /// </summary>
  public static class AttDurationDefault_extensions
  {
    #region dur.default
    
    public static void SetDurDefault(this IAttDurationDefault e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dur.default", _val);
    }

    public static XAttribute GetDurDefaultAttribute(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttribute(e, "dur.default");
    }

    public static string GetDurDefaultValue(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dur.default");
    }

    public static bool HasDurDefault(this IAttDurationDefault e)
    {
      return MeiAtt_controller.HasAttribute(e, "dur.default");
    }

    public static void RemoveDurDefault(this IAttDurationDefault e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dur.default");
    }
    #endregion

    #region num.default
    
    public static void SetNumDefault(this IAttDurationDefault e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "num.default", _val);
    }

    public static XAttribute GetNumDefaultAttribute(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttribute(e, "num.default");
    }

    public static string GetNumDefaultValue(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "num.default");
    }

    public static bool HasNumDefault(this IAttDurationDefault e)
    {
      return MeiAtt_controller.HasAttribute(e, "num.default");
    }

    public static void RemoveNumDefault(this IAttDurationDefault e)
    {
      MeiAtt_controller.RemoveAttribute(e, "num.default");
    }
    #endregion

    #region numbase.default
    
    public static void SetNumbaseDefault(this IAttDurationDefault e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "numbase.default", _val);
    }

    public static XAttribute GetNumbaseDefaultAttribute(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttribute(e, "numbase.default");
    }

    public static string GetNumbaseDefaultValue(this IAttDurationDefault e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "numbase.default");
    }

    public static bool HasNumbaseDefault(this IAttDurationDefault e)
    {
      return MeiAtt_controller.HasAttribute(e, "numbase.default");
    }

    public static void RemoveNumbaseDefault(this IAttDurationDefault e)
    {
      MeiAtt_controller.RemoveAttribute(e, "numbase.default");
    }
    #endregion

  }

}