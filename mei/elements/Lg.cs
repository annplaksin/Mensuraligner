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
    /// <lg/>
    /// </summary>
    public class Lg : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttLang, IAttTyped, IAttXy
    {
        
        public Lg() : base("lg") { }

        public Lg(object _content) : base("lg", _content) { }

        public Lg(params object[] _content) : base("lg", _content) { }


        
    }
}
