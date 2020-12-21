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
    /// <classification/>
    /// </summary>
    public class Classification : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatapointing
    {
        
        public Classification() : base("classification") { }

        public Classification(object _content) : base("classification", _content) { }

        public Classification(params object[] _content) : base("classification", _content) { }


        
    }
}
