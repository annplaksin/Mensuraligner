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
    /// <term/>
    /// </summary>
    public class Term : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttClasscodeident, IAttLang, IAttTyped
    {
        
        public Term() : base("term") { }

        public Term(object _content) : base("term", _content) { }

        public Term(params object[] _content) : base("term", _content) { }


        
    }
}
