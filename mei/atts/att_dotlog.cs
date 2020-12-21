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
  /// Interface for att.dot.log
  /// </summary>
  public interface IAttDotLog : IMEiAtt, IAttControlevent
  {

  }


    /// <summary>
  /// Extension methods for att.dot.log
  /// </summary>
  public static class AttDotLog_extensions
  {
    #region form
    
    public static void SetForm(this IAttDotLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetFormAttribute(this IAttDotLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }
    
    public static string GetFormValue(this IAttDotLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "form");
    }
    
    public static bool HasForm(this IAttDotLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttDotLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

  }

}