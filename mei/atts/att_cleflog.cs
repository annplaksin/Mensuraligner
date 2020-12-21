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
  /// Interface for att.clef.log
  /// </summary>
  public interface IAttClefLog : IMEiAtt, IAttClefshape, IAttLineloc, IAttOctave, IAttOctavedisplacement
  {

  }


    /// <summary>
  /// Extension methods for att.clef.log
  /// </summary>
  public static class AttClefLog_extensions
  {
    #region cautionary
    
    public static void SetCautionary(this IAttClefLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cautionary", _val);
    }

    public static XAttribute GetCautionaryAttribute(this IAttClefLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "cautionary");
    }
    
    public static string GetCautionaryValue(this IAttClefLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "cautionary");
    }
    
    public static bool HasCautionary(this IAttClefLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "cautionary");
    }

    public static void RemoveCautionary(this IAttClefLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cautionary");
    }
    #endregion

  }

}