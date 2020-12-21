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
  /// Interface for att.tupletpresent
  /// </summary>
  public interface IAttTupletpresent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.tupletpresent
  /// </summary>
  public static class AttTupletpresent_extensions
  {
    #region tuplet
    
    public static void SetTuplet(this IAttTupletpresent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tuplet", _val);
    }

    public static XAttribute GetTupletAttribute(this IAttTupletpresent e)
    {
      return MeiAtt_controller.GetAttribute(e, "tuplet");
    }
    
    public static string GetTupletValue(this IAttTupletpresent e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tuplet");
    }
    
    public static bool HasTuplet(this IAttTupletpresent e)
    {
      return MeiAtt_controller.HasAttribute(e, "tuplet");
    }

    public static void RemoveTuplet(this IAttTupletpresent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tuplet");
    }
    #endregion

  }

}