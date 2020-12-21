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
    /// <creation/>
    /// </summary>
    public class Creation : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Creation() : base("creation") { }

        public Creation(object _content) : base("creation", _content) { }

        public Creation(params object[] _content) : base("creation", _content) { }


        
    }
}
