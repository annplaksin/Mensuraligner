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
    /// <title/>
    /// </summary>
    public class Title : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttCanonical, IAttFiling, IAttLang
    {
        
        public Title() : base("title") { }

        public Title(object _content) : base("title", _content) { }

        public Title(params object[] _content) : base("title", _content) { }


        #region level
    
    public void SetLevel(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "level", _val);
    }

    public XAttribute GetLevelAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "level");
    }
    
    public string GetLevelValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "level");
    }
    
    public bool HasLevel()
    {
      return MeiAtt_controller.HasAttribute(this, "level");
    }

    public void RemoveLevel()
    {
      MeiAtt_controller.RemoveAttribute(this, "level");
    }
    #endregion

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
