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
  /// Interface for att.mensur.vis
  /// </summary>
  public interface IAttMensurVis : IMEiAtt, IAttAltsym, IAttColor, IAttRelativesize, IAttStaffloc, IAttTypography
  {

  }


    /// <summary>
  /// Extension methods for att.mensur.vis
  /// </summary>
  public static class AttMensurVis_extensions
  {
    #region form
    
    public static void SetForm(this IAttMensurVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetFormAttribute(this IAttMensurVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }
    
    public static string GetFormValue(this IAttMensurVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "form");
    }
    
    public static bool HasForm(this IAttMensurVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttMensurVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region orient
    
    public static void SetOrient(this IAttMensurVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "orient", _val);
    }

    public static XAttribute GetOrientAttribute(this IAttMensurVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "orient");
    }
    
    public static string GetOrientValue(this IAttMensurVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "orient");
    }
    
    public static bool HasOrient(this IAttMensurVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "orient");
    }

    public static void RemoveOrient(this IAttMensurVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "orient");
    }
    #endregion

  }

}