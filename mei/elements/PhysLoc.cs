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
    /// <physLoc/>
    /// </summary>
    public class PhysLoc : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public PhysLoc() : base("physLoc") { }

        public PhysLoc(object _content) : base("physLoc", _content) { }

        public PhysLoc(params object[] _content) : base("physLoc", _content) { }


        
    }
}
