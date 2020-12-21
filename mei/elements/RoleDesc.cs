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
    /// <roleDesc/>
    /// </summary>
    public class RoleDesc : MeiElement, IAttCommon, IAttCommonPart, IAttLang
    {
        
        public RoleDesc() : base("roleDesc") { }

        public RoleDesc(object _content) : base("roleDesc", _content) { }

        public RoleDesc(params object[] _content) : base("roleDesc", _content) { }


        
    }
}
