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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
  /// Interface for att.articulation.performed
  /// </summary>
  public interface IAttArticulationPerformed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.articulation.performed
  /// </summary>
  public static class AttArticulationPerformed_extensions
  {
    #region artic.ges
    
    public static void SetArticGes(this IAttArticulationPerformed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "artic.ges", _val);
    }

    public static XAttribute GetArticGesAttribute(this IAttArticulationPerformed e)
    {
      return MeiAtt_controller.GetAttribute(e, "artic.ges");
    }

    public static string GetArticGesValue(this IAttArticulationPerformed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "artic.ges");
    }

    public static bool HasArticGes(this IAttArticulationPerformed e)
    {
      return MeiAtt_controller.HasAttribute(e, "artic.ges");
    }

    public static void RemoveArticGes(this IAttArticulationPerformed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "artic.ges");
    }
    #endregion

  }

}