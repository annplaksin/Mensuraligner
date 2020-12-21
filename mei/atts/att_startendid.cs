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
  /// Interface for att.startendid
  /// </summary>
  public interface IAttStartendid : IMEiAtt, IAttStartid
  {

  }


    /// <summary>
  /// Extension methods for att.startendid
  /// </summary>
  public static class AttStartendid_extensions
  {
    #region endid
    
    public static void SetEndid(this IAttStartendid e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endid", _val);
    }

    public static XAttribute GetEndidAttribute(this IAttStartendid e)
    {
      return MeiAtt_controller.GetAttribute(e, "endid");
    }
    
    public static string GetEndidValue(this IAttStartendid e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "endid");
    }
    
    public static bool HasEndid(this IAttStartendid e)
    {
      return MeiAtt_controller.HasAttribute(e, "endid");
    }

    public static void RemoveEndid(this IAttStartendid e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endid");
    }
    #endregion

  }

}