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
    /// <body/>
    /// </summary>
    public class Body : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring
    {
        
        public Body() : base("body") { }

        public Body(object _content) : base("body", _content) { }

        public Body(params object[] _content) : base("body", _content) { }


        
    }
}
