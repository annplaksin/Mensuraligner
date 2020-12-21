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
    /// <abbr/>
    /// </summary>
    public class Abbr : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttHandident, IAttSequence, IAttTyped
    {
        
        public Abbr() : base("abbr") { }

        public Abbr(object _content) : base("abbr", _content) { }

        public Abbr(params object[] _content) : base("abbr", _content) { }


        #region expan
    
    public void SetExpan(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "expan", _val);
    }

    public XAttribute GetExpanAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "expan");
    }
    
    public string GetExpanValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "expan");
    }
    
    public bool HasExpan()
    {
      return MeiAtt_controller.HasAttribute(this, "expan");
    }

    public void RemoveExpan()
    {
      MeiAtt_controller.RemoveAttribute(this, "expan");
    }
    #endregion

    }
}
