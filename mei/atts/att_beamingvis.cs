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
  /// Interface for att.beaming.vis
  /// </summary>
  public interface IAttBeamingVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.beaming.vis
  /// </summary>
  public static class AttBeamingVis_extensions
  {
    #region beam.color
    
    public static void SetBeamColor(this IAttBeamingVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam.color", _val);
    }

    public static XAttribute GetBeamColorAttribute(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam.color");
    }

    public static string GetBeamColorValue(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "beam.color");
    }

    public static bool HasBeamColor(this IAttBeamingVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam.color");
    }

    public static void RemoveBeamColor(this IAttBeamingVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam.color");
    }
    #endregion

    #region beam.rend
    
    public static void SetBeamRend(this IAttBeamingVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam.rend", _val);
    }

    public static XAttribute GetBeamRendAttribute(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam.rend");
    }

    public static string GetBeamRendValue(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "beam.rend");
    }

    public static bool HasBeamRend(this IAttBeamingVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam.rend");
    }

    public static void RemoveBeamRend(this IAttBeamingVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam.rend");
    }
    #endregion

    #region beam.slope
    
    public static void SetBeamSlope(this IAttBeamingVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam.slope", _val);
    }

    public static XAttribute GetBeamSlopeAttribute(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam.slope");
    }

    public static string GetBeamSlopeValue(this IAttBeamingVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "beam.slope");
    }

    public static bool HasBeamSlope(this IAttBeamingVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam.slope");
    }

    public static void RemoveBeamSlope(this IAttBeamingVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam.slope");
    }
    #endregion

  }

}