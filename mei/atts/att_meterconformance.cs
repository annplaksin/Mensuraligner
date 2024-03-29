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

namespace mei
{
    /// <summary>
  /// Interface for att.meterconformance
  /// </summary>
  public interface IAttMeterconformance : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meterconformance
  /// </summary>
  public static class AttMeterconformance_extensions
  {
    #region metcon
    
    public static void SetMetcon(this IAttMeterconformance e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "metcon", _val);
    }

    public static XAttribute GetMetconAttribute(this IAttMeterconformance e)
    {
      return MeiAtt_controller.GetAttribute(e, "metcon");
    }
    
    public static string GetMetconValue(this IAttMeterconformance e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "metcon");
    }
    
    public static bool HasMetcon(this IAttMeterconformance e)
    {
      return MeiAtt_controller.HasAttribute(e, "metcon");
    }

    public static void RemoveMetcon(this IAttMeterconformance e)
    {
      MeiAtt_controller.RemoveAttribute(e, "metcon");
    }
    #endregion

  }

}