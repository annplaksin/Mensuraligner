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
    /// <num/>
    /// </summary>
    public class Num : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttMeasurement, IAttTyped
    {
        
        public Num() : base("num") { }

        public Num(object _content) : base("num", _content) { }

        public Num(params object[] _content) : base("num", _content) { }


        #region value
    
    public void SetValue(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "value", _val);
    }

    public XAttribute GetValueAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "value");
    }
    
    public string GetValueValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "value");
    }
    
    public bool HasValue()
    {
      return MeiAtt_controller.HasAttribute(this, "value");
    }

    public void RemoveValue()
    {
      MeiAtt_controller.RemoveAttribute(this, "value");
    }
    #endregion

    }
}
