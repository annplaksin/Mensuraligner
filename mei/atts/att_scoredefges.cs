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
  /// Interface for att.scoreDef.ges
  /// </summary>
  public interface IAttScoreDefGes : IMEiAtt, IAttMmtempo
  {

  }


    /// <summary>
  /// Extension methods for att.scoreDef.ges
  /// </summary>
  public static class AttScoreDefGes_extensions
  {
    #region tune.pname
    
    public static void SetTunePname(this IAttScoreDefGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tune.pname", _val);
    }

    public static XAttribute GetTunePnameAttribute(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "tune.pname");
    }

    public static string GetTunePnameValue(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tune.pname");
    }

    public static bool HasTunePname(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "tune.pname");
    }

    public static void RemoveTunePname(this IAttScoreDefGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tune.pname");
    }
    #endregion

    #region tune.Hz
    
    public static void SetTuneHz(this IAttScoreDefGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tune.Hz", _val);
    }

    public static XAttribute GetTuneHzAttribute(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "tune.Hz");
    }

    public static string GetTuneHzValue(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tune.Hz");
    }

    public static bool HasTuneHz(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "tune.Hz");
    }

    public static void RemoveTuneHz(this IAttScoreDefGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tune.Hz");
    }
    #endregion

    #region tune.temper
    
    public static void SetTuneTemper(this IAttScoreDefGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tune.temper", _val);
    }

    public static XAttribute GetTuneTemperAttribute(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "tune.temper");
    }

    public static string GetTuneTemperValue(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tune.temper");
    }

    public static bool HasTuneTemper(this IAttScoreDefGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "tune.temper");
    }

    public static void RemoveTuneTemper(this IAttScoreDefGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tune.temper");
    }
    #endregion

  }

}