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
  /// Interface for att.verse.log
  /// </summary>
  public interface IAttVerseLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.verse.log
  /// </summary>
  public static class AttVerseLog_extensions
  {
    #region refrain
    
    public static void SetRefrain(this IAttVerseLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "refrain", _val);
    }

    public static XAttribute GetRefrainAttribute(this IAttVerseLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "refrain");
    }

    public static string GetRefrainValue(this IAttVerseLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "refrain");
    }

    public static bool HasRefrain(this IAttVerseLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "refrain");
    }

    public static void RemoveRefrain(this IAttVerseLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "refrain");
    }
    #endregion

    #region rhythm
    
    public static void SetRhythm(this IAttVerseLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rhythm", _val);
    }

    public static XAttribute GetRhythmAttribute(this IAttVerseLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "rhythm");
    }

    public static string GetRhythmValue(this IAttVerseLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "rhythm");
    }

    public static bool HasRhythm(this IAttVerseLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "rhythm");
    }

    public static void RemoveRhythm(this IAttVerseLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rhythm");
    }
    #endregion

  }

}