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
  /// Interface for att.scoreDef.vis
  /// </summary>
  public interface IAttScoreDefVis : IMEiAtt, IAttBarplacement, IAttCleffingVis, IAttDistances, IAttEndings, IAttKeySigDefaultVis, IAttLyricstyle, IAttMeasurenumbers, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttNotationstyle, IAttOnelinestaff, IAttOptimization, IAttPages, IAttSpacing, IAttSystems, IAttTextstyle, IAttScoreDefVisMensural
  {

  }


    /// <summary>
  /// Extension methods for att.scoreDef.vis
  /// </summary>
  public static class AttScoreDefVis_extensions
  {
    #region vu.height
    
    public static void SetVuHeight(this IAttScoreDefVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "vu.height", _val);
    }

    public static XAttribute GetVuHeightAttribute(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "vu.height");
    }
    
    public static string GetVuHeightValue(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "vu.height");
    }
    
    public static bool HasVuHeight(this IAttScoreDefVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "vu.height");
    }

    public static void RemoveVuHeight(this IAttScoreDefVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "vu.height");
    }
    #endregion

  }

}