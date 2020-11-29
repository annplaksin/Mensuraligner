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
  /// Interface for att.responsibility
  /// </summary>
  public interface IAttResponsibility : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.responsibility
  /// </summary>
  public static class AttResponsibility_extensions
  {
    #region resp
    
    public static void SetResp(this IAttResponsibility e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "resp", _val);
    }

    public static XAttribute GetRespAttribute(this IAttResponsibility e)
    {
      return MeiAtt_controller.GetAttribute(e, "resp");
    }

    public static string GetRespValue(this IAttResponsibility e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "resp");
    }

    public static bool HasResp(this IAttResponsibility e)
    {
      return MeiAtt_controller.HasAttribute(e, "resp");
    }

    public static void RemoveResp(this IAttResponsibility e)
    {
      MeiAtt_controller.RemoveAttribute(e, "resp");
    }
    #endregion

  }

}