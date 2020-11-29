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
  /// Interface for att.canonical
  /// </summary>
  public interface IAttCanonical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.canonical
  /// </summary>
  public static class AttCanonical_extensions
  {
    #region dbkey
    
    public static void SetDbkey(this IAttCanonical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dbkey", _val);
    }

    public static XAttribute GetDbkeyAttribute(this IAttCanonical e)
    {
      return MeiAtt_controller.GetAttribute(e, "dbkey");
    }

    public static string GetDbkeyValue(this IAttCanonical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dbkey");
    }

    public static bool HasDbkey(this IAttCanonical e)
    {
      return MeiAtt_controller.HasAttribute(e, "dbkey");
    }

    public static void RemoveDbkey(this IAttCanonical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dbkey");
    }
    #endregion

  }

}