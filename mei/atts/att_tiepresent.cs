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
  /// Interface for att.tiepresent
  /// </summary>
  public interface IAttTiepresent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.tiepresent
  /// </summary>
  public static class AttTiepresent_extensions
  {
    #region tie
    
    public static void SetTie(this IAttTiepresent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tie", _val);
    }

    public static XAttribute GetTieAttribute(this IAttTiepresent e)
    {
      return MeiAtt_controller.GetAttribute(e, "tie");
    }

    public static string GetTieValue(this IAttTiepresent e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tie");
    }

    public static bool HasTie(this IAttTiepresent e)
    {
      return MeiAtt_controller.HasAttribute(e, "tie");
    }

    public static void RemoveTie(this IAttTiepresent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tie");
    }
    #endregion

  }

}