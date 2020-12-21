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
  /// Interface for att.octavedisplacement
  /// </summary>
  public interface IAttOctavedisplacement : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.octavedisplacement
  /// </summary>
  public static class AttOctavedisplacement_extensions
  {
    #region dis
    
    public static void SetDis(this IAttOctavedisplacement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dis", _val);
    }

    public static XAttribute GetDisAttribute(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.GetAttribute(e, "dis");
    }
    
    public static string GetDisValue(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dis");
    }
    
    public static bool HasDis(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.HasAttribute(e, "dis");
    }

    public static void RemoveDis(this IAttOctavedisplacement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dis");
    }
    #endregion

    #region dis.place
    
    public static void SetDisPlace(this IAttOctavedisplacement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dis.place", _val);
    }

    public static XAttribute GetDisPlaceAttribute(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.GetAttribute(e, "dis.place");
    }
    
    public static string GetDisPlaceValue(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dis.place");
    }
    
    public static bool HasDisPlace(this IAttOctavedisplacement e)
    {
      return MeiAtt_controller.HasAttribute(e, "dis.place");
    }

    public static void RemoveDisPlace(this IAttOctavedisplacement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dis.place");
    }
    #endregion

  }

}