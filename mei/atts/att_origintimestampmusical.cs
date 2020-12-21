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
  /// Interface for att.origin.timestamp.musical
  /// </summary>
  public interface IAttOriginTimestampMusical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.origin.timestamp.musical
  /// </summary>
  public static class AttOriginTimestampMusical_extensions
  {
    #region origin.tstamp
    
    public static void SetOriginTstamp(this IAttOriginTimestampMusical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.tstamp", _val);
    }

    public static XAttribute GetOriginTstampAttribute(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.tstamp");
    }
    
    public static string GetOriginTstampValue(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "origin.tstamp");
    }
    
    public static bool HasOriginTstamp(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.tstamp");
    }

    public static void RemoveOriginTstamp(this IAttOriginTimestampMusical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.tstamp");
    }
    #endregion

    #region origin.tstamp2
    
    public static void SetOriginTstamp2(this IAttOriginTimestampMusical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.tstamp2", _val);
    }

    public static XAttribute GetOriginTstamp2Attribute(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.tstamp2");
    }
    
    public static string GetOriginTstamp2Value(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "origin.tstamp2");
    }
    
    public static bool HasOriginTstamp2(this IAttOriginTimestampMusical e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.tstamp2");
    }

    public static void RemoveOriginTstamp2(this IAttOriginTimestampMusical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.tstamp2");
    }
    #endregion

  }

}