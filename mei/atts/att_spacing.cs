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
  /// Interface for att.spacing
  /// </summary>
  public interface IAttSpacing : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.spacing
  /// </summary>
  public static class AttSpacing_extensions
  {
    #region spacing.packexp
    
    public static void SetSpacingPackexp(this IAttSpacing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.packexp", _val);
    }

    public static XAttribute GetSpacingPackexpAttribute(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.packexp");
    }

    public static string GetSpacingPackexpValue(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.packexp");
    }

    public static bool HasSpacingPackexp(this IAttSpacing e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.packexp");
    }

    public static void RemoveSpacingPackexp(this IAttSpacing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.packexp");
    }
    #endregion

    #region spacing.packfact
    
    public static void SetSpacingPackfact(this IAttSpacing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.packfact", _val);
    }

    public static XAttribute GetSpacingPackfactAttribute(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.packfact");
    }

    public static string GetSpacingPackfactValue(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.packfact");
    }

    public static bool HasSpacingPackfact(this IAttSpacing e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.packfact");
    }

    public static void RemoveSpacingPackfact(this IAttSpacing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.packfact");
    }
    #endregion

    #region spacing.staff
    
    public static void SetSpacingStaff(this IAttSpacing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.staff", _val);
    }

    public static XAttribute GetSpacingStaffAttribute(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.staff");
    }

    public static string GetSpacingStaffValue(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.staff");
    }

    public static bool HasSpacingStaff(this IAttSpacing e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.staff");
    }

    public static void RemoveSpacingStaff(this IAttSpacing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.staff");
    }
    #endregion

    #region spacing.system
    
    public static void SetSpacingSystem(this IAttSpacing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spacing.system", _val);
    }

    public static XAttribute GetSpacingSystemAttribute(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttribute(e, "spacing.system");
    }

    public static string GetSpacingSystemValue(this IAttSpacing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spacing.system");
    }

    public static bool HasSpacingSystem(this IAttSpacing e)
    {
      return MeiAtt_controller.HasAttribute(e, "spacing.system");
    }

    public static void RemoveSpacingSystem(this IAttSpacing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spacing.system");
    }
    #endregion

  }

}