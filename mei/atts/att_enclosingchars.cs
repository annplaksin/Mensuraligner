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
  /// Interface for att.enclosingchars
  /// </summary>
  public interface IAttEnclosingchars : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.enclosingchars
  /// </summary>
  public static class AttEnclosingchars_extensions
  {
    #region enclose
    
    public static void SetEnclose(this IAttEnclosingchars e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "enclose", _val);
    }

    public static XAttribute GetEncloseAttribute(this IAttEnclosingchars e)
    {
      return MeiAtt_controller.GetAttribute(e, "enclose");
    }
    
    public static string GetEncloseValue(this IAttEnclosingchars e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "enclose");
    }
    
    public static bool HasEnclose(this IAttEnclosingchars e)
    {
      return MeiAtt_controller.HasAttribute(e, "enclose");
    }

    public static void RemoveEnclose(this IAttEnclosingchars e)
    {
      MeiAtt_controller.RemoveAttribute(e, "enclose");
    }
    #endregion

  }

}