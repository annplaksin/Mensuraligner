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
  /// Interface for att.clefshape
  /// </summary>
  public interface IAttClefshape : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.clefshape
  /// </summary>
  public static class AttClefshape_extensions
  {
    #region shape
    
    public static void SetShape(this IAttClefshape e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "shape", _val);
    }

    public static XAttribute GetShapeAttribute(this IAttClefshape e)
    {
      return MeiAtt_controller.GetAttribute(e, "shape");
    }
    
    public static string GetShapeValue(this IAttClefshape e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "shape");
    }
    
    public static bool HasShape(this IAttClefshape e)
    {
      return MeiAtt_controller.HasAttribute(e, "shape");
    }

    public static void RemoveShape(this IAttClefshape e)
    {
      MeiAtt_controller.RemoveAttribute(e, "shape");
    }
    #endregion

  }

}