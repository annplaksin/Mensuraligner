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
    /// <role/>
    /// </summary>
    public class Role : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public Role() : base("role") { }

        public Role(object _content) : base("role", _content) { }

        public Role(params object[] _content) : base("role", _content) { }


        
    }
}
