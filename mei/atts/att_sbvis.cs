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
  /// Interface for att.sb.vis
  /// </summary>
  public interface IAttSbVis : IMEiAtt, IAttAltsym, IAttTypography
  {

  }


    /// <summary>
  /// Extension methods for att.sb.vis
  /// </summary>
  public static class AttSbVis_extensions
  {
    #region form
    
    public static void SetForm(this IAttSbVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetFormAttribute(this IAttSbVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }
    
    public static string GetFormValue(this IAttSbVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "form");
    }
    
    public static bool HasForm(this IAttSbVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttSbVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

  }

}