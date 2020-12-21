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
  /// Interface for att.layerident
  /// </summary>
  public interface IAttLayerident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.layerident
  /// </summary>
  public static class AttLayerident_extensions
  {
    #region layer
    
    public static void SetLayer(this IAttLayerident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "layer", _val);
    }

    public static XAttribute GetLayerAttribute(this IAttLayerident e)
    {
      return MeiAtt_controller.GetAttribute(e, "layer");
    }
    
    public static string GetLayerValue(this IAttLayerident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "layer");
    }
    
    public static bool HasLayer(this IAttLayerident e)
    {
      return MeiAtt_controller.HasAttribute(e, "layer");
    }

    public static void RemoveLayer(this IAttLayerident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "layer");
    }
    #endregion

  }

}