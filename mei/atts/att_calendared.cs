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
  /// Interface for att.calendared
  /// </summary>
  public interface IAttCalendared : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.calendared
  /// </summary>
  public static class AttCalendared_extensions
  {
    #region calendar
    
    public static void SetCalendar(this IAttCalendared e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "calendar", _val);
    }

    public static XAttribute GetCalendarAttribute(this IAttCalendared e)
    {
      return MeiAtt_controller.GetAttribute(e, "calendar");
    }

    public static string GetCalendarValue(this IAttCalendared e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "calendar");
    }

    public static bool HasCalendar(this IAttCalendared e)
    {
      return MeiAtt_controller.HasAttribute(e, "calendar");
    }

    public static void RemoveCalendar(this IAttCalendared e)
    {
      MeiAtt_controller.RemoveAttribute(e, "calendar");
    }
    #endregion

  }

}