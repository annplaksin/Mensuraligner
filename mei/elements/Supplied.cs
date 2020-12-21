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
    /// <supplied/>
    /// </summary>
    public class Supplied : MeiElement, IAttAgentident, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttReasonident
    {
        
        public Supplied() : base("supplied") { }

        public Supplied(object _content) : base("supplied", _content) { }

        public Supplied(params object[] _content) : base("supplied", _content) { }


        
    }
}
