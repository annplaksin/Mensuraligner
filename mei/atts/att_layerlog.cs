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
  /// Interface for att.layer.log
  /// </summary>
  public interface IAttLayerLog : IMEiAtt, IAttMeterconformance
  {

  }


    /// <summary>
  /// Extension methods for att.layer.log
  /// </summary>
  public static class AttLayerLog_extensions
  {
    #region def
    
    public static void SetDef(this IAttLayerLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "def", _val);
    }

    public static XAttribute GetDefAttribute(this IAttLayerLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "def");
    }
    
    public static string GetDefValue(this IAttLayerLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "def");
    }
    
    public static bool HasDef(this IAttLayerLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "def");
    }

    public static void RemoveDef(this IAttLayerLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "def");
    }
    #endregion

  }

}