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
  /// Interface for att.surface
  /// </summary>
  public interface IAttSurface : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.surface
  /// </summary>
  public static class AttSurface_extensions
  {
    #region surface
    
    public static void SetSurface(this IAttSurface e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "surface", _val);
    }

    public static XAttribute GetSurfaceAttribute(this IAttSurface e)
    {
      return MeiAtt_controller.GetAttribute(e, "surface");
    }
    
    public static string GetSurfaceValue(this IAttSurface e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "surface");
    }
    
    public static bool HasSurface(this IAttSurface e)
    {
      return MeiAtt_controller.HasAttribute(e, "surface");
    }

    public static void RemoveSurface(this IAttSurface e)
    {
      MeiAtt_controller.RemoveAttribute(e, "surface");
    }
    #endregion

  }

}