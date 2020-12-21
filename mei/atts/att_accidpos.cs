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
  /// Interface for att.accid.pos
  /// </summary>
  public interface IAttAccidPos : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.accid.pos
  /// </summary>
  public static class AttAccidPos_extensions
  {
    #region accidPos
    private static readonly XNamespace ns_accidPos = "http://github.com/annplaksin/mensural_sourceEncoding";

    public static void SetAccidPos(this IAttAccidPos e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "accidPos", ns_accidPos, _val);
    }

    public static XAttribute GetAccidPosAttribute(this IAttAccidPos e)
    {
      return MeiAtt_controller.GetAttribute(e, "accidPos", ns_accidPos);
    }
    
    public static string GetAccidPosValue(this IAttAccidPos e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "accidPos", ns_accidPos);
    }
    
    public static bool HasAccidPos(this IAttAccidPos e)
    {
      return MeiAtt_controller.HasAttribute(e, "accidPos", ns_accidPos);
    }

    public static void RemoveAccidPos(this IAttAccidPos e)
    {
      MeiAtt_controller.RemoveAttribute(e, "accidPos", ns_accidPos);
    }
    #endregion

  }

}