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
  /// Interface for att.timestamp.performed
  /// </summary>
  public interface IAttTimestampPerformed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.timestamp.performed
  /// </summary>
  public static class AttTimestampPerformed_extensions
  {
    #region tstamp.ges
    
    public static void SetTstampGes(this IAttTimestampPerformed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tstamp.ges", _val);
    }

    public static XAttribute GetTstampGesAttribute(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.GetAttribute(e, "tstamp.ges");
    }

    public static string GetTstampGesValue(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tstamp.ges");
    }

    public static bool HasTstampGes(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.HasAttribute(e, "tstamp.ges");
    }

    public static void RemoveTstampGes(this IAttTimestampPerformed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tstamp.ges");
    }
    #endregion

    #region tstamp.real
    
    public static void SetTstampReal(this IAttTimestampPerformed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tstamp.real", _val);
    }

    public static XAttribute GetTstampRealAttribute(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.GetAttribute(e, "tstamp.real");
    }

    public static string GetTstampRealValue(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tstamp.real");
    }

    public static bool HasTstampReal(this IAttTimestampPerformed e)
    {
      return MeiAtt_controller.HasAttribute(e, "tstamp.real");
    }

    public static void RemoveTstampReal(this IAttTimestampPerformed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tstamp.real");
    }
    #endregion

  }

}