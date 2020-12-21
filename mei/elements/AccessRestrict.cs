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
    /// <accessRestrict/>
    /// </summary>
    public class AccessRestrict : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public AccessRestrict() : base("accessRestrict") { }

        public AccessRestrict(object _content) : base("accessRestrict", _content) { }

        public AccessRestrict(params object[] _content) : base("accessRestrict", _content) { }


        
    }
}
