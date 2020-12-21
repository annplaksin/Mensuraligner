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
    /// <edition/>
    /// </summary>
    public class Edition : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Edition() : base("edition") { }

        public Edition(object _content) : base("edition", _content) { }

        public Edition(params object[] _content) : base("edition", _content) { }


        
    }
}
