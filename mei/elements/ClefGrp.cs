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
    /// <clefGrp/>
    /// </summary>
    public class ClefGrp : MeiElement, IAttCommon, IAttCommonPart, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttCommonAnl
    {
        
        public ClefGrp() : base("clefGrp") { }

        public ClefGrp(object _content) : base("clefGrp", _content) { }

        public ClefGrp(params object[] _content) : base("clefGrp", _content) { }


        
    }
}
