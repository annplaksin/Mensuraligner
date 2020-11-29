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
    /// <symbol/>
    /// </summary>
    public class Symbol : MeiElement, IAttCommonAnl, IAttColor, IAttCommon, IAttScalable, IAttStartid, IAttTyped, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy
    {
        
        public Symbol() : base("symbol") { }

        public Symbol(object _content) : base("symbol", _content) { }

        public Symbol(params object[] _content) : base("symbol", _content) { }


        #region ref
    
    public void SetRef(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "ref", _val);
    }

    public XAttribute GetRefAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "ref");
    }

    public string GetRefValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "ref");
    }

    public bool HasRef()
    {
      return MeiAtt_controller.HasAttribute(this, "ref");
    }

    public void RemoveRef()
    {
      MeiAtt_controller.RemoveAttribute(this, "ref");
    }
    #endregion

    }
}
