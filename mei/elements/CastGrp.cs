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
    /// <castGrp/>
    /// </summary>
    public class CastGrp : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public CastGrp() : base("castGrp") { }

        public CastGrp(object _content) : base("castGrp", _content) { }

        public CastGrp(params object[] _content) : base("castGrp", _content) { }


        
    }
}
