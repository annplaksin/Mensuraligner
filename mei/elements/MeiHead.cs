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
    /// <meiHead/>
    /// </summary>
    public class MeiHead : MeiElement, IAttBibl, IAttCommon, IAttLang, IAttMeiversion
    {
        
        public MeiHead() : base("meiHead") { }

        public MeiHead(object _content) : base("meiHead", _content) { }

        public MeiHead(params object[] _content) : base("meiHead", _content) { }


        #region type
    
    public void SetType(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "type", _val);
    }

    public XAttribute GetTypeAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "type");
    }

    public string GetTypeValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "type");
    }

    public bool HasType()
    {
      return MeiAtt_controller.HasAttribute(this, "type");
    }

    public void RemoveType()
    {
      MeiAtt_controller.RemoveAttribute(this, "type");
    }
    #endregion

    }
}
