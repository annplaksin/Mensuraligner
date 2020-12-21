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
    /// <postBox/>
    /// </summary>
    public class PostBox : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public PostBox() : base("postBox") { }

        public PostBox(object _content) : base("postBox", _content) { }

        public PostBox(params object[] _content) : base("postBox", _content) { }


        
    }
}
