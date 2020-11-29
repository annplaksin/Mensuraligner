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
  /// Interface for att.bibl
  /// </summary>
  public interface IAttBibl : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.bibl
  /// </summary>
  public static class AttBibl_extensions
  {
    #region analog
    
    public static void SetAnalog(this IAttBibl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "analog", _val);
    }

    public static XAttribute GetAnalogAttribute(this IAttBibl e)
    {
      return MeiAtt_controller.GetAttribute(e, "analog");
    }

    public static string GetAnalogValue(this IAttBibl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "analog");
    }

    public static bool HasAnalog(this IAttBibl e)
    {
      return MeiAtt_controller.HasAttribute(e, "analog");
    }

    public static void RemoveAnalog(this IAttBibl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "analog");
    }
    #endregion

  }

}