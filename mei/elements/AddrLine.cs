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
    /// <addrLine/>
    /// </summary>
    public class AddrLine : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public AddrLine() : base("addrLine") { }

        public AddrLine(object _content) : base("addrLine", _content) { }

        public AddrLine(params object[] _content) : base("addrLine", _content) { }


        
    }
}
