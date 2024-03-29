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
  /// Interface for att.octave
  /// </summary>
  public interface IAttOctave : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.octave
  /// </summary>
  public static class AttOctave_extensions
  {
    #region oct
    
    public static void SetOct(this IAttOctave e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "oct", _val);
    }

    public static XAttribute GetOctAttribute(this IAttOctave e)
    {
      return MeiAtt_controller.GetAttribute(e, "oct");
    }
    
    public static string GetOctValue(this IAttOctave e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "oct");
    }
    
    public static bool HasOct(this IAttOctave e)
    {
      return MeiAtt_controller.HasAttribute(e, "oct");
    }

    public static void RemoveOct(this IAttOctave e)
    {
      MeiAtt_controller.RemoveAttribute(e, "oct");
    }
    #endregion

  }

}