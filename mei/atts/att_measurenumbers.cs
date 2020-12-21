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
  /// Interface for att.measurenumbers
  /// </summary>
  public interface IAttMeasurenumbers : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.measurenumbers
  /// </summary>
  public static class AttMeasurenumbers_extensions
  {
    #region mnum.visible
    
    public static void SetMnumVisible(this IAttMeasurenumbers e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mnum.visible", _val);
    }

    public static XAttribute GetMnumVisibleAttribute(this IAttMeasurenumbers e)
    {
      return MeiAtt_controller.GetAttribute(e, "mnum.visible");
    }
    
    public static string GetMnumVisibleValue(this IAttMeasurenumbers e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "mnum.visible");
    }
    
    public static bool HasMnumVisible(this IAttMeasurenumbers e)
    {
      return MeiAtt_controller.HasAttribute(e, "mnum.visible");
    }

    public static void RemoveMnumVisible(this IAttMeasurenumbers e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mnum.visible");
    }
    #endregion

  }

}