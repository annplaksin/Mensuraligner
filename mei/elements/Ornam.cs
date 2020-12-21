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
    /// <ornam/>
    /// </summary>
    public class Ornam : MeiElement, IAttCommon, IAttCommonPart, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttColor, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttTyped
    {
        
        public Ornam() : base("ornam") { }

        public Ornam(object _content) : base("ornam", _content) { }

        public Ornam(params object[] _content) : base("ornam", _content) { }


        
    }
}
