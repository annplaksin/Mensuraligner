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
    /// <instrVoice/>
    /// </summary>
    public class InstrVoice : MeiElement, IAttCommon, IAttAuthorized, IAttBibl, IAttCoded
    {
        
        public InstrVoice() : base("instrVoice") { }

        public InstrVoice(object _content) : base("instrVoice", _content) { }

        public InstrVoice(params object[] _content) : base("instrVoice", _content) { }


        #region count
    
    public void SetCount(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "count", _val);
    }

    public XAttribute GetCountAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "count");
    }

    public string GetCountValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "count");
    }

    public bool HasCount()
    {
      return MeiAtt_controller.HasAttribute(this, "count");
    }

    public void RemoveCount()
    {
      MeiAtt_controller.RemoveAttribute(this, "count");
    }
    #endregion

        #region solo
    
    public void SetSolo(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "solo", _val);
    }

    public XAttribute GetSoloAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "solo");
    }

    public string GetSoloValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "solo");
    }

    public bool HasSolo()
    {
      return MeiAtt_controller.HasAttribute(this, "solo");
    }

    public void RemoveSolo()
    {
      MeiAtt_controller.RemoveAttribute(this, "solo");
    }
    #endregion

    }
}
