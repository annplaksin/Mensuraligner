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
  /// Interface for att.multinummeasures
  /// </summary>
  public interface IAttMultinummeasures : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.multinummeasures
  /// </summary>
  public static class AttMultinummeasures_extensions
  {
    #region multi.number
    
    public static void SetMultiNumber(this IAttMultinummeasures e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "multi.number", _val);
    }

    public static XAttribute GetMultiNumberAttribute(this IAttMultinummeasures e)
    {
      return MeiAtt_controller.GetAttribute(e, "multi.number");
    }

    public static string GetMultiNumberValue(this IAttMultinummeasures e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "multi.number");
    }

    public static bool HasMultiNumber(this IAttMultinummeasures e)
    {
      return MeiAtt_controller.HasAttribute(e, "multi.number");
    }

    public static void RemoveMultiNumber(this IAttMultinummeasures e)
    {
      MeiAtt_controller.RemoveAttribute(e, "multi.number");
    }
    #endregion

  }

}