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
    /// <resp/>
    /// </summary>
    public class Resp : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttCanonical, IAttLang
    {
        
        public Resp() : base("resp") { }

        public Resp(object _content) : base("resp", _content) { }

        public Resp(params object[] _content) : base("resp", _content) { }


        
    }
}
