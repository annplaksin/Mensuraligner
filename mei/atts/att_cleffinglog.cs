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
  /// Interface for att.cleffing.log
  /// </summary>
  public interface IAttCleffingLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.cleffing.log
  /// </summary>
  public static class AttCleffingLog_extensions
  {
    #region clef.shape
    
    public static void SetClefShape(this IAttCleffingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.shape", _val);
    }

    public static XAttribute GetClefShapeAttribute(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.shape");
    }

    public static string GetClefShapeValue(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.shape");
    }

    public static bool HasClefShape(this IAttCleffingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.shape");
    }

    public static void RemoveClefShape(this IAttCleffingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.shape");
    }
    #endregion

    #region clef.line
    
    public static void SetClefLine(this IAttCleffingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.line", _val);
    }

    public static XAttribute GetClefLineAttribute(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.line");
    }

    public static string GetClefLineValue(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.line");
    }

    public static bool HasClefLine(this IAttCleffingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.line");
    }

    public static void RemoveClefLine(this IAttCleffingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.line");
    }
    #endregion

    #region clef.dis
    
    public static void SetClefDis(this IAttCleffingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.dis", _val);
    }

    public static XAttribute GetClefDisAttribute(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.dis");
    }

    public static string GetClefDisValue(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.dis");
    }

    public static bool HasClefDis(this IAttCleffingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.dis");
    }

    public static void RemoveClefDis(this IAttCleffingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.dis");
    }
    #endregion

    #region clef.dis.place
    
    public static void SetClefDisPlace(this IAttCleffingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "clef.dis.place", _val);
    }

    public static XAttribute GetClefDisPlaceAttribute(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "clef.dis.place");
    }

    public static string GetClefDisPlaceValue(this IAttCleffingLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "clef.dis.place");
    }

    public static bool HasClefDisPlace(this IAttCleffingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "clef.dis.place");
    }

    public static void RemoveClefDisPlace(this IAttCleffingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "clef.dis.place");
    }
    #endregion

  }

}