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
  /// Interface for att.fermatapresent
  /// </summary>
  public interface IAttFermatapresent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.fermatapresent
  /// </summary>
  public static class AttFermatapresent_extensions
  {
    #region fermata
    
    public static void SetFermata(this IAttFermatapresent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fermata", _val);
    }

    public static XAttribute GetFermataAttribute(this IAttFermatapresent e)
    {
      return MeiAtt_controller.GetAttribute(e, "fermata");
    }
    
    public static string GetFermataValue(this IAttFermatapresent e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "fermata");
    }
    
    public static bool HasFermata(this IAttFermatapresent e)
    {
      return MeiAtt_controller.HasAttribute(e, "fermata");
    }

    public static void RemoveFermata(this IAttFermatapresent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fermata");
    }
    #endregion

  }

}