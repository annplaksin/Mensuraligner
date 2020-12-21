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
  /// Interface for att.xy
  /// </summary>
  public interface IAttXy : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.xy
  /// </summary>
  public static class AttXy_extensions
  {
    #region x
    
    public static void SetX(this IAttXy e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "x", _val);
    }

    public static XAttribute GetXAttribute(this IAttXy e)
    {
      return MeiAtt_controller.GetAttribute(e, "x");
    }
    
    public static string GetXValue(this IAttXy e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "x");
    }
    
    public static bool HasX(this IAttXy e)
    {
      return MeiAtt_controller.HasAttribute(e, "x");
    }

    public static void RemoveX(this IAttXy e)
    {
      MeiAtt_controller.RemoveAttribute(e, "x");
    }
    #endregion

    #region y
    
    public static void SetY(this IAttXy e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "y", _val);
    }

    public static XAttribute GetYAttribute(this IAttXy e)
    {
      return MeiAtt_controller.GetAttribute(e, "y");
    }
    
    public static string GetYValue(this IAttXy e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "y");
    }
    
    public static bool HasY(this IAttXy e)
    {
      return MeiAtt_controller.HasAttribute(e, "y");
    }

    public static void RemoveY(this IAttXy e)
    {
      MeiAtt_controller.RemoveAttribute(e, "y");
    }
    #endregion

  }

}