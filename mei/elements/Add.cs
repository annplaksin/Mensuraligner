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
    /// <add/>
    /// </summary>
    public class Add : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttHandident, IAttSequence, IAttTyped
    {
        
        public Add() : base("add") { }

        public Add(object _content) : base("add", _content) { }

        public Add(params object[] _content) : base("add", _content) { }


        #region method
    
    public void SetMethod(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "method", _val);
    }

    public XAttribute GetMethodAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "method");
    }
    
    public string GetMethodValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "method");
    }
    
    public bool HasMethod()
    {
      return MeiAtt_controller.HasAttribute(this, "method");
    }

    public void RemoveMethod()
    {
      MeiAtt_controller.RemoveAttribute(this, "method");
    }
    #endregion

    }
}
