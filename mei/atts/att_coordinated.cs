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
  /// Interface for att.coordinated
  /// </summary>
  public interface IAttCoordinated : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.coordinated
  /// </summary>
  public static class AttCoordinated_extensions
  {
    #region ulx
    
    public static void SetUlx(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ulx", _val);
    }

    public static XAttribute GetUlxAttribute(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "ulx");
    }
    
    public static string GetUlxValue(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "ulx");
    }
    
    public static bool HasUlx(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "ulx");
    }

    public static void RemoveUlx(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ulx");
    }
    #endregion

    #region uly
    
    public static void SetUly(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "uly", _val);
    }

    public static XAttribute GetUlyAttribute(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "uly");
    }
    
    public static string GetUlyValue(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "uly");
    }
    
    public static bool HasUly(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "uly");
    }

    public static void RemoveUly(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "uly");
    }
    #endregion

    #region lrx
    
    public static void SetLrx(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lrx", _val);
    }

    public static XAttribute GetLrxAttribute(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "lrx");
    }
    
    public static string GetLrxValue(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lrx");
    }
    
    public static bool HasLrx(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "lrx");
    }

    public static void RemoveLrx(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lrx");
    }
    #endregion

    #region lry
    
    public static void SetLry(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lry", _val);
    }

    public static XAttribute GetLryAttribute(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "lry");
    }
    
    public static string GetLryValue(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lry");
    }
    
    public static bool HasLry(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "lry");
    }

    public static void RemoveLry(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lry");
    }
    #endregion

  }

}