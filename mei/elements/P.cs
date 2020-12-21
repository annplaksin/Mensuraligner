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
    /// <p/>
    /// </summary>
    public class P : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttLang, IAttXy
    {
        
        public P() : base("p") { }

        public P(object _content) : base("p", _content) { }

        public P(params object[] _content) : base("p", _content) { }


        
    }
}
