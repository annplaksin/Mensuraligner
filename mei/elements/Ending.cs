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
    /// <ending/>
    /// </summary>
    public class Ending : MeiElement, IAttCommon, IAttCommonPart, IAttCommonAnl, IAttPointing, IAttTargeteval, IAttTyped
    {
        
        public Ending() : base("ending") { }

        public Ending(object _content) : base("ending", _content) { }

        public Ending(params object[] _content) : base("ending", _content) { }


        
    }
}
