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
    /// <reg/>
    /// </summary>
    public class Reg : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttResponsibility, IAttSource, IAttEvidence, IAttLang
    {
        
        public Reg() : base("reg") { }

        public Reg(object _content) : base("reg", _content) { }

        public Reg(params object[] _content) : base("reg", _content) { }


        
    }
}
