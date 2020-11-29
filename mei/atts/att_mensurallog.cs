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
  /// Interface for att.mensural.log
  /// </summary>
  public interface IAttMensuralLog : IMEiAtt, IAttMensuralShared
  {

  }


    /// <summary>
  /// Extension methods for att.mensural.log
  /// </summary>
  public static class AttMensuralLog_extensions
  {
    #region mensur.dot
    
    public static void SetMensurDot(this IAttMensuralLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.dot", _val);
    }

    public static XAttribute GetMensurDotAttribute(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.dot");
    }

    public static string GetMensurDotValue(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.dot");
    }

    public static bool HasMensurDot(this IAttMensuralLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.dot");
    }

    public static void RemoveMensurDot(this IAttMensuralLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.dot");
    }
    #endregion

    #region mensur.sign
    
    public static void SetMensurSign(this IAttMensuralLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.sign", _val);
    }

    public static XAttribute GetMensurSignAttribute(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.sign");
    }

    public static string GetMensurSignValue(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.sign");
    }

    public static bool HasMensurSign(this IAttMensuralLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.sign");
    }

    public static void RemoveMensurSign(this IAttMensuralLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.sign");
    }
    #endregion

    #region mensur.slash
    
    public static void SetMensurSlash(this IAttMensuralLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mensur.slash", _val);
    }

    public static XAttribute GetMensurSlashAttribute(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "mensur.slash");
    }

    public static string GetMensurSlashValue(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mensur.slash");
    }

    public static bool HasMensurSlash(this IAttMensuralLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "mensur.slash");
    }

    public static void RemoveMensurSlash(this IAttMensuralLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mensur.slash");
    }
    #endregion

    #region proport.num
    
    public static void SetProportNum(this IAttMensuralLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "proport.num", _val);
    }

    public static XAttribute GetProportNumAttribute(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "proport.num");
    }

    public static string GetProportNumValue(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "proport.num");
    }

    public static bool HasProportNum(this IAttMensuralLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "proport.num");
    }

    public static void RemoveProportNum(this IAttMensuralLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "proport.num");
    }
    #endregion

    #region proport.numbase
    
    public static void SetProportNumbase(this IAttMensuralLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "proport.numbase", _val);
    }

    public static XAttribute GetProportNumbaseAttribute(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "proport.numbase");
    }

    public static string GetProportNumbaseValue(this IAttMensuralLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "proport.numbase");
    }

    public static bool HasProportNumbase(this IAttMensuralLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "proport.numbase");
    }

    public static void RemoveProportNumbase(this IAttMensuralLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "proport.numbase");
    }
    #endregion

  }

}