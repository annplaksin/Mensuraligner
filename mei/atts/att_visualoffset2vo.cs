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
  /// Interface for att.visualoffset2.vo
  /// </summary>
  public interface IAttVisualoffset2Vo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset2.vo
  /// </summary>
  public static class AttVisualoffset2Vo_extensions
  {
    #region startvo
    
    public static void SetStartvo(this IAttVisualoffset2Vo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startvo", _val);
    }

    public static XAttribute GetStartvoAttribute(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.GetAttribute(e, "startvo");
    }
    
    public static string GetStartvoValue(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "startvo");
    }
    
    public static bool HasStartvo(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.HasAttribute(e, "startvo");
    }

    public static void RemoveStartvo(this IAttVisualoffset2Vo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startvo");
    }
    #endregion

    #region endvo
    
    public static void SetEndvo(this IAttVisualoffset2Vo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endvo", _val);
    }

    public static XAttribute GetEndvoAttribute(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.GetAttribute(e, "endvo");
    }
    
    public static string GetEndvoValue(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "endvo");
    }
    
    public static bool HasEndvo(this IAttVisualoffset2Vo e)
    {
      return MeiAtt_controller.HasAttribute(e, "endvo");
    }

    public static void RemoveEndvo(this IAttVisualoffset2Vo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endvo");
    }
    #endregion

  }

}