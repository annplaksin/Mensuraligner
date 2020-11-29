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
  /// Interface for att.measurement
  /// </summary>
  public interface IAttMeasurement : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.measurement
  /// </summary>
  public static class AttMeasurement_extensions
  {
    #region unit
    
    public static void SetUnit(this IAttMeasurement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "unit", _val);
    }

    public static XAttribute GetUnitAttribute(this IAttMeasurement e)
    {
      return MeiAtt_controller.GetAttribute(e, "unit");
    }

    public static string GetUnitValue(this IAttMeasurement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "unit");
    }

    public static bool HasUnit(this IAttMeasurement e)
    {
      return MeiAtt_controller.HasAttribute(e, "unit");
    }

    public static void RemoveUnit(this IAttMeasurement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "unit");
    }
    #endregion

  }

}