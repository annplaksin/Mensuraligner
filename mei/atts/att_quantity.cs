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
  /// Interface for att.quantity
  /// </summary>
  public interface IAttQuantity : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.quantity
  /// </summary>
  public static class AttQuantity_extensions
  {
    #region quantity
    
    public static void SetQuantity(this IAttQuantity e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "quantity", _val);
    }

    public static XAttribute GetQuantityAttribute(this IAttQuantity e)
    {
      return MeiAtt_controller.GetAttribute(e, "quantity");
    }
    
    public static string GetQuantityValue(this IAttQuantity e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "quantity");
    }
    
    public static bool HasQuantity(this IAttQuantity e)
    {
      return MeiAtt_controller.HasAttribute(e, "quantity");
    }

    public static void RemoveQuantity(this IAttQuantity e)
    {
      MeiAtt_controller.RemoveAttribute(e, "quantity");
    }
    #endregion

  }

}