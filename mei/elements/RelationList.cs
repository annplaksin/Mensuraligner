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
    /// <relationList/>
    /// </summary>
    public class RelationList : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public RelationList() : base("relationList") { }

        public RelationList(object _content) : base("relationList", _content) { }

        public RelationList(params object[] _content) : base("relationList", _content) { }


        
    }
}
