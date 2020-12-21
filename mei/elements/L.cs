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
    /// <l/>
    /// </summary>
    public class L : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public L() : base("l") { }

        public L(object _content) : base("l", _content) { }

        public L(params object[] _content) : base("l", _content) { }


        
    }
}
