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
    /// <postCode/>
    /// </summary>
    public class PostCode : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public PostCode() : base("postCode") { }

        public PostCode(object _content) : base("postCode", _content) { }

        public PostCode(params object[] _content) : base("postCode", _content) { }


        
    }
}