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
  /// Interface for att.stems
  /// </summary>
  public interface IAttStems : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.stems
  /// </summary>
  public static class AttStems_extensions
  {
    #region stem.dir
    
    public static void SetStemDir(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.dir", _val);
    }

    public static XAttribute GetStemDirAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.dir");
    }
    
    public static string GetStemDirValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.dir");
    }
    
    public static bool HasStemDir(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.dir");
    }

    public static void RemoveStemDir(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.dir");
    }
    #endregion

    #region stem.len
    
    public static void SetStemLen(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.len", _val);
    }

    public static XAttribute GetStemLenAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.len");
    }
    
    public static string GetStemLenValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.len");
    }
    
    public static bool HasStemLen(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.len");
    }

    public static void RemoveStemLen(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.len");
    }
    #endregion

    #region stem.mod
    
    public static void SetStemMod(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.mod", _val);
    }

    public static XAttribute GetStemModAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.mod");
    }
    
    public static string GetStemModValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.mod");
    }
    
    public static bool HasStemMod(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.mod");
    }

    public static void RemoveStemMod(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.mod");
    }
    #endregion

    #region stem.pos
    
    public static void SetStemPos(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.pos", _val);
    }

    public static XAttribute GetStemPosAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.pos");
    }
    
    public static string GetStemPosValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.pos");
    }
    
    public static bool HasStemPos(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.pos");
    }

    public static void RemoveStemPos(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.pos");
    }
    #endregion

    #region stem.x
    
    public static void SetStemX(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.x", _val);
    }

    public static XAttribute GetStemXAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.x");
    }
    
    public static string GetStemXValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.x");
    }
    
    public static bool HasStemX(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.x");
    }

    public static void RemoveStemX(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.x");
    }
    #endregion

    #region stem.y
    
    public static void SetStemY(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.y", _val);
    }

    public static XAttribute GetStemYAttribute(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.y");
    }
    
    public static string GetStemYValue(this IAttStems e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "stem.y");
    }
    
    public static bool HasStemY(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.y");
    }

    public static void RemoveStemY(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.y");
    }
    #endregion

  }

}