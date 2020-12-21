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
    /// <textLang/>
    /// </summary>
    public class TextLang : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public TextLang() : base("textLang") { }

        public TextLang(object _content) : base("textLang", _content) { }

        public TextLang(params object[] _content) : base("textLang", _content) { }


        #region mainLang
    
    public void SetMainLang(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "mainLang", _val);
    }

    public XAttribute GetMainLangAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "mainLang");
    }
    
    public string GetMainLangValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "mainLang");
    }
    
    public bool HasMainLang()
    {
      return MeiAtt_controller.HasAttribute(this, "mainLang");
    }

    public void RemoveMainLang()
    {
      MeiAtt_controller.RemoveAttribute(this, "mainLang");
    }
    #endregion

        #region otherLangs
    
    public void SetOtherLangs(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "otherLangs", _val);
    }

    public XAttribute GetOtherLangsAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "otherLangs");
    }
    
    public string GetOtherLangsValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "otherLangs");
    }
    
    public bool HasOtherLangs()
    {
      return MeiAtt_controller.HasAttribute(this, "otherLangs");
    }

    public void RemoveOtherLangs()
    {
      MeiAtt_controller.RemoveAttribute(this, "otherLangs");
    }
    #endregion

    }
}
