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
    /// <del/>
    /// </summary>
    public class Del : MeiElement, IAttCommon, IAttHandident, IAttSequence
    {
        
        public Del() : base("del") { }

        public Del(object _content) : base("del", _content) { }

        public Del(params object[] _content) : base("del", _content) { }


        #region rend
    
    public void SetRend(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rend", _val);
    }

    public XAttribute GetRendAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "rend");
    }

    public string GetRendValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "rend");
    }

    public bool HasRend()
    {
      return MeiAtt_controller.HasAttribute(this, "rend");
    }

    public void RemoveRend()
    {
      MeiAtt_controller.RemoveAttribute(this, "rend");
    }
    #endregion

    }
}
