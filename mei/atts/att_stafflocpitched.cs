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
  /// Interface for att.staffloc.pitched
  /// </summary>
  public interface IAttStafflocPitched : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.staffloc.pitched
  /// </summary>
  public static class AttStafflocPitched_extensions
  {
    #region ploc
    
    public static void SetPloc(this IAttStafflocPitched e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ploc", _val);
    }

    public static XAttribute GetPlocAttribute(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.GetAttribute(e, "ploc");
    }

    public static string GetPlocValue(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ploc");
    }

    public static bool HasPloc(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.HasAttribute(e, "ploc");
    }

    public static void RemovePloc(this IAttStafflocPitched e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ploc");
    }
    #endregion

    #region oloc
    
    public static void SetOloc(this IAttStafflocPitched e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "oloc", _val);
    }

    public static XAttribute GetOlocAttribute(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.GetAttribute(e, "oloc");
    }

    public static string GetOlocValue(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "oloc");
    }

    public static bool HasOloc(this IAttStafflocPitched e)
    {
      return MeiAtt_controller.HasAttribute(e, "oloc");
    }

    public static void RemoveOloc(this IAttStafflocPitched e)
    {
      MeiAtt_controller.RemoveAttribute(e, "oloc");
    }
    #endregion

  }

}