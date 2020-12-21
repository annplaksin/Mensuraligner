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
  /// Interface for att.sequence
  /// </summary>
  public interface IAttSequence : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.sequence
  /// </summary>
  public static class AttSequence_extensions
  {
    #region seq
    
    public static void SetSeq(this IAttSequence e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "seq", _val);
    }

    public static XAttribute GetSeqAttribute(this IAttSequence e)
    {
      return MeiAtt_controller.GetAttribute(e, "seq");
    }
    
    public static string GetSeqValue(this IAttSequence e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "seq");
    }
    
    public static bool HasSeq(this IAttSequence e)
    {
      return MeiAtt_controller.HasAttribute(e, "seq");
    }

    public static void RemoveSeq(this IAttSequence e)
    {
      MeiAtt_controller.RemoveAttribute(e, "seq");
    }
    #endregion

  }

}