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
  /// Interface for att.lyricstype
  /// </summary>
  public interface IAttLyricstype : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lyricstype
  /// </summary>
  public static class AttLyricstype_extensions
  {
    #region lyricType
    private static readonly XNamespace ns_lyricType = "http://github.com/annplaksin/mensural_sourceEncoding";

    public static void SetLyricType(this IAttLyricstype e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyricType", ns_lyricType, _val);
    }

    public static XAttribute GetLyricTypeAttribute(this IAttLyricstype e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyricType", ns_lyricType);
    }

    public static string GetLyricTypeValue(this IAttLyricstype e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lyricType", ns_lyricType);
    }

    public static bool HasLyricType(this IAttLyricstype e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyricType", ns_lyricType);
    }

    public static void RemoveLyricType(this IAttLyricstype e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyricType", ns_lyricType);
    }
    #endregion

  }

}