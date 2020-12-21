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
  /// Interface for att.placement
  /// </summary>
  public interface IAttPlacement : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.placement
  /// </summary>
  public static class AttPlacement_extensions
  {
    #region place
    
    public static void SetPlace(this IAttPlacement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "place", _val);
    }

    public static XAttribute GetPlaceAttribute(this IAttPlacement e)
    {
      return MeiAtt_controller.GetAttribute(e, "place");
    }
    
    public static string GetPlaceValue(this IAttPlacement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "place");
    }
    
    public static bool HasPlace(this IAttPlacement e)
    {
      return MeiAtt_controller.HasAttribute(e, "place");
    }

    public static void RemovePlace(this IAttPlacement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "place");
    }
    #endregion

  }

}