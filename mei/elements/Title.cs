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
    /// <title/>
    /// </summary>
    public class Title : MeiElement, IAttCommon, IAttAuthorized, IAttCanonical, IAttBibl, IAttLang, IAttTyped
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

    }
}
