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
  /// Interface for att.regularmethod
  /// </summary>
  public interface IAttRegularmethod : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.regularmethod
  /// </summary>
  public static class AttRegularmethod_extensions
  {
    #region method
    
    public static void SetMethod(this IAttRegularmethod e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "method", _val);
    }

    public static XAttribute GetMethodAttribute(this IAttRegularmethod e)
    {
      return MeiAtt_controller.GetAttribute(e, "method");
    }
    
    public static string GetMethodValue(this IAttRegularmethod e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "method");
    }
    
    public static bool HasMethod(this IAttRegularmethod e)
    {
      return MeiAtt_controller.HasAttribute(e, "method");
    }

    public static void RemoveMethod(this IAttRegularmethod e)
    {
      MeiAtt_controller.RemoveAttribute(e, "method");
    }
    #endregion

  }

}