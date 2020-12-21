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
    /// <dot/>
    /// </summary>
    public class Dot : MeiElement, IAttCommon, IAttCommonPart, IAttDotLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAltsym, IAttColor, IAttStaffloc, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetVo, IAttXy, IAttStafflocPitched, IAttCommonAnl
    {
        
        public Dot() : base("dot") { }

        public Dot(object _content) : base("dot", _content) { }

        public Dot(params object[] _content) : base("dot", _content) { }


        
    }
}
