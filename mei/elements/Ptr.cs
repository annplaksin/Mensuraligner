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
    /// <ptr/>
    /// </summary>
    public class Ptr : MeiElement, IAttCommon, IAttCommonPart, IAttInternetmedia, IAttPointing, IAttTargeteval, IAttTyped
    {
        
        public Ptr() : base("ptr") { }

        public Ptr(object _content) : base("ptr", _content) { }

        public Ptr(params object[] _content) : base("ptr", _content) { }


        
    }
}
