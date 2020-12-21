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
    /// <itemList/>
    /// </summary>
    public class ItemList : MeiElement, IAttCommon, IAttCommonPart, IAttTyped
    {
        
        public ItemList() : base("itemList") { }

        public ItemList(object _content) : base("itemList", _content) { }

        public ItemList(params object[] _content) : base("itemList", _content) { }


        
    }
}
