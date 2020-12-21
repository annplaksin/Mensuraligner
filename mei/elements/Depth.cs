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
    /// <depth/>
    /// </summary>
    public class Depth : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttQuantity, IAttMeasurement
    {
        
        public Depth() : base("depth") { }

        public Depth(object _content) : base("depth", _content) { }

        public Depth(params object[] _content) : base("depth", _content) { }


        
    }
}
