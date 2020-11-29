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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <name/>
    /// </summary>
    public class Name : MeiElement, IAttBibl, IAttCommon, IAttLang, IAttName, IAttAuthorized, IAttCanonical, IAttTyped
    {
        
        public Name() : base("name") { }

        public Name(object _content) : base("name", _content) { }

        public Name(params object[] _content) : base("name", _content) { }


        
    }
}
