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
  /// Interface for att.whitespace
  /// </summary>
  public interface IAttWhitespace : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.whitespace
  /// </summary>
  public static class AttWhitespace_extensions
  {
    #region xml:space
    
    public static void SetSpace(this IAttWhitespace e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xml:space", _val);
    }

    public static XAttribute GetSpaceAttribute(this IAttWhitespace e)
    {
      return MeiAtt_controller.GetAttribute(e, "xml:space");
    }
    
    public static string GetSpaceValue(this IAttWhitespace e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xml:space");
    }
    
    public static bool HasSpace(this IAttWhitespace e)
    {
      return MeiAtt_controller.HasAttribute(e, "xml:space");
    }

    public static void RemoveSpace(this IAttWhitespace e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xml:space");
    }
    #endregion

  }

}