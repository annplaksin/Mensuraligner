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
  /// Interface for att.canonical
  /// </summary>
  public interface IAttCanonical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.canonical
  /// </summary>
  public static class AttCanonical_extensions
  {
    #region codedval
    
    public static void SetCodedval(this IAttCanonical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "codedval", _val);
    }

    public static XAttribute GetCodedvalAttribute(this IAttCanonical e)
    {
      return MeiAtt_controller.GetAttribute(e, "codedval");
    }
    
    public static string GetCodedvalValue(this IAttCanonical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "codedval");
    }
    
    public static bool HasCodedval(this IAttCanonical e)
    {
      return MeiAtt_controller.HasAttribute(e, "codedval");
    }

    public static void RemoveCodedval(this IAttCanonical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "codedval");
    }
    #endregion

  }

}