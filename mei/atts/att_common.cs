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
  /// Interface for att.common
  /// </summary>
  public interface IAttCommon : IMEiAtt, IAttCommonPart
  {

  }


    /// <summary>
  /// Extension methods for att.common
  /// </summary>
  public static class AttCommon_extensions
  {
    #region n
    
    public static void SetN(this IAttCommon e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "n", _val);
    }

    public static XAttribute GetNAttribute(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttribute(e, "n");
    }
    
    public static string GetNValue(this IAttCommon e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "n");
    }
    
    public static bool HasN(this IAttCommon e)
    {
      return MeiAtt_controller.HasAttribute(e, "n");
    }

    public static void RemoveN(this IAttCommon e)
    {
      MeiAtt_controller.RemoveAttribute(e, "n");
    }
    #endregion

  }

}