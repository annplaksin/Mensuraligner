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
    /// <contentItem/>
    /// </summary>
    public class ContentItem : MeiElement, IAttBibl, IAttCommon
    {
        
        public ContentItem() : base("contentItem") { }

        public ContentItem(object _content) : base("contentItem", _content) { }

        public ContentItem(params object[] _content) : base("contentItem", _content) { }


        
    }
}
