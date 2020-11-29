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
    /// <panel/>
    /// </summary>
    public class Panel : MeiElement, IAttCommon, IAttDeclaring, IAttCommonAnl
    {
        private static readonly XNamespace ns_panel = "http://github.com/annplaksin/mensural_sourceEncoding";

        public Panel() : base(ns_panel, "panel") { }

        public Panel(object _content) : base(ns_panel, "panel", _content) { }

        public Panel(params object[] _content) : base(ns_panel, "panel", _content) { }


        #region leftmar
    
    public void SetLeftmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "leftmar", _val);
    }

    public XAttribute GetLeftmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "leftmar");
    }

    public string GetLeftmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "leftmar");
    }

    public bool HasLeftmar()
    {
      return MeiAtt_controller.HasAttribute(this, "leftmar");
    }

    public void RemoveLeftmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "leftmar");
    }
    #endregion

        #region rightmar
    
    public void SetRightmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rightmar", _val);
    }

    public XAttribute GetRightmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "rightmar");
    }

    public string GetRightmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "rightmar");
    }

    public bool HasRightmar()
    {
      return MeiAtt_controller.HasAttribute(this, "rightmar");
    }

    public void RemoveRightmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "rightmar");
    }
    #endregion

        #region topmar
    
    public void SetTopmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "topmar", _val);
    }

    public XAttribute GetTopmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "topmar");
    }

    public string GetTopmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "topmar");
    }

    public bool HasTopmar()
    {
      return MeiAtt_controller.HasAttribute(this, "topmar");
    }

    public void RemoveTopmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "topmar");
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

    }
}
