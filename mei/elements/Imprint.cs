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
    /// <imprint/>
    /// </summary>
    public class Imprint : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public Imprint() : base("imprint") { }

        public Imprint(object _content) : base("imprint", _content) { }

        public Imprint(params object[] _content) : base("imprint", _content) { }


        
    }
}
