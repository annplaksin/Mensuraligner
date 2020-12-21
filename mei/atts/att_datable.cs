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
  /// Interface for att.datable
  /// </summary>
  public interface IAttDatable : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.datable
  /// </summary>
  public static class AttDatable_extensions
  {
    #region enddate
    
    public static void SetEnddate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "enddate", _val);
    }

    public static XAttribute GetEnddateAttribute(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "enddate");
    }
    
    public static string GetEnddateValue(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "enddate");
    }
    
    public static bool HasEnddate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "enddate");
    }

    public static void RemoveEnddate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "enddate");
    }
    #endregion

    #region isodate
    
    public static void SetIsodate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "isodate", _val);
    }

    public static XAttribute GetIsodateAttribute(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "isodate");
    }
    
    public static string GetIsodateValue(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "isodate");
    }
    
    public static bool HasIsodate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "isodate");
    }

    public static void RemoveIsodate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "isodate");
    }
    #endregion

    #region notafter
    
    public static void SetNotafter(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notafter", _val);
    }

    public static XAttribute GetNotafterAttribute(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "notafter");
    }
    
    public static string GetNotafterValue(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "notafter");
    }
    
    public static bool HasNotafter(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "notafter");
    }

    public static void RemoveNotafter(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notafter");
    }
    #endregion

    #region notbefore
    
    public static void SetNotbefore(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notbefore", _val);
    }

    public static XAttribute GetNotbeforeAttribute(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "notbefore");
    }
    
    public static string GetNotbeforeValue(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "notbefore");
    }
    
    public static bool HasNotbefore(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "notbefore");
    }

    public static void RemoveNotbefore(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notbefore");
    }
    #endregion

    #region startdate
    
    public static void SetStartdate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startdate", _val);
    }

    public static XAttribute GetStartdateAttribute(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "startdate");
    }
    
    public static string GetStartdateValue(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "startdate");
    }
    
    public static bool HasStartdate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "startdate");
    }

    public static void RemoveStartdate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startdate");
    }
    #endregion

  }

}