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
  /// Interface for att.pb.vis
  /// </summary>
  public interface IAttPbVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pb.vis
  /// </summary>
  public static class AttPbVis_extensions
  {
    #region func
    
    public static void SetFunc(this IAttPbVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "func", _val);
    }

    public static XAttribute GetFuncAttribute(this IAttPbVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "func");
    }

    public static string GetFuncValue(this IAttPbVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "func");
    }

    public static bool HasFunc(this IAttPbVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "func");
    }

    public static void RemoveFunc(this IAttPbVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "func");
    }
    #endregion

  }

}