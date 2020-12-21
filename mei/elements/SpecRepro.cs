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
    /// <specRepro/>
    /// </summary>
    public class SpecRepro : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttLang
    {
        
        public SpecRepro() : base("specRepro") { }

        public SpecRepro(object _content) : base("specRepro", _content) { }

        public SpecRepro(params object[] _content) : base("specRepro", _content) { }


        
    }
}
