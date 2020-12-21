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
  /// Interface for att.visualoffset.to
  /// </summary>
  public interface IAttVisualoffsetTo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset.to
  /// </summary>
  public static class AttVisualoffsetTo_extensions
  {
    #region to
    
    public static void SetTo(this IAttVisualoffsetTo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "to", _val);
    }

    public static XAttribute GetToAttribute(this IAttVisualoffsetTo e)
    {
      return MeiAtt_controller.GetAttribute(e, "to");
    }
    
    public static string GetToValue(this IAttVisualoffsetTo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "to");
    }
    
    public static bool HasTo(this IAttVisualoffsetTo e)
    {
      return MeiAtt_controller.HasAttribute(e, "to");
    }

    public static void RemoveTo(this IAttVisualoffsetTo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "to");
    }
    #endregion

  }

}