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
    /// <height/>
    /// </summary>
    public class Height : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttQuantity, IAttMeasurement
    {
        
        public Height() : base("height") { }

        public Height(object _content) : base("height", _content) { }

        public Height(params object[] _content) : base("height", _content) { }


        
    }
}
