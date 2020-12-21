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
    /// <street/>
    /// </summary>
    public class Street : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public Street() : base("street") { }

        public Street(object _content) : base("street", _content) { }

        public Street(params object[] _content) : base("street", _content) { }


        
    }
}
