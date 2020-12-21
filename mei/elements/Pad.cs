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
    /// <pad/>
    /// </summary>
    public class Pad : MeiElement, IAttCommon, IAttCommonPart, IAttPadLog, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident
    {
        
        public Pad() : base("pad") { }

        public Pad(object _content) : base("pad", _content) { }

        public Pad(params object[] _content) : base("pad", _content) { }


        
    }
}
