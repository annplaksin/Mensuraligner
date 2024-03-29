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
  /// Interface for att.keySigDefault.vis
  /// </summary>
  public interface IAttKeySigDefaultVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.keySigDefault.vis
  /// </summary>
  public static class AttKeySigDefaultVis_extensions
  {
    #region key.sig.show
    
    public static void SetKeySigShow(this IAttKeySigDefaultVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.sig.show", _val);
    }

    public static XAttribute GetKeySigShowAttribute(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.sig.show");
    }
    
    public static string GetKeySigShowValue(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.sig.show");
    }
    
    public static bool HasKeySigShow(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.sig.show");
    }

    public static void RemoveKeySigShow(this IAttKeySigDefaultVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.sig.show");
    }
    #endregion

    #region key.sig.showchange
    
    public static void SetKeySigShowchange(this IAttKeySigDefaultVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.sig.showchange", _val);
    }

    public static XAttribute GetKeySigShowchangeAttribute(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.sig.showchange");
    }
    
    public static string GetKeySigShowchangeValue(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.sig.showchange");
    }
    
    public static bool HasKeySigShowchange(this IAttKeySigDefaultVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.sig.showchange");
    }

    public static void RemoveKeySigShowchange(this IAttKeySigDefaultVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.sig.showchange");
    }
    #endregion

  }

}