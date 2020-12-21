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
    /// <fingerprint/>
    /// </summary>
    public class Fingerprint : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl
    {
        
        public Fingerprint() : base("fingerprint") { }

        public Fingerprint(object _content) : base("fingerprint", _content) { }

        public Fingerprint(params object[] _content) : base("fingerprint", _content) { }


        
    }
}
