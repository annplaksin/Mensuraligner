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
    /// <extMeta/>
    /// </summary>
    public class ExtMeta : MeiElement, IAttCommon, IAttCommonPart, IAttWhitespace
    {
        
        public ExtMeta() : base("extMeta") { }

        public ExtMeta(object _content) : base("extMeta", _content) { }

        public ExtMeta(params object[] _content) : base("extMeta", _content) { }


        
    }
}
