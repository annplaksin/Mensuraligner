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
  /// Interface for att.endings
  /// </summary>
  public interface IAttEndings : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.endings
  /// </summary>
  public static class AttEndings_extensions
  {
    #region ending.rend
    
    public static void SetEndingRend(this IAttEndings e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ending.rend", _val);
    }

    public static XAttribute GetEndingRendAttribute(this IAttEndings e)
    {
      return MeiAtt_controller.GetAttribute(e, "ending.rend");
    }
    
    public static string GetEndingRendValue(this IAttEndings e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ending.rend");
    }
    
    public static bool HasEndingRend(this IAttEndings e)
    {
      return MeiAtt_controller.HasAttribute(e, "ending.rend");
    }

    public static void RemoveEndingRend(this IAttEndings e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ending.rend");
    }
    #endregion

  }

}