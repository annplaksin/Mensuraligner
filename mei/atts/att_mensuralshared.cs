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
  /// Interface for att.mensural.shared
  /// </summary>
  public interface IAttMensuralShared : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.mensural.shared
  /// </summary>
  public static class AttMensuralShared_extensions
  {
    #region modusmaior
    
    public static void SetModusmaior(this IAttMensuralShared e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "modusmaior", _val);
    }

    public static XAttribute GetModusmaiorAttribute(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttribute(e, "modusmaior");
    }

    public static string GetModusmaiorValue(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "modusmaior");
    }

    public static bool HasModusmaior(this IAttMensuralShared e)
    {
      return MeiAtt_controller.HasAttribute(e, "modusmaior");
    }

    public static void RemoveModusmaior(this IAttMensuralShared e)
    {
      MeiAtt_controller.RemoveAttribute(e, "modusmaior");
    }
    #endregion

    #region modusminor
    
    public static void SetModusminor(this IAttMensuralShared e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "modusminor", _val);
    }

    public static XAttribute GetModusminorAttribute(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttribute(e, "modusminor");
    }

    public static string GetModusminorValue(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "modusminor");
    }

    public static bool HasModusminor(this IAttMensuralShared e)
    {
      return MeiAtt_controller.HasAttribute(e, "modusminor");
    }

    public static void RemoveModusminor(this IAttMensuralShared e)
    {
      MeiAtt_controller.RemoveAttribute(e, "modusminor");
    }
    #endregion

    #region prolatio
    
    public static void SetProlatio(this IAttMensuralShared e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "prolatio", _val);
    }

    public static XAttribute GetProlatioAttribute(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttribute(e, "prolatio");
    }

    public static string GetProlatioValue(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "prolatio");
    }

    public static bool HasProlatio(this IAttMensuralShared e)
    {
      return MeiAtt_controller.HasAttribute(e, "prolatio");
    }

    public static void RemoveProlatio(this IAttMensuralShared e)
    {
      MeiAtt_controller.RemoveAttribute(e, "prolatio");
    }
    #endregion

    #region tempus
    
    public static void SetTempus(this IAttMensuralShared e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tempus", _val);
    }

    public static XAttribute GetTempusAttribute(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttribute(e, "tempus");
    }

    public static string GetTempusValue(this IAttMensuralShared e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tempus");
    }

    public static bool HasTempus(this IAttMensuralShared e)
    {
      return MeiAtt_controller.HasAttribute(e, "tempus");
    }

    public static void RemoveTempus(this IAttMensuralShared e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tempus");
    }
    #endregion

  }

}