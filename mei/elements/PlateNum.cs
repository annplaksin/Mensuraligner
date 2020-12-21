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
    /// <plateNum/>
    /// </summary>
    public class PlateNum : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public PlateNum() : base("plateNum") { }

        public PlateNum(object _content) : base("plateNum", _content) { }

        public PlateNum(params object[] _content) : base("plateNum", _content) { }


        
    }
}
