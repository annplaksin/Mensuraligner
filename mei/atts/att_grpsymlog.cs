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
  /// Interface for att.grpSym.log
  /// </summary>
  public interface IAttGrpSymLog : IMEiAtt, IAttStaffgroupingsym, IAttStartendid
  {

  }


    /// <summary>
  /// Extension methods for att.grpSym.log
  /// </summary>
  public static class AttGrpSymLog_extensions
  {
    #region level
    
    public static void SetLevel(this IAttGrpSymLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "level", _val);
    }

    public static XAttribute GetLevelAttribute(this IAttGrpSymLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "level");
    }
    
    public static string GetLevelValue(this IAttGrpSymLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "level");
    }
    
    public static bool HasLevel(this IAttGrpSymLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "level");
    }

    public static void RemoveLevel(this IAttGrpSymLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "level");
    }
    #endregion

  }

}