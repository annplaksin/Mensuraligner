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
    /// <music/>
    /// </summary>
    public class Music : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttMeiversion
    {
        
        public Music() : base("music") { }

        public Music(object _content) : base("music", _content) { }

        public Music(params object[] _content) : base("music", _content) { }


        
    }
}
