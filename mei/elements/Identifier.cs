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
    /// <identifier/>
    /// </summary>
    public class Identifier : MeiElement, IAttAuthorized, IAttBibl, IAttCommon, IAttCommonPart, IAttTyped
    {
        
        public Identifier() : base("identifier") { }

        public Identifier(object _content) : base("identifier", _content) { }

        public Identifier(params object[] _content) : base("identifier", _content) { }


        
    }
}
