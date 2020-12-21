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
    /// <mapping/>
    /// </summary>
    public class Mapping : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttTyped
    {
        
        public Mapping() : base("mapping") { }

        public Mapping(object _content) : base("mapping", _content) { }

        public Mapping(params object[] _content) : base("mapping", _content) { }


        
    }
}
