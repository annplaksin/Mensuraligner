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
    /// <availability/>
    /// </summary>
    public class Availability : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttDatapointing
    {
        
        public Availability() : base("availability") { }

        public Availability(object _content) : base("availability", _content) { }

        public Availability(params object[] _content) : base("availability", _content) { }


        
    }
}
