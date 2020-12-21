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
  /// Interface for att.duration.musical
  /// </summary>
  public interface IAttDurationMusical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.duration.musical
  /// </summary>
  public static class AttDurationMusical_extensions
  {
    #region dur
    
    public static void SetDur(this IAttDurationMusical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dur", _val);
    }

    public static XAttribute GetDurAttribute(this IAttDurationMusical e)
    {
      return MeiAtt_controller.GetAttribute(e, "dur");
    }
    
    public static string GetDurValue(this IAttDurationMusical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "dur");
    }
    
    public static bool HasDur(this IAttDurationMusical e)
    {
      return MeiAtt_controller.HasAttribute(e, "dur");
    }

    public static void RemoveDur(this IAttDurationMusical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dur");
    }
    #endregion

  }

}