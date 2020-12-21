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
  /// Interface for att.notationtype
  /// </summary>
  public interface IAttNotationtype : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.notationtype
  /// </summary>
  public static class AttNotationtype_extensions
  {
    #region notationtype
    
    public static void SetNotationtype(this IAttNotationtype e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notationtype", _val);
    }

    public static XAttribute GetNotationtypeAttribute(this IAttNotationtype e)
    {
      return MeiAtt_controller.GetAttribute(e, "notationtype");
    }
    
    public static string GetNotationtypeValue(this IAttNotationtype e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "notationtype");
    }
    
    public static bool HasNotationtype(this IAttNotationtype e)
    {
      return MeiAtt_controller.HasAttribute(e, "notationtype");
    }

    public static void RemoveNotationtype(this IAttNotationtype e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notationtype");
    }
    #endregion

    #region notationsubtype
    
    public static void SetNotationsubtype(this IAttNotationtype e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notationsubtype", _val);
    }

    public static XAttribute GetNotationsubtypeAttribute(this IAttNotationtype e)
    {
      return MeiAtt_controller.GetAttribute(e, "notationsubtype");
    }
    
    public static string GetNotationsubtypeValue(this IAttNotationtype e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "notationsubtype");
    }
    
    public static bool HasNotationsubtype(this IAttNotationtype e)
    {
      return MeiAtt_controller.HasAttribute(e, "notationsubtype");
    }

    public static void RemoveNotationsubtype(this IAttNotationtype e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notationsubtype");
    }
    #endregion

  }

}