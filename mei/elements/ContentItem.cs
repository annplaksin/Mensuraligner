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
    /// <contentItem/>
    /// </summary>
    public class ContentItem : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public ContentItem() : base("contentItem") { }

        public ContentItem(object _content) : base("contentItem", _content) { }

        public ContentItem(params object[] _content) : base("contentItem", _content) { }


        
    }
}
