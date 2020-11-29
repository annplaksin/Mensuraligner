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
  /// Interface for att.joined
  /// </summary>
  public interface IAttJoined : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.joined
  /// </summary>
  public static class AttJoined_extensions
  {
    #region join
    
    public static void SetJoin(this IAttJoined e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "join", _val);
    }

    public static XAttribute GetJoinAttribute(this IAttJoined e)
    {
      return MeiAtt_controller.GetAttribute(e, "join");
    }

    public static string GetJoinValue(this IAttJoined e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "join");
    }

    public static bool HasJoin(this IAttJoined e)
    {
      return MeiAtt_controller.HasAttribute(e, "join");
    }

    public static void RemoveJoin(this IAttJoined e)
    {
      MeiAtt_controller.RemoveAttribute(e, "join");
    }
    #endregion

  }

}