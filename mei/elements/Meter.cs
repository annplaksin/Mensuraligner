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
    /// <meter/>
    /// </summary>
    public class Meter : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttMeterSigLog
    {
        
        public Meter() : base("meter") { }

        public Meter(object _content) : base("meter", _content) { }

        public Meter(params object[] _content) : base("meter", _content) { }


        
    }
}
