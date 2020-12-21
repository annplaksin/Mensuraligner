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
  /// Interface for att.visualoffset2.to
  /// </summary>
  public interface IAttVisualoffset2To : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.visualoffset2.to
  /// </summary>
  public static class AttVisualoffset2To_extensions
  {
    #region startto
    
    public static void SetStartto(this IAttVisualoffset2To e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startto", _val);
    }

    public static XAttribute GetStarttoAttribute(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.GetAttribute(e, "startto");
    }
    
    public static string GetStarttoValue(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "startto");
    }
    
    public static bool HasStartto(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.HasAttribute(e, "startto");
    }

    public static void RemoveStartto(this IAttVisualoffset2To e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startto");
    }
    #endregion

    #region endto
    
    public static void SetEndto(this IAttVisualoffset2To e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endto", _val);
    }

    public static XAttribute GetEndtoAttribute(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.GetAttribute(e, "endto");
    }
    
    public static string GetEndtoValue(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "endto");
    }
    
    public static bool HasEndto(this IAttVisualoffset2To e)
    {
      return MeiAtt_controller.HasAttribute(e, "endto");
    }

    public static void RemoveEndto(this IAttVisualoffset2To e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endto");
    }
    #endregion

  }

}