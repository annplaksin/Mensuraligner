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
  /// Interface for att.relativesize
  /// </summary>
  public interface IAttRelativesize : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.relativesize
  /// </summary>
  public static class AttRelativesize_extensions
  {
    #region size
    
    public static void SetSize(this IAttRelativesize e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "size", _val);
    }

    public static XAttribute GetSizeAttribute(this IAttRelativesize e)
    {
      return MeiAtt_controller.GetAttribute(e, "size");
    }

    public static string GetSizeValue(this IAttRelativesize e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "size");
    }

    public static bool HasSize(this IAttRelativesize e)
    {
      return MeiAtt_controller.HasAttribute(e, "size");
    }

    public static void RemoveSize(this IAttRelativesize e)
    {
      MeiAtt_controller.RemoveAttribute(e, "size");
    }
    #endregion

  }

}