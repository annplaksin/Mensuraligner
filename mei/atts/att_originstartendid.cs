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
  /// Interface for att.origin.startendid
  /// </summary>
  public interface IAttOriginStartendid : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.origin.startendid
  /// </summary>
  public static class AttOriginStartendid_extensions
  {
    #region origin.startid
    
    public static void SetOriginStartid(this IAttOriginStartendid e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.startid", _val);
    }

    public static XAttribute GetOriginStartidAttribute(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.startid");
    }
    
    public static string GetOriginStartidValue(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "origin.startid");
    }
    
    public static bool HasOriginStartid(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.startid");
    }

    public static void RemoveOriginStartid(this IAttOriginStartendid e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.startid");
    }
    #endregion

    #region origin.endid
    
    public static void SetOriginEndid(this IAttOriginStartendid e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.endid", _val);
    }

    public static XAttribute GetOriginEndidAttribute(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.endid");
    }
    
    public static string GetOriginEndidValue(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "origin.endid");
    }
    
    public static bool HasOriginEndid(this IAttOriginStartendid e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.endid");
    }

    public static void RemoveOriginEndid(this IAttOriginStartendid e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.endid");
    }
    #endregion

  }

}