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
    /// <symName/>
    /// </summary>
    public class SymName : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public SymName() : base("symName") { }

        public SymName(object _content) : base("symName", _content) { }

        public SymName(params object[] _content) : base("symName", _content) { }


        
    }
}
