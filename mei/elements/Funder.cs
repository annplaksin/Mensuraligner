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
    /// <funder/>
    /// </summary>
    public class Funder : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Funder() : base("funder") { }

        public Funder(object _content) : base("funder", _content) { }

        public Funder(params object[] _content) : base("funder", _content) { }


        
    }
}
