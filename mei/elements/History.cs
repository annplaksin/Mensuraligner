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
    /// <history/>
    /// </summary>
    public class History : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public History() : base("history") { }

        public History(object _content) : base("history", _content) { }

        public History(params object[] _content) : base("history", _content) { }


        
    }
}
