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
  /// Interface for att.scalable
  /// </summary>
  public interface IAttScalable : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.scalable
  /// </summary>
  public static class AttScalable_extensions
  {
    #region scale
    
    public static void SetScale(this IAttScalable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "scale", _val);
    }

    public static XAttribute GetScaleAttribute(this IAttScalable e)
    {
      return MeiAtt_controller.GetAttribute(e, "scale");
    }
    
    public static string GetScaleValue(this IAttScalable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "scale");
    }
    
    public static bool HasScale(this IAttScalable e)
    {
      return MeiAtt_controller.HasAttribute(e, "scale");
    }

    public static void RemoveScale(this IAttScalable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "scale");
    }
    #endregion

  }

}