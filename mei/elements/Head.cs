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
    /// <head/>
    /// </summary>
    public class Head : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttTyped, IAttXy
    {
        
        public Head() : base("head") { }

        public Head(object _content) : base("head", _content) { }

        public Head(params object[] _content) : base("head", _content) { }


        
    }
}
