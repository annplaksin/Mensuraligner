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
    /// <key/>
    /// </summary>
    public class Key : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttKeySigLog, IAttAccidental, IAttPitch
    {
        
        public Key() : base("key") { }

        public Key(object _content) : base("key", _content) { }

        public Key(params object[] _content) : base("key", _content) { }


        
    }
}
