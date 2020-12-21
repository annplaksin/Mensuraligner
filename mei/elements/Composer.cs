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
    /// <composer/>
    /// </summary>
    public class Composer : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttTyped
    {
        
        public Composer() : base("composer") { }

        public Composer(object _content) : base("composer", _content) { }

        public Composer(params object[] _content) : base("composer", _content) { }


        
    }
}
