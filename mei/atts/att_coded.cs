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
  /// Interface for att.coded
  /// </summary>
  public interface IAttCoded : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.coded
  /// </summary>
  public static class AttCoded_extensions
  {
    #region code
    
    public static void SetCode(this IAttCoded e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "code", _val);
    }

    public static XAttribute GetCodeAttribute(this IAttCoded e)
    {
      return MeiAtt_controller.GetAttribute(e, "code");
    }

    public static string GetCodeValue(this IAttCoded e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "code");
    }

    public static bool HasCode(this IAttCoded e)
    {
      return MeiAtt_controller.HasAttribute(e, "code");
    }

    public static void RemoveCode(this IAttCoded e)
    {
      MeiAtt_controller.RemoveAttribute(e, "code");
    }
    #endregion

  }

}