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
  /// Interface for att.medium
  /// </summary>
  public interface IAttMedium : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.medium
  /// </summary>
  public static class AttMedium_extensions
  {
    #region medium
    
    public static void SetMedium(this IAttMedium e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "medium", _val);
    }

    public static XAttribute GetMediumAttribute(this IAttMedium e)
    {
      return MeiAtt_controller.GetAttribute(e, "medium");
    }

    public static string GetMediumValue(this IAttMedium e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "medium");
    }

    public static bool HasMedium(this IAttMedium e)
    {
      return MeiAtt_controller.HasAttribute(e, "medium");
    }

    public static void RemoveMedium(this IAttMedium e)
    {
      MeiAtt_controller.RemoveAttribute(e, "medium");
    }
    #endregion

  }

}