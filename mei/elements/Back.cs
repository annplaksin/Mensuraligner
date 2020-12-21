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
    /// <back/>
    /// </summary>
    public class Back : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttLang
    {
        
        public Back() : base("back") { }

        public Back(object _content) : base("back", _content) { }

        public Back(params object[] _content) : base("back", _content) { }


        
    }
}
