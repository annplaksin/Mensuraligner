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
    /// <normalization/>
    /// </summary>
    public class Normalization : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatapointing, IAttLang, IAttRegularmethod
    {
        
        public Normalization() : base("normalization") { }

        public Normalization(object _content) : base("normalization", _content) { }

        public Normalization(params object[] _content) : base("normalization", _content) { }


        
    }
}
