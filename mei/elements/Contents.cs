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
    /// <contents/>
    /// </summary>
    public class Contents : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttPointing
    {
        
        public Contents() : base("contents") { }

        public Contents(object _content) : base("contents", _content) { }

        public Contents(params object[] _content) : base("contents", _content) { }


        
    }
}
