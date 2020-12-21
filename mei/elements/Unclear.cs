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
    /// <unclear/>
    /// </summary>
    public class Unclear : MeiElement, IAttAgentident, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttHandident, IAttLang, IAttReasonident
    {
        
        public Unclear() : base("unclear") { }

        public Unclear(object _content) : base("unclear", _content) { }

        public Unclear(params object[] _content) : base("unclear", _content) { }


        
    }
}
