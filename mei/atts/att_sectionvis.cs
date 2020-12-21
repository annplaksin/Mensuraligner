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
  /// Interface for att.section.vis
  /// </summary>
  public interface IAttSectionVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.section.vis
  /// </summary>
  public static class AttSectionVis_extensions
  {
    #region restart
    
    public static void SetRestart(this IAttSectionVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "restart", _val);
    }

    public static XAttribute GetRestartAttribute(this IAttSectionVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "restart");
    }
    
    public static string GetRestartValue(this IAttSectionVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "restart");
    }
    
    public static bool HasRestart(this IAttSectionVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "restart");
    }

    public static void RemoveRestart(this IAttSectionVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "restart");
    }
    #endregion

  }

}