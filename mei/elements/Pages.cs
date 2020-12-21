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
    /// <pages/>
    /// </summary>
    public class Pages : MeiElement, IAttCommon, IAttCommonPart, IAttCommonAnl, IAttPages, IAttSpacing, IAttSystems, IAttTyped
    {
        
        public Pages() : base("pages") { }

        public Pages(object _content) : base("pages", _content) { }

        public Pages(params object[] _content) : base("pages", _content) { }


        
    }
}
