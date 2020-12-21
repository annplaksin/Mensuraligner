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
    /// <inscription/>
    /// </summary>
    public class Inscription : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Inscription() : base("inscription") { }

        public Inscription(object _content) : base("inscription", _content) { }

        public Inscription(params object[] _content) : base("inscription", _content) { }


        
    }
}
