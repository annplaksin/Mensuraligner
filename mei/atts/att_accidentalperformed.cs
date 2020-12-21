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
  /// Interface for att.accidental.performed
  /// </summary>
  public interface IAttAccidentalPerformed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.accidental.performed
  /// </summary>
  public static class AttAccidentalPerformed_extensions
  {
    #region accid.ges
    
    public static void SetAccidGes(this IAttAccidentalPerformed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "accid.ges", _val);
    }

    public static XAttribute GetAccidGesAttribute(this IAttAccidentalPerformed e)
    {
      return MeiAtt_controller.GetAttribute(e, "accid.ges");
    }
    
    public static string GetAccidGesValue(this IAttAccidentalPerformed e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "accid.ges");
    }
    
    public static bool HasAccidGes(this IAttAccidentalPerformed e)
    {
      return MeiAtt_controller.HasAttribute(e, "accid.ges");
    }

    public static void RemoveAccidGes(this IAttAccidentalPerformed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "accid.ges");
    }
    #endregion

  }

}