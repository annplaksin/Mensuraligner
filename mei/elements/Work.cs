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
    /// <work/>
    /// </summary>
    public class Work : MeiElement, IAttDatapointing, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public Work() : base("work") { }

        public Work(object _content) : base("work", _content) { }

        public Work(params object[] _content) : base("work", _content) { }


        
    }
}
