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
  /// Interface for att.mensur.log
  /// </summary>
  public interface IAttMensurLog : IMEiAtt, IAttDurationRatio, IAttSlashcount, IAttMensuralShared
  {

  }


    /// <summary>
  /// Extension methods for att.mensur.log
  /// </summary>
  public static class AttMensurLog_extensions
  {
    #region dot
    
    public static void SetDot(this IAttMensurLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dot", _val);
    }

    public static XAttribute GetDotAttribute(this IAttMensurLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "dot");
    }

    public static string GetDotValue(this IAttMensurLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dot");
    }

    public static bool HasDot(this IAttMensurLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "dot");
    }

    public static void RemoveDot(this IAttMensurLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dot");
    }
    #endregion

    #region sign
    
    public static void SetSign(this IAttMensurLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sign", _val);
    }

    public static XAttribute GetSignAttribute(this IAttMensurLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "sign");
    }

    public static string GetSignValue(this IAttMensurLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "sign");
    }

    public static bool HasSign(this IAttMensurLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "sign");
    }

    public static void RemoveSign(this IAttMensurLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sign");
    }
    #endregion

  }

}