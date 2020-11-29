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
  /// Interface for att.slurpresent
  /// </summary>
  public interface IAttSlurpresent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.slurpresent
  /// </summary>
  public static class AttSlurpresent_extensions
  {
    #region slur
    
    public static void SetSlur(this IAttSlurpresent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "slur", _val);
    }

    public static XAttribute GetSlurAttribute(this IAttSlurpresent e)
    {
      return MeiAtt_controller.GetAttribute(e, "slur");
    }

    public static string GetSlurValue(this IAttSlurpresent e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "slur");
    }

    public static bool HasSlur(this IAttSlurpresent e)
    {
      return MeiAtt_controller.HasAttribute(e, "slur");
    }

    public static void RemoveSlur(this IAttSlurpresent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "slur");
    }
    #endregion

  }

}