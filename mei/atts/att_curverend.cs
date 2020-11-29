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
  /// Interface for att.curverend
  /// </summary>
  public interface IAttCurverend : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.curverend
  /// </summary>
  public static class AttCurverend_extensions
  {
    #region rend
    
    public static void SetRend(this IAttCurverend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rend", _val);
    }

    public static XAttribute GetRendAttribute(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttribute(e, "rend");
    }

    public static string GetRendValue(this IAttCurverend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "rend");
    }

    public static bool HasRend(this IAttCurverend e)
    {
      return MeiAtt_controller.HasAttribute(e, "rend");
    }

    public static void RemoveRend(this IAttCurverend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rend");
    }
    #endregion

  }

}