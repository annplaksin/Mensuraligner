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
    /// <parts/>
    /// </summary>
    public class Parts : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttCommonAnl, IAttTyped
    {
        
        public Parts() : base("parts") { }

        public Parts(object _content) : base("parts", _content) { }

        public Parts(params object[] _content) : base("parts", _content) { }


        
    }
}
