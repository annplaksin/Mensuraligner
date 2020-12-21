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
  /// Interface for att.notationstyle
  /// </summary>
  public interface IAttNotationstyle : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.notationstyle
  /// </summary>
  public static class AttNotationstyle_extensions
  {
    #region music.name
    
    public static void SetMusicName(this IAttNotationstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "music.name", _val);
    }

    public static XAttribute GetMusicNameAttribute(this IAttNotationstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "music.name");
    }
    
    public static string GetMusicNameValue(this IAttNotationstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "music.name");
    }
    
    public static bool HasMusicName(this IAttNotationstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "music.name");
    }

    public static void RemoveMusicName(this IAttNotationstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "music.name");
    }
    #endregion

    #region music.size
    
    public static void SetMusicSize(this IAttNotationstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "music.size", _val);
    }

    public static XAttribute GetMusicSizeAttribute(this IAttNotationstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "music.size");
    }
    
    public static string GetMusicSizeValue(this IAttNotationstyle e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "music.size");
    }
    
    public static bool HasMusicSize(this IAttNotationstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "music.size");
    }

    public static void RemoveMusicSize(this IAttNotationstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "music.size");
    }
    #endregion

  }

}