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
  /// Interface for att.staffident
  /// </summary>
  public interface IAttStaffident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.staffident
  /// </summary>
  public static class AttStaffident_extensions
  {
    #region staff
    
    public static void SetStaff(this IAttStaffident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "staff", _val);
    }

    public static XAttribute GetStaffAttribute(this IAttStaffident e)
    {
      return MeiAtt_controller.GetAttribute(e, "staff");
    }
    
    public static string GetStaffValue(this IAttStaffident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "staff");
    }
    
    public static bool HasStaff(this IAttStaffident e)
    {
      return MeiAtt_controller.HasAttribute(e, "staff");
    }

    public static void RemoveStaff(this IAttStaffident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "staff");
    }
    #endregion

  }

}