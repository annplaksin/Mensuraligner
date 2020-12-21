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
    /// <source/>
    /// </summary>
    public class Source : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatapointing, IAttPointing, IAttTargeteval
    {
        
        public Source() : base("source") { }

        public Source(object _content) : base("source", _content) { }

        public Source(params object[] _content) : base("source", _content) { }


        
    }
}
