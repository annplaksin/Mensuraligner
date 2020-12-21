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
  /// Interface for att.targeteval
  /// </summary>
  public interface IAttTargeteval : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.targeteval
  /// </summary>
  public static class AttTargeteval_extensions
  {
    #region evaluate
    
    public static void SetEvaluate(this IAttTargeteval e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "evaluate", _val);
    }

    public static XAttribute GetEvaluateAttribute(this IAttTargeteval e)
    {
      return MeiAtt_controller.GetAttribute(e, "evaluate");
    }
    
    public static string GetEvaluateValue(this IAttTargeteval e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "evaluate");
    }
    
    public static bool HasEvaluate(this IAttTargeteval e)
    {
      return MeiAtt_controller.HasAttribute(e, "evaluate");
    }

    public static void RemoveEvaluate(this IAttTargeteval e)
    {
      MeiAtt_controller.RemoveAttribute(e, "evaluate");
    }
    #endregion

  }

}