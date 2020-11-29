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
  /// Interface for att.stemmed
  /// </summary>
  public interface IAttStemmed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.stemmed
  /// </summary>
  public static class AttStemmed_extensions
  {
    #region stem.dir
    
    public static void SetStemDir(this IAttStemmed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.dir", _val);
    }

    public static XAttribute GetStemDirAttribute(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.dir");
    }

    public static string GetStemDirValue(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.dir");
    }

    public static bool HasStemDir(this IAttStemmed e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.dir");
    }

    public static void RemoveStemDir(this IAttStemmed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.dir");
    }
    #endregion

    #region stem.len
    
    public static void SetStemLen(this IAttStemmed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.len", _val);
    }

    public static XAttribute GetStemLenAttribute(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.len");
    }

    public static string GetStemLenValue(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.len");
    }

    public static bool HasStemLen(this IAttStemmed e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.len");
    }

    public static void RemoveStemLen(this IAttStemmed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.len");
    }
    #endregion

    #region stem.pos
    
    public static void SetStemPos(this IAttStemmed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.pos", _val);
    }

    public static XAttribute GetStemPosAttribute(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.pos");
    }

    public static string GetStemPosValue(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.pos");
    }

    public static bool HasStemPos(this IAttStemmed e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.pos");
    }

    public static void RemoveStemPos(this IAttStemmed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.pos");
    }
    #endregion

    #region stem.x
    
    public static void SetStemX(this IAttStemmed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.x", _val);
    }

    public static XAttribute GetStemXAttribute(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.x");
    }

    public static string GetStemXValue(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.x");
    }

    public static bool HasStemX(this IAttStemmed e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.x");
    }

    public static void RemoveStemX(this IAttStemmed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.x");
    }
    #endregion

    #region stem.y
    
    public static void SetStemY(this IAttStemmed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.y", _val);
    }

    public static XAttribute GetStemYAttribute(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.y");
    }

    public static string GetStemYValue(this IAttStemmed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.y");
    }

    public static bool HasStemY(this IAttStemmed e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.y");
    }

    public static void RemoveStemY(this IAttStemmed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.y");
    }
    #endregion

  }

}