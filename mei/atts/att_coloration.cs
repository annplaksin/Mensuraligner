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
  /// Interface for att.coloration
  /// </summary>
  public interface IAttColoration : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.coloration
  /// </summary>
  public static class AttColoration_extensions
  {
    #region colored
    
    public static void SetColored(this IAttColoration e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "colored", _val);
    }

    public static XAttribute GetColoredAttribute(this IAttColoration e)
    {
      return MeiAtt_controller.GetAttribute(e, "colored");
    }

    public static string GetColoredValue(this IAttColoration e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "colored");
    }

    public static bool HasColored(this IAttColoration e)
    {
      return MeiAtt_controller.HasAttribute(e, "colored");
    }

    public static void RemoveColored(this IAttColoration e)
    {
      MeiAtt_controller.RemoveAttribute(e, "colored");
    }
    #endregion

  }

}