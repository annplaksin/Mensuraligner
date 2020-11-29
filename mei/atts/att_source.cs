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
  /// Interface for att.source
  /// </summary>
  public interface IAttSource : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.source
  /// </summary>
  public static class AttSource_extensions
  {
    #region source
    
    public static void SetSource(this IAttSource e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "source", _val);
    }

    public static XAttribute GetSourceAttribute(this IAttSource e)
    {
      return MeiAtt_controller.GetAttribute(e, "source");
    }

    public static string GetSourceValue(this IAttSource e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "source");
    }

    public static bool HasSource(this IAttSource e)
    {
      return MeiAtt_controller.HasAttribute(e, "source");
    }

    public static void RemoveSource(this IAttSource e)
    {
      MeiAtt_controller.RemoveAttribute(e, "source");
    }
    #endregion

  }

}