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
    /// <orig/>
    /// </summary>
    public class Orig : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttTyped
    {
        
        public Orig() : base("orig") { }

        public Orig(object _content) : base("orig", _content) { }

        public Orig(params object[] _content) : base("orig", _content) { }


        
    }
}
