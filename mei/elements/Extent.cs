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
    /// <extent/>
    /// </summary>
    public class Extent : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttMeasurement
    {
        
        public Extent() : base("extent") { }

        public Extent(object _content) : base("extent", _content) { }

        public Extent(params object[] _content) : base("extent", _content) { }


        
    }
}
