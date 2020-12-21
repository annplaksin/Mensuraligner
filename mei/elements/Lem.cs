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
    /// <lem/>
    /// </summary>
    public class Lem : MeiElement, IAttCommon, IAttCommonPart, IAttCrit, IAttHandident, IAttResponsibility, IAttSequence, IAttSource, IAttPointing, IAttCommonAnl, IAttTargeteval, IAttTyped
    {
        
        public Lem() : base("lem") { }

        public Lem(object _content) : base("lem", _content) { }

        public Lem(params object[] _content) : base("lem", _content) { }


        
    }
}
