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
  /// Interface for att.linerend
  /// </summary>
  public interface IAttLinerend : IMEiAtt, IAttLinerendBase
  {

  }


    /// <summary>
  /// Extension methods for att.linerend
  /// </summary>
  public static class AttLinerend_extensions
  {
    #region lendsym
    
    public static void SetLendsym(this IAttLinerend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lendsym", _val);
    }

    public static XAttribute GetLendsymAttribute(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lendsym");
    }
    
    public static string GetLendsymValue(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lendsym");
    }
    
    public static bool HasLendsym(this IAttLinerend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lendsym");
    }

    public static void RemoveLendsym(this IAttLinerend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lendsym");
    }
    #endregion

    #region lendsymsize
    
    public static void SetLendsymsize(this IAttLinerend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lendsymsize", _val);
    }

    public static XAttribute GetLendsymsizeAttribute(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lendsymsize");
    }
    
    public static string GetLendsymsizeValue(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lendsymsize");
    }
    
    public static bool HasLendsymsize(this IAttLinerend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lendsymsize");
    }

    public static void RemoveLendsymsize(this IAttLinerend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lendsymsize");
    }
    #endregion

    #region lstartsym
    
    public static void SetLstartsym(this IAttLinerend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lstartsym", _val);
    }

    public static XAttribute GetLstartsymAttribute(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lstartsym");
    }
    
    public static string GetLstartsymValue(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lstartsym");
    }
    
    public static bool HasLstartsym(this IAttLinerend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lstartsym");
    }

    public static void RemoveLstartsym(this IAttLinerend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lstartsym");
    }
    #endregion

    #region lstartsymsize
    
    public static void SetLstartsymsize(this IAttLinerend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lstartsymsize", _val);
    }

    public static XAttribute GetLstartsymsizeAttribute(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttribute(e, "lstartsymsize");
    }
    
    public static string GetLstartsymsizeValue(this IAttLinerend e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lstartsymsize");
    }
    
    public static bool HasLstartsymsize(this IAttLinerend e)
    {
      return MeiAtt_controller.HasAttribute(e, "lstartsymsize");
    }

    public static void RemoveLstartsymsize(this IAttLinerend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lstartsymsize");
    }
    #endregion

  }

}