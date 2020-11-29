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
  /// Interface for att.horizontalalign
  /// </summary>
  public interface IAttHorizontalalign : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.horizontalalign
  /// </summary>
  public static class AttHorizontalalign_extensions
  {
    #region halign
    
    public static void SetHalign(this IAttHorizontalalign e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "halign", _val);
    }

    public static XAttribute GetHalignAttribute(this IAttHorizontalalign e)
    {
      return MeiAtt_controller.GetAttribute(e, "halign");
    }

    public static string GetHalignValue(this IAttHorizontalalign e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "halign");
    }

    public static bool HasHalign(this IAttHorizontalalign e)
    {
      return MeiAtt_controller.HasAttribute(e, "halign");
    }

    public static void RemoveHalign(this IAttHorizontalalign e)
    {
      MeiAtt_controller.RemoveAttribute(e, "halign");
    }
    #endregion

  }

}