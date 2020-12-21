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
    /// <change/>
    /// </summary>
    public class Change : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatable, IAttResponsibility, IAttTyped
    {
        
        public Change() : base("change") { }

        public Change(object _content) : base("change", _content) { }

        public Change(params object[] _content) : base("change", _content) { }


        
    }
}
