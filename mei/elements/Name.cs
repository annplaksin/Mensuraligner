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
    /// <name/>
    /// </summary>
    public class Name : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttName, IAttAuthorized, IAttCanonical, IAttDatable, IAttFiling
    {
        
        public Name() : base("name") { }

        public Name(object _content) : base("name", _content) { }

        public Name(params object[] _content) : base("name", _content) { }


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

        #region subtype
    
    public void SetSubtype(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "subtype", _val);
    }

    public XAttribute GetSubtypeAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "subtype");
    }
    
    public string GetSubtypeValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "subtype");
    }
    
    public bool HasSubtype()
    {
      return MeiAtt_controller.HasAttribute(this, "subtype");
    }

    public void RemoveSubtype()
    {
      MeiAtt_controller.RemoveAttribute(this, "subtype");
    }
    #endregion

    }
}
