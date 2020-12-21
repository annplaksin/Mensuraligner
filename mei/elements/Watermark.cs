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
    /// <watermark/>
    /// </summary>
    public class Watermark : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Watermark() : base("watermark") { }

        public Watermark(object _content) : base("watermark", _content) { }

        public Watermark(params object[] _content) : base("watermark", _content) { }


        
    }
}
