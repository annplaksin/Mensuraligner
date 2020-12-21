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
    /// <expansion/>
    /// </summary>
    public class Expansion : MeiElement, IAttCommon, IAttCommonPart, IAttPlist, IAttSource, IAttTargeteval, IAttTyped
    {
        
        public Expansion() : base("expansion") { }

        public Expansion(object _content) : base("expansion", _content) { }

        public Expansion(params object[] _content) : base("expansion", _content) { }


        
    }
}
