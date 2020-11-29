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
    /// <expan/>
    /// </summary>
    public class Expan : MeiElement, IAttCommon, IAttEdit, IAttResponsibility, IAttSource, IAttLang, IAttHandident, IAttSequence, IAttTyped
    {
        
        public Expan() : base("expan") { }

        public Expan(object _content) : base("expan", _content) { }

        public Expan(params object[] _content) : base("expan", _content) { }


        #region abbr
    
    public void SetAbbr(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "abbr", _val);
    }

    public XAttribute GetAbbrAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "abbr");
    }

    public string GetAbbrValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "abbr");
    }

    public bool HasAbbr()
    {
      return MeiAtt_controller.HasAttribute(this, "abbr");
    }

    public void RemoveAbbr()
    {
      MeiAtt_controller.RemoveAttribute(this, "abbr");
    }
    #endregion

    }
}
