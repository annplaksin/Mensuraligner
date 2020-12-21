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
    /// <publisher/>
    /// </summary>
    public class Publisher : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Publisher() : base("publisher") { }

        public Publisher(object _content) : base("publisher", _content) { }

        public Publisher(params object[] _content) : base("publisher", _content) { }


        
    }
}
