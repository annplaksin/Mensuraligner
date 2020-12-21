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
    /// <editor/>
    /// </summary>
    public class Editor : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttTyped
    {
        
        public Editor() : base("editor") { }

        public Editor(object _content) : base("editor", _content) { }

        public Editor(params object[] _content) : base("editor", _content) { }


        
    }
}
