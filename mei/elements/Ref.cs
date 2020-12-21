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
    /// <ref/>
    /// </summary>
    public class Ref : MeiElement, IAttCommon, IAttCommonPart, IAttInternetmedia, IAttLang, IAttPointing, IAttTargeteval, IAttTyped
    {
        
        public Ref() : base("ref") { }

        public Ref(object _content) : base("ref", _content) { }

        public Ref(params object[] _content) : base("ref", _content) { }


        
    }
}
