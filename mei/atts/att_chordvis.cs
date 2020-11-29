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
  /// Interface for att.chord.vis
  /// </summary>
  public interface IAttChordVis : IMEiAtt, IAttAltsym, IAttColor, IAttRelativesize, IAttStemmed, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy
  {

  }


    /// <summary>
  /// Extension methods for att.chord.vis
  /// </summary>
  public static class AttChordVis_extensions
  {
    #region cluster
    
    public static void SetCluster(this IAttChordVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cluster", _val);
    }

    public static XAttribute GetClusterAttribute(this IAttChordVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "cluster");
    }

    public static string GetClusterValue(this IAttChordVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "cluster");
    }

    public static bool HasCluster(this IAttChordVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "cluster");
    }

    public static void RemoveCluster(this IAttChordVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cluster");
    }
    #endregion

  }

}