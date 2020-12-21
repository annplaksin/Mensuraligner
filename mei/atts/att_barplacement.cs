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
  /// Interface for att.barplacement
  /// </summary>
  public interface IAttBarplacement : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.barplacement
  /// </summary>
  public static class AttBarplacement_extensions
  {
    #region barplace
    
    public static void SetBarplace(this IAttBarplacement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "barplace", _val);
    }

    public static XAttribute GetBarplaceAttribute(this IAttBarplacement e)
    {
      return MeiAtt_controller.GetAttribute(e, "barplace");
    }
    
    public static string GetBarplaceValue(this IAttBarplacement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "barplace");
    }
    
    public static bool HasBarplace(this IAttBarplacement e)
    {
      return MeiAtt_controller.HasAttribute(e, "barplace");
    }

    public static void RemoveBarplace(this IAttBarplacement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "barplace");
    }
    #endregion

    #region taktplace
    
    public static void SetTaktplace(this IAttBarplacement e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "taktplace", _val);
    }

    public static XAttribute GetTaktplaceAttribute(this IAttBarplacement e)
    {
      return MeiAtt_controller.GetAttribute(e, "taktplace");
    }
    
    public static string GetTaktplaceValue(this IAttBarplacement e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "taktplace");
    }
    
    public static bool HasTaktplace(this IAttBarplacement e)
    {
      return MeiAtt_controller.HasAttribute(e, "taktplace");
    }

    public static void RemoveTaktplace(this IAttBarplacement e)
    {
      MeiAtt_controller.RemoveAttribute(e, "taktplace");
    }
    #endregion

  }

}