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
  /// Interface for att.authorized
  /// </summary>
  public interface IAttAuthorized : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.authorized
  /// </summary>
  public static class AttAuthorized_extensions
  {
    #region authority
    
    public static void SetAuthority(this IAttAuthorized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "authority", _val);
    }

    public static XAttribute GetAuthorityAttribute(this IAttAuthorized e)
    {
      return MeiAtt_controller.GetAttribute(e, "authority");
    }

    public static string GetAuthorityValue(this IAttAuthorized e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "authority");
    }

    public static bool HasAuthority(this IAttAuthorized e)
    {
      return MeiAtt_controller.HasAttribute(e, "authority");
    }

    public static void RemoveAuthority(this IAttAuthorized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "authority");
    }
    #endregion

    #region authURI
    
    public static void SetAuthURI(this IAttAuthorized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "authURI", _val);
    }

    public static XAttribute GetAuthURIAttribute(this IAttAuthorized e)
    {
      return MeiAtt_controller.GetAttribute(e, "authURI");
    }

    public static string GetAuthURIValue(this IAttAuthorized e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "authURI");
    }

    public static bool HasAuthURI(this IAttAuthorized e)
    {
      return MeiAtt_controller.HasAttribute(e, "authURI");
    }

    public static void RemoveAuthURI(this IAttAuthorized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "authURI");
    }
    #endregion

  }

}