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
    /// <item/>
    /// </summary>
    public class Item : MeiElement, IAttDatapointing, IAttCommon, IAttCommonPart, IAttBibl, IAttPointing, IAttTargeteval
    {
        
        public Item() : base("item") { }

        public Item(object _content) : base("item", _content) { }

        public Item(params object[] _content) : base("item", _content) { }


        
    }
}
