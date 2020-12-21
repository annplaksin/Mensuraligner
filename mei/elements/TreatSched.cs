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
    /// <treatSched/>
    /// </summary>
    public class TreatSched : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public TreatSched() : base("treatSched") { }

        public TreatSched(object _content) : base("treatSched", _content) { }

        public TreatSched(params object[] _content) : base("treatSched", _content) { }


        
    }
}
