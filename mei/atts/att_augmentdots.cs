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
  /// Interface for att.augmentdots
  /// </summary>
  public interface IAttAugmentdots : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.augmentdots
  /// </summary>
  public static class AttAugmentdots_extensions
  {
    #region dots
    
    public static void SetDots(this IAttAugmentdots e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dots", _val);
    }

    public static XAttribute GetDotsAttribute(this IAttAugmentdots e)
    {
      return MeiAtt_controller.GetAttribute(e, "dots");
    }
    
    public static string GetDotsValue(this IAttAugmentdots e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dots");
    }
    
    public static bool HasDots(this IAttAugmentdots e)
    {
      return MeiAtt_controller.HasAttribute(e, "dots");
    }

    public static void RemoveDots(this IAttAugmentdots e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dots");
    }
    #endregion

  }

}