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
    /// <bibl/>
    /// </summary>
    public class Bibl : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttPointing, IAttTyped
    {
        
        public Bibl() : base("bibl") { }

        public Bibl(object _content) : base("bibl", _content) { }

        public Bibl(params object[] _content) : base("bibl", _content) { }


        
    }
}
