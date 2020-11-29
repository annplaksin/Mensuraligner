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
  /// Interface for att.name
  /// </summary>
  public interface IAttName : IMEiAtt, IAttAuthorized, IAttCanonical
  {

  }


    /// <summary>
  /// Extension methods for att.name
  /// </summary>
  public static class AttName_extensions
  {
    #region nymref
    
    public static void SetNymref(this IAttName e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "nymref", _val);
    }

    public static XAttribute GetNymrefAttribute(this IAttName e)
    {
      return MeiAtt_controller.GetAttribute(e, "nymref");
    }

    public static string GetNymrefValue(this IAttName e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "nymref");
    }

    public static bool HasNymref(this IAttName e)
    {
      return MeiAtt_controller.HasAttribute(e, "nymref");
    }

    public static void RemoveNymref(this IAttName e)
    {
      MeiAtt_controller.RemoveAttribute(e, "nymref");
    }
    #endregion

    #region role
    
    public static void SetRole(this IAttName e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "role", _val);
    }

    public static XAttribute GetRoleAttribute(this IAttName e)
    {
      return MeiAtt_controller.GetAttribute(e, "role");
    }

    public static string GetRoleValue(this IAttName e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "role");
    }

    public static bool HasRole(this IAttName e)
    {
      return MeiAtt_controller.HasAttribute(e, "role");
    }

    public static void RemoveRole(this IAttName e)
    {
      MeiAtt_controller.RemoveAttribute(e, "role");
    }
    #endregion

  }

}