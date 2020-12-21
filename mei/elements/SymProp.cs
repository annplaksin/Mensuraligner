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
    /// <symProp/>
    /// </summary>
    public class SymProp : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public SymProp() : base("symProp") { }

        public SymProp(object _content) : base("symProp", _content) { }

        public SymProp(params object[] _content) : base("symProp", _content) { }


        
    }
}
