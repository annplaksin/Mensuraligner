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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <ending/>
    /// </summary>
    public class Ending : MeiElement, IAttCommon, IAttTyped, IAttPointing, IAttCommonAnl
    {
        
        public Ending() : base("ending") { }

        public Ending(object _content) : base("ending", _content) { }

        public Ending(params object[] _content) : base("ending", _content) { }


        
    }
}
