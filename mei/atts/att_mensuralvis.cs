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
  /// Interface for att.mensural.vis
  /// </summary>
  public interface IAttMensuralVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.mensural.vis
  /// </summary>
  public static class AttMensuralVis_extensions
  {
    #region mensur.color
    
    public static void SetMensurColor(this IAttMensuralVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.color", _val);
    }

    public static XAttribute GetMensurColorAttribute(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.color");
    }

    public static string GetMensurColorValue(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.color");
    }

    public static bool HasMensurColor(this IAttMensuralVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.color");
    }

    public static void RemoveMensurColor(this IAttMensuralVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.color");
    }
    #endregion

    #region mensur.form
    
    public static void SetMensurForm(this IAttMensuralVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.form", _val);
    }

    public static XAttribute GetMensurFormAttribute(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.form");
    }

    public static string GetMensurFormValue(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.form");
    }

    public static bool HasMensurForm(this IAttMensuralVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.form");
    }

    public static void RemoveMensurForm(this IAttMensuralVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.form");
    }
    #endregion

    #region mensur.loc
    
    public static void SetMensurLoc(this IAttMensuralVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.loc", _val);
    }

    public static XAttribute GetMensurLocAttribute(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.loc");
    }

    public static string GetMensurLocValue(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.loc");
    }

    public static bool HasMensurLoc(this IAttMensuralVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.loc");
    }

    public static void RemoveMensurLoc(this IAttMensuralVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.loc");
    }
    #endregion

    #region mensur.orient
    
    public static void SetMensurOrient(this IAttMensuralVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.orient", _val);
    }

    public static XAttribute GetMensurOrientAttribute(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.orient");
    }

    public static string GetMensurOrientValue(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.orient");
    }

    public static bool HasMensurOrient(this IAttMensuralVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.orient");
    }

    public static void RemoveMensurOrient(this IAttMensuralVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.orient");
    }
    #endregion

    #region mensur.size
    
    public static void SetMensurSize(this IAttMensuralVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.size", _val);
    }

    public static XAttribute GetMensurSizeAttribute(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.size");
    }

    public static string GetMensurSizeValue(this IAttMensuralVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.size");
    }

    public static bool HasMensurSize(this IAttMensuralVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.size");
    }

    public static void RemoveMensurSize(this IAttMensuralVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.size");
    }
    #endregion

  }

}