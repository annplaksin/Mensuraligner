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
  /// Interface for att.syl.log
  /// </summary>
  public interface IAttSylLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.syl.log
  /// </summary>
  public static class AttSylLog_extensions
  {
    #region con
    
    public static void SetCon(this IAttSylLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "con", _val);
    }

    public static XAttribute GetConAttribute(this IAttSylLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "con");
    }

    public static string GetConValue(this IAttSylLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "con");
    }

    public static bool HasCon(this IAttSylLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "con");
    }

    public static void RemoveCon(this IAttSylLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "con");
    }
    #endregion

    #region wordpos
    
    public static void SetWordpos(this IAttSylLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "wordpos", _val);
    }

    public static XAttribute GetWordposAttribute(this IAttSylLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "wordpos");
    }

    public static string GetWordposValue(this IAttSylLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "wordpos");
    }

    public static bool HasWordpos(this IAttSylLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "wordpos");
    }

    public static void RemoveWordpos(this IAttSylLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "wordpos");
    }
    #endregion

  }

}