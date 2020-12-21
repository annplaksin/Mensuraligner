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
  /// Interface for att.staffloc
  /// </summary>
  public interface IAttStaffloc : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.staffloc
  /// </summary>
  public static class AttStaffloc_extensions
  {
    #region loc
    
    public static void SetLoc(this IAttStaffloc e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "loc", _val);
    }

    public static XAttribute GetLocAttribute(this IAttStaffloc e)
    {
      return MeiAtt_controller.GetAttribute(e, "loc");
    }
    
    public static string GetLocValue(this IAttStaffloc e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "loc");
    }
    
    public static bool HasLoc(this IAttStaffloc e)
    {
      return MeiAtt_controller.HasAttribute(e, "loc");
    }

    public static void RemoveLoc(this IAttStaffloc e)
    {
      MeiAtt_controller.RemoveAttribute(e, "loc");
    }
    #endregion

  }

}