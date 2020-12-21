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
  /// Interface for att.optimization
  /// </summary>
  public interface IAttOptimization : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.optimization
  /// </summary>
  public static class AttOptimization_extensions
  {
    #region optimize
    
    public static void SetOptimize(this IAttOptimization e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "optimize", _val);
    }

    public static XAttribute GetOptimizeAttribute(this IAttOptimization e)
    {
      return MeiAtt_controller.GetAttribute(e, "optimize");
    }
    
    public static string GetOptimizeValue(this IAttOptimization e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "optimize");
    }
    
    public static bool HasOptimize(this IAttOptimization e)
    {
      return MeiAtt_controller.HasAttribute(e, "optimize");
    }

    public static void RemoveOptimize(this IAttOptimization e)
    {
      MeiAtt_controller.RemoveAttribute(e, "optimize");
    }
    #endregion

  }

}