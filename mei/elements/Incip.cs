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
    /// <incip/>
    /// </summary>
    public class Incip : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttTyped
    {
        
        public Incip() : base("incip") { }

        public Incip(object _content) : base("incip", _content) { }

        public Incip(params object[] _content) : base("incip", _content) { }


        
    }
}
