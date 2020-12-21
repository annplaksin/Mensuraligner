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
    /// <pb/>
    /// </summary>
    public class Pb : MeiElement, IAttCommon, IAttCommonPart, IAttPointing, IAttSource, IAttCommonAnl, IAttPbVis
    {
        
        public Pb() : base("pb") { }

        public Pb(object _content) : base("pb", _content) { }

        public Pb(params object[] _content) : base("pb", _content) { }


        
    }
}
