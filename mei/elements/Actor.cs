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
    /// <actor/>
    /// </summary>
    public class Actor : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public Actor() : base("actor") { }

        public Actor(object _content) : base("actor", _content) { }

        public Actor(params object[] _content) : base("actor", _content) { }


        
    }
}
