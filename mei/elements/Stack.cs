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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <stack/>
    /// </summary>
    public class Stack : MeiElement, IAttCommon, IAttLang
    {
        
        public Stack() : base("stack") { }

        public Stack(object _content) : base("stack", _content) { }

        public Stack(params object[] _content) : base("stack", _content) { }


        #region delim
    
    public void SetDelim(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "delim", _val);
    }

    public XAttribute GetDelimAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "delim");
    }

    public string GetDelimValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "delim");
    }

    public bool HasDelim()
    {
      return MeiAtt_controller.HasAttribute(this, "delim");
    }

    public void RemoveDelim()
    {
      MeiAtt_controller.RemoveAttribute(this, "delim");
    }
    #endregion

        #region align
    
    public void SetAlign(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "align", _val);
    }

    public XAttribute GetAlignAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "align");
    }

    public string GetAlignValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "align");
    }

    public bool HasAlign()
    {
      return MeiAtt_controller.HasAttribute(this, "align");
    }

    public void RemoveAlign()
    {
      MeiAtt_controller.RemoveAttribute(this, "align");
    }
    #endregion

    }
}
