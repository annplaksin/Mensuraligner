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
    /// <dimensions/>
    /// </summary>
    public class Dimensions : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttMeasurement
    {
        
        public Dimensions() : base("dimensions") { }

        public Dimensions(object _content) : base("dimensions", _content) { }

        public Dimensions(params object[] _content) : base("dimensions", _content) { }


        
    }
}
