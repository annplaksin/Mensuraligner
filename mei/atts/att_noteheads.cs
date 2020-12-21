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
  /// Interface for att.noteheads
  /// </summary>
  public interface IAttNoteheads : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.noteheads
  /// </summary>
  public static class AttNoteheads_extensions
  {
    #region head.color
    
    public static void SetHeadColor(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.color", _val);
    }

    public static XAttribute GetHeadColorAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.color");
    }
    
    public static string GetHeadColorValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.color");
    }
    
    public static bool HasHeadColor(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.color");
    }

    public static void RemoveHeadColor(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.color");
    }
    #endregion

    #region head.fill
    
    public static void SetHeadFill(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.fill", _val);
    }

    public static XAttribute GetHeadFillAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.fill");
    }
    
    public static string GetHeadFillValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.fill");
    }
    
    public static bool HasHeadFill(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.fill");
    }

    public static void RemoveHeadFill(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.fill");
    }
    #endregion

    #region head.fillcolor
    
    public static void SetHeadFillcolor(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.fillcolor", _val);
    }

    public static XAttribute GetHeadFillcolorAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.fillcolor");
    }
    
    public static string GetHeadFillcolorValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.fillcolor");
    }
    
    public static bool HasHeadFillcolor(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.fillcolor");
    }

    public static void RemoveHeadFillcolor(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.fillcolor");
    }
    #endregion

    #region head.mod
    
    public static void SetHeadMod(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.mod", _val);
    }

    public static XAttribute GetHeadModAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.mod");
    }
    
    public static string GetHeadModValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.mod");
    }
    
    public static bool HasHeadMod(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.mod");
    }

    public static void RemoveHeadMod(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.mod");
    }
    #endregion

    #region head.rotation
    
    public static void SetHeadRotation(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.rotation", _val);
    }

    public static XAttribute GetHeadRotationAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.rotation");
    }
    
    public static string GetHeadRotationValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.rotation");
    }
    
    public static bool HasHeadRotation(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.rotation");
    }

    public static void RemoveHeadRotation(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.rotation");
    }
    #endregion

    #region head.shape
    
    public static void SetHeadShape(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.shape", _val);
    }

    public static XAttribute GetHeadShapeAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.shape");
    }
    
    public static string GetHeadShapeValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.shape");
    }
    
    public static bool HasHeadShape(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.shape");
    }

    public static void RemoveHeadShape(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.shape");
    }
    #endregion

    #region head.visible
    
    public static void SetHeadVisible(this IAttNoteheads e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "head.visible", _val);
    }

    public static XAttribute GetHeadVisibleAttribute(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttribute(e, "head.visible");
    }
    
    public static string GetHeadVisibleValue(this IAttNoteheads e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "head.visible");
    }
    
    public static bool HasHeadVisible(this IAttNoteheads e)
    {
      return MeiAtt_controller.HasAttribute(e, "head.visible");
    }

    public static void RemoveHeadVisible(this IAttNoteheads e)
    {
      MeiAtt_controller.RemoveAttribute(e, "head.visible");
    }
    #endregion

  }

}