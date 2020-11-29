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
  /// Interface for att.onelinestaff
  /// </summary>
  public interface IAttOnelinestaff : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.onelinestaff
  /// </summary>
  public static class AttOnelinestaff_extensions
  {
    #region ontheline
    
    public static void SetOntheline(this IAttOnelinestaff e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ontheline", _val);
    }

    public static XAttribute GetOnthelineAttribute(this IAttOnelinestaff e)
    {
      return MeiAtt_controller.GetAttribute(e, "ontheline");
    }

    public static string GetOnthelineValue(this IAttOnelinestaff e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ontheline");
    }

    public static bool HasOntheline(this IAttOnelinestaff e)
    {
      return MeiAtt_controller.HasAttribute(e, "ontheline");
    }

    public static void RemoveOntheline(this IAttOnelinestaff e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ontheline");
    }
    #endregion

  }

}