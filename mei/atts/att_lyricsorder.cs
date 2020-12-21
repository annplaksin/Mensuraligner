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
  /// Interface for att.lyricsorder
  /// </summary>
  public interface IAttLyricsorder : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lyricsorder
  /// </summary>
  public static class AttLyricsorder_extensions
  {
    #region row
    private static readonly XNamespace ns_row = "http://github.com/annplaksin/mensural_sourceEncoding";

    public static void SetRow(this IAttLyricsorder e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "row", ns_row, _val);
    }

    public static XAttribute GetRowAttribute(this IAttLyricsorder e)
    {
      return MeiAtt_controller.GetAttribute(e, "row", ns_row);
    }
    
    public static string GetRowValue(this IAttLyricsorder e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "row", ns_row);
    }
    
    public static bool HasRow(this IAttLyricsorder e)
    {
      return MeiAtt_controller.HasAttribute(e, "row", ns_row);
    }

    public static void RemoveRow(this IAttLyricsorder e)
    {
      MeiAtt_controller.RemoveAttribute(e, "row", ns_row);
    }
    #endregion

  }

}