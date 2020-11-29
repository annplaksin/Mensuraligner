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
  /// Interface for att.curvature
  /// </summary>
  public interface IAttCurvature : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.curvature
  /// </summary>
  public static class AttCurvature_extensions
  {
    #region bezier
    
    public static void SetBezier(this IAttCurvature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "bezier", _val);
    }

    public static XAttribute GetBezierAttribute(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttribute(e, "bezier");
    }

    public static string GetBezierValue(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "bezier");
    }

    public static bool HasBezier(this IAttCurvature e)
    {
      return MeiAtt_controller.HasAttribute(e, "bezier");
    }

    public static void RemoveBezier(this IAttCurvature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "bezier");
    }
    #endregion

    #region bulge
    
    public static void SetBulge(this IAttCurvature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "bulge", _val);
    }

    public static XAttribute GetBulgeAttribute(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttribute(e, "bulge");
    }

    public static string GetBulgeValue(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "bulge");
    }

    public static bool HasBulge(this IAttCurvature e)
    {
      return MeiAtt_controller.HasAttribute(e, "bulge");
    }

    public static void RemoveBulge(this IAttCurvature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "bulge");
    }
    #endregion

    #region curvedir
    
    public static void SetCurvedir(this IAttCurvature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "curvedir", _val);
    }

    public static XAttribute GetCurvedirAttribute(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttribute(e, "curvedir");
    }

    public static string GetCurvedirValue(this IAttCurvature e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "curvedir");
    }

    public static bool HasCurvedir(this IAttCurvature e)
    {
      return MeiAtt_controller.HasAttribute(e, "curvedir");
    }

    public static void RemoveCurvedir(this IAttCurvature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "curvedir");
    }
    #endregion

  }

}