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
  /// Interface for att.rel
  /// </summary>
  public interface IAttRel : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.rel
  /// </summary>
  public static class AttRel_extensions
  {
    #region rel
    
    public static void SetRel(this IAttRel e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rel", _val);
    }

    public static XAttribute GetRelAttribute(this IAttRel e)
    {
      return MeiAtt_controller.GetAttribute(e, "rel");
    }
    
    public static string GetRelValue(this IAttRel e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "rel");
    }
    
    public static bool HasRel(this IAttRel e)
    {
      return MeiAtt_controller.HasAttribute(e, "rel");
    }

    public static void RemoveRel(this IAttRel e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rel");
    }
    #endregion

  }

}