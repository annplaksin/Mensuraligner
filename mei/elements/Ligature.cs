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
    /// <ligature/>
    /// </summary>
    public class Ligature : MeiElement, IAttCommon, IAttCommonPart, IAttLigatureLog, IAttCommonAnl
    {
        
        public Ligature() : base("ligature") { }

        public Ligature(object _content) : base("ligature", _content) { }

        public Ligature(params object[] _content) : base("ligature", _content) { }


        
    }
}
