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

namespace mei
{
    /// <summary>
  /// Interface for att.plist
  /// </summary>
  public interface IAttPlist : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.plist
  /// </summary>
  public static class AttPlist_extensions
  {
    #region plist
    
    public static void SetPlist(this IAttPlist e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "plist", _val);
    }

    public static XAttribute GetPlistAttribute(this IAttPlist e)
    {
      return MeiAtt_controller.GetAttribute(e, "plist");
    }
    
    public static string GetPlistValue(this IAttPlist e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "plist");
    }
    
    public static bool HasPlist(this IAttPlist e)
    {
      return MeiAtt_controller.HasAttribute(e, "plist");
    }

    public static void RemovePlist(this IAttPlist e)
    {
      MeiAtt_controller.RemoveAttribute(e, "plist");
    }
    #endregion

  }

}