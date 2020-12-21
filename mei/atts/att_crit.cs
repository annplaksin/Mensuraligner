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
  /// Interface for att.crit
  /// </summary>
  public interface IAttCrit : IMEiAtt, IAttHandident, IAttResponsibility, IAttSequence, IAttSource
  {

  }


    /// <summary>
  /// Extension methods for att.crit
  /// </summary>
  public static class AttCrit_extensions
  {
    #region cause
    
    public static void SetCause(this IAttCrit e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cause", _val);
    }

    public static XAttribute GetCauseAttribute(this IAttCrit e)
    {
      return MeiAtt_controller.GetAttribute(e, "cause");
    }
    
    public static string GetCauseValue(this IAttCrit e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "cause");
    }
    
    public static bool HasCause(this IAttCrit e)
    {
      return MeiAtt_controller.HasAttribute(e, "cause");
    }

    public static void RemoveCause(this IAttCrit e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cause");
    }
    #endregion

  }

}