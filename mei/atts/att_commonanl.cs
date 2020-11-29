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
  /// Interface for att.common.anl
  /// </summary>
  public interface IAttCommonAnl : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.common.anl
  /// </summary>
  public static class AttCommonAnl_extensions
  {
    #region copyof
    
    public static void SetCopyof(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "copyof", _val);
    }

    public static XAttribute GetCopyofAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "copyof");
    }

    public static string GetCopyofValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "copyof");
    }

    public static bool HasCopyof(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "copyof");
    }

    public static void RemoveCopyof(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "copyof");
    }
    #endregion

    #region corresp
    
    public static void SetCorresp(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "corresp", _val);
    }

    public static XAttribute GetCorrespAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "corresp");
    }

    public static string GetCorrespValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "corresp");
    }

    public static bool HasCorresp(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "corresp");
    }

    public static void RemoveCorresp(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "corresp");
    }
    #endregion

    #region next
    
    public static void SetNext(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "next", _val);
    }

    public static XAttribute GetNextAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "next");
    }

    public static string GetNextValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "next");
    }

    public static bool HasNext(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "next");
    }

    public static void RemoveNext(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "next");
    }
    #endregion

    #region prev
    
    public static void SetPrev(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "prev", _val);
    }

    public static XAttribute GetPrevAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "prev");
    }

    public static string GetPrevValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "prev");
    }

    public static bool HasPrev(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "prev");
    }

    public static void RemovePrev(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "prev");
    }
    #endregion

    #region sameas
    
    public static void SetSameas(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sameas", _val);
    }

    public static XAttribute GetSameasAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "sameas");
    }

    public static string GetSameasValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "sameas");
    }

    public static bool HasSameas(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "sameas");
    }

    public static void RemoveSameas(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sameas");
    }
    #endregion

    #region synch
    
    public static void SetSynch(this IAttCommonAnl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "synch", _val);
    }

    public static XAttribute GetSynchAttribute(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttribute(e, "synch");
    }

    public static string GetSynchValue(this IAttCommonAnl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "synch");
    }

    public static bool HasSynch(this IAttCommonAnl e)
    {
      return MeiAtt_controller.HasAttribute(e, "synch");
    }

    public static void RemoveSynch(this IAttCommonAnl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "synch");
    }
    #endregion

  }

}