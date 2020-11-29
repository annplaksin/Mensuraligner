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
  /// Interface for att.syltext
  /// </summary>
  public interface IAttSyltext : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.syltext
  /// </summary>
  public static class AttSyltext_extensions
  {
    #region syl
    
    public static void SetSyl(this IAttSyltext e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "syl", _val);
    }

    public static XAttribute GetSylAttribute(this IAttSyltext e)
    {
      return MeiAtt_controller.GetAttribute(e, "syl");
    }

    public static string GetSylValue(this IAttSyltext e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "syl");
    }

    public static bool HasSyl(this IAttSyltext e)
    {
      return MeiAtt_controller.HasAttribute(e, "syl");
    }

    public static void RemoveSyl(this IAttSyltext e)
    {
      MeiAtt_controller.RemoveAttribute(e, "syl");
    }
    #endregion

  }

}