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
    /// <recipient/>
    /// </summary>
    public class Recipient : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Recipient() : base("recipient") { }

        public Recipient(object _content) : base("recipient", _content) { }

        public Recipient(params object[] _content) : base("recipient", _content) { }


        
    }
}
