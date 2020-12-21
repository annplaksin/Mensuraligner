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
  /// Interface for att.declaring
  /// </summary>
  public interface IAttDeclaring : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.declaring
  /// </summary>
  public static class AttDeclaring_extensions
  {
    #region decls
    
    public static void SetDecls(this IAttDeclaring e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "decls", _val);
    }

    public static XAttribute GetDeclsAttribute(this IAttDeclaring e)
    {
      return MeiAtt_controller.GetAttribute(e, "decls");
    }
    
    public static string GetDeclsValue(this IAttDeclaring e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "decls");
    }
    
    public static bool HasDecls(this IAttDeclaring e)
    {
      return MeiAtt_controller.HasAttribute(e, "decls");
    }

    public static void RemoveDecls(this IAttDeclaring e)
    {
      MeiAtt_controller.RemoveAttribute(e, "decls");
    }
    #endregion

  }

}