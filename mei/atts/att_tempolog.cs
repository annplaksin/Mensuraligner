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
  /// Interface for att.tempo.log
  /// </summary>
  public interface IAttTempoLog : IMEiAtt, IAttControlevent, IAttStartid
  {

  }


    /// <summary>
  /// Extension methods for att.tempo.log
  /// </summary>
  public static class AttTempoLog_extensions
  {
    #region func
    
    public static void SetFunc(this IAttTempoLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "func", _val);
    }

    public static XAttribute GetFuncAttribute(this IAttTempoLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "func");
    }
    
    public static string GetFuncValue(this IAttTempoLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "func");
    }
    
    public static bool HasFunc(this IAttTempoLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "func");
    }

    public static void RemoveFunc(this IAttTempoLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "func");
    }
    #endregion

  }

}