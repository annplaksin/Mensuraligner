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
    /// <castItem/>
    /// </summary>
    public class CastItem : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public CastItem() : base("castItem") { }

        public CastItem(object _content) : base("castItem", _content) { }

        public CastItem(params object[] _content) : base("castItem", _content) { }


        
    }
}
