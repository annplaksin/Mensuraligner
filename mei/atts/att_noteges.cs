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
  /// Interface for att.note.ges
  /// </summary>
  public interface IAttNoteGes : IMEiAtt, IAttAccidentalPerformed, IAttNoteGesMensural
  {

  }


    /// <summary>
  /// Extension methods for att.note.ges
  /// </summary>
  public static class AttNoteGes_extensions
  {
    #region oct.ges
    
    public static void SetOctGes(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "oct.ges", _val);
    }

    public static XAttribute GetOctGesAttribute(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "oct.ges");
    }
    
    public static string GetOctGesValue(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "oct.ges");
    }
    
    public static bool HasOctGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "oct.ges");
    }

    public static void RemoveOctGes(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "oct.ges");
    }
    #endregion

    #region pname.ges
    
    public static void SetPnameGes(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pname.ges", _val);
    }

    public static XAttribute GetPnameGesAttribute(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "pname.ges");
    }
    
    public static string GetPnameGesValue(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "pname.ges");
    }
    
    public static bool HasPnameGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "pname.ges");
    }

    public static void RemovePnameGes(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pname.ges");
    }
    #endregion

    #region pnum
    
    public static void SetPnum(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pnum", _val);
    }

    public static XAttribute GetPnumAttribute(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "pnum");
    }
    
    public static string GetPnumValue(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "pnum");
    }
    
    public static bool HasPnum(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "pnum");
    }

    public static void RemovePnum(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pnum");
    }
    #endregion

  }

}