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
  /// Interface for att.meiversion
  /// </summary>
  public interface IAttMeiversion : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.meiversion
  /// </summary>
  public static class AttMeiversion_extensions
  {
    #region meiversion
    
    public static void SetMeiversion(this IAttMeiversion e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "meiversion", _val);
    }

    public static XAttribute GetMeiversionAttribute(this IAttMeiversion e)
    {
      return MeiAtt_controller.GetAttribute(e, "meiversion");
    }
    
    public static string GetMeiversionValue(this IAttMeiversion e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "meiversion");
    }
    
    public static bool HasMeiversion(this IAttMeiversion e)
    {
      return MeiAtt_controller.HasAttribute(e, "meiversion");
    }

    public static void RemoveMeiversion(this IAttMeiversion e)
    {
      MeiAtt_controller.RemoveAttribute(e, "meiversion");
    }
    #endregion

  }

}