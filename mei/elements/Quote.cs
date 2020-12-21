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
    /// <quote/>
    /// </summary>
    public class Quote : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttTyped, IAttXy
    {
        
        public Quote() : base("quote") { }

        public Quote(object _content) : base("quote", _content) { }

        public Quote(params object[] _content) : base("quote", _content) { }


        
    }
}
