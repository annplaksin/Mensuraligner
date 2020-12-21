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
  /// Interface for att.labels.addl
  /// </summary>
  public interface IAttLabelsAddl : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.labels.addl
  /// </summary>
  public static class AttLabelsAddl_extensions
  {
    #region label.abbr
    
    public static void SetLabelAbbr(this IAttLabelsAddl e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "label.abbr", _val);
    }

    public static XAttribute GetLabelAbbrAttribute(this IAttLabelsAddl e)
    {
      return MeiAtt_controller.GetAttribute(e, "label.abbr");
    }
    
    public static string GetLabelAbbrValue(this IAttLabelsAddl e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "label.abbr");
    }
    
    public static bool HasLabelAbbr(this IAttLabelsAddl e)
    {
      return MeiAtt_controller.HasAttribute(e, "label.abbr");
    }

    public static void RemoveLabelAbbr(this IAttLabelsAddl e)
    {
      MeiAtt_controller.RemoveAttribute(e, "label.abbr");
    }
    #endregion

  }

}