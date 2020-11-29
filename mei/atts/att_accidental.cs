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
  /// Interface for att.accidental
  /// </summary>
  public interface IAttAccidental : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.accidental
  /// </summary>
  public static class AttAccidental_extensions
  {
    #region accid
    
    public static void SetAccid(this IAttAccidental e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "accid", _val);
    }

    public static XAttribute GetAccidAttribute(this IAttAccidental e)
    {
      return MeiAtt_controller.GetAttribute(e, "accid");
    }

    public static string GetAccidValue(this IAttAccidental e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "accid");
    }

    public static bool HasAccid(this IAttAccidental e)
    {
      return MeiAtt_controller.HasAttribute(e, "accid");
    }

    public static void RemoveAccid(this IAttAccidental e)
    {
      MeiAtt_controller.RemoveAttribute(e, "accid");
    }
    #endregion

  }

}