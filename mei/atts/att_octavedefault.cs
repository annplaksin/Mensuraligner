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
  /// Interface for att.octavedefault
  /// </summary>
  public interface IAttOctavedefault : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.octavedefault
  /// </summary>
  public static class AttOctavedefault_extensions
  {
    #region octave.default
    
    public static void SetOctaveDefault(this IAttOctavedefault e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "octave.default", _val);
    }

    public static XAttribute GetOctaveDefaultAttribute(this IAttOctavedefault e)
    {
      return MeiAtt_controller.GetAttribute(e, "octave.default");
    }
    
    public static string GetOctaveDefaultValue(this IAttOctavedefault e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "octave.default");
    }
    
    public static bool HasOctaveDefault(this IAttOctavedefault e)
    {
      return MeiAtt_controller.HasAttribute(e, "octave.default");
    }

    public static void RemoveOctaveDefault(this IAttOctavedefault e)
    {
      MeiAtt_controller.RemoveAttribute(e, "octave.default");
    }
    #endregion

  }

}