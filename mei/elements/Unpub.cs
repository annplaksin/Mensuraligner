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
    /// <unpub/>
    /// </summary>
    public class Unpub : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Unpub() : base("unpub") { }

        public Unpub(object _content) : base("unpub", _content) { }

        public Unpub(params object[] _content) : base("unpub", _content) { }


        
    }
}
