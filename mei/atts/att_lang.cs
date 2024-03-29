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
  /// Interface for att.lang
  /// </summary>
  public interface IAttLang : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lang
  /// </summary>
  public static class AttLang_extensions
  {
    #region xml:lang
    
    public static void SetLang(this IAttLang e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xml:lang", _val);
    }

    public static XAttribute GetLangAttribute(this IAttLang e)
    {
      return MeiAtt_controller.GetAttribute(e, "xml:lang");
    }
    
    public static string GetLangValue(this IAttLang e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "xml:lang");
    }
    
    public static bool HasLang(this IAttLang e)
    {
      return MeiAtt_controller.HasAttribute(e, "xml:lang");
    }

    public static void RemoveLang(this IAttLang e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xml:lang");
    }
    #endregion

    #region translit
    
    public static void SetTranslit(this IAttLang e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "translit", _val);
    }

    public static XAttribute GetTranslitAttribute(this IAttLang e)
    {
      return MeiAtt_controller.GetAttribute(e, "translit");
    }
    
    public static string GetTranslitValue(this IAttLang e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "translit");
    }
    
    public static bool HasTranslit(this IAttLang e)
    {
      return MeiAtt_controller.HasAttribute(e, "translit");
    }

    public static void RemoveTranslit(this IAttLang e)
    {
      MeiAtt_controller.RemoveAttribute(e, "translit");
    }
    #endregion

  }

}