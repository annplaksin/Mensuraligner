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
  /// Interface for att.transposition
  /// </summary>
  public interface IAttTransposition : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.transposition
  /// </summary>
  public static class AttTransposition_extensions
  {
    #region trans.diat
    
    public static void SetTransDiat(this IAttTransposition e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "trans.diat", _val);
    }

    public static XAttribute GetTransDiatAttribute(this IAttTransposition e)
    {
      return MeiAtt_controller.GetAttribute(e, "trans.diat");
    }
    
    public static string GetTransDiatValue(this IAttTransposition e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "trans.diat");
    }
    
    public static bool HasTransDiat(this IAttTransposition e)
    {
      return MeiAtt_controller.HasAttribute(e, "trans.diat");
    }

    public static void RemoveTransDiat(this IAttTransposition e)
    {
      MeiAtt_controller.RemoveAttribute(e, "trans.diat");
    }
    #endregion

    #region trans.semi
    
    public static void SetTransSemi(this IAttTransposition e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "trans.semi", _val);
    }

    public static XAttribute GetTransSemiAttribute(this IAttTransposition e)
    {
      return MeiAtt_controller.GetAttribute(e, "trans.semi");
    }
    
    public static string GetTransSemiValue(this IAttTransposition e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "trans.semi");
    }
    
    public static bool HasTransSemi(this IAttTransposition e)
    {
      return MeiAtt_controller.HasAttribute(e, "trans.semi");
    }

    public static void RemoveTransSemi(this IAttTransposition e)
    {
      MeiAtt_controller.RemoveAttribute(e, "trans.semi");
    }
    #endregion

  }

}