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
    /// <label/>
    /// </summary>
    public class Label : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttSource, IAttTyped
    {
        
        public Label() : base("label") { }

        public Label(object _content) : base("label", _content) { }

        public Label(params object[] _content) : base("label", _content) { }


        
    }
}
