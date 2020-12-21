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
  /// Interface for att.datapointing
  /// </summary>
  public interface IAttDatapointing : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.datapointing
  /// </summary>
  public static class AttDatapointing_extensions
  {
    #region data
    
    public static void SetData(this IAttDatapointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "data", _val);
    }

    public static XAttribute GetDataAttribute(this IAttDatapointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "data");
    }
    
    public static string GetDataValue(this IAttDatapointing e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "data");
    }
    
    public static bool HasData(this IAttDatapointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "data");
    }

    public static void RemoveData(this IAttDatapointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "data");
    }
    #endregion

  }

}