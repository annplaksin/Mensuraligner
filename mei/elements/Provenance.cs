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
    /// <provenance/>
    /// </summary>
    public class Provenance : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Provenance() : base("provenance") { }

        public Provenance(object _content) : base("provenance", _content) { }

        public Provenance(params object[] _content) : base("provenance", _content) { }


        
    }
}
