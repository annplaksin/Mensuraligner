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
  /// Interface for att.articulation
  /// </summary>
  public interface IAttArticulation : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.articulation
  /// </summary>
  public static class AttArticulation_extensions
  {
    #region artic
    
    public static void SetArtic(this IAttArticulation e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "artic", _val);
    }

    public static XAttribute GetArticAttribute(this IAttArticulation e)
    {
      return MeiAtt_controller.GetAttribute(e, "artic");
    }
    
    public static string GetArticValue(this IAttArticulation e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "artic");
    }
    
    public static bool HasArtic(this IAttArticulation e)
    {
      return MeiAtt_controller.HasAttribute(e, "artic");
    }

    public static void RemoveArtic(this IAttArticulation e)
    {
      MeiAtt_controller.RemoveAttribute(e, "artic");
    }
    #endregion

  }

}