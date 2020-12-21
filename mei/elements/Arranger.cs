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
    /// <arranger/>
    /// </summary>
    public class Arranger : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttTyped
    {
        
        public Arranger() : base("arranger") { }

        public Arranger(object _content) : base("arranger", _content) { }

        public Arranger(params object[] _content) : base("arranger", _content) { }


        
    }
}
