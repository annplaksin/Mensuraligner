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
  /// Interface for att.slashcount
  /// </summary>
  public interface IAttSlashcount : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.slashcount
  /// </summary>
  public static class AttSlashcount_extensions
  {
    #region slash
    
    public static void SetSlash(this IAttSlashcount e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "slash", _val);
    }

    public static XAttribute GetSlashAttribute(this IAttSlashcount e)
    {
      return MeiAtt_controller.GetAttribute(e, "slash");
    }

    public static string GetSlashValue(this IAttSlashcount e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "slash");
    }

    public static bool HasSlash(this IAttSlashcount e)
    {
      return MeiAtt_controller.HasAttribute(e, "slash");
    }

    public static void RemoveSlash(this IAttSlashcount e)
    {
      MeiAtt_controller.RemoveAttribute(e, "slash");
    }
    #endregion

  }

}