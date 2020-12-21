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
  /// Interface for att.staffGrp.vis
  /// </summary>
  public interface IAttStaffGrpVis : IMEiAtt, IAttLabelsAddl, IAttStaffgroupingsym, IAttVisibility
  {

  }


    /// <summary>
  /// Extension methods for att.staffGrp.vis
  /// </summary>
  public static class AttStaffGrpVis_extensions
  {
    #region barthru
    
    public static void SetBarthru(this IAttStaffGrpVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "barthru", _val);
    }

    public static XAttribute GetBarthruAttribute(this IAttStaffGrpVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "barthru");
    }
    
    public static string GetBarthruValue(this IAttStaffGrpVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "barthru");
    }
    
    public static bool HasBarthru(this IAttStaffGrpVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "barthru");
    }

    public static void RemoveBarthru(this IAttStaffGrpVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "barthru");
    }
    #endregion

  }

}