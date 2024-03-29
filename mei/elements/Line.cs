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
    /// <line/>
    /// </summary>
    public class Line : MeiElement, IAttCommon, IAttCommonPart, IAttDurationPerformed, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttLineVis, IAttColor, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2, IAttTyped
    {
        
        public Line() : base("line") { }

        public Line(object _content) : base("line", _content) { }

        public Line(params object[] _content) : base("line", _content) { }


        
    }
}
