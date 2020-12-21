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
    /// <dir/>
    /// </summary>
    public class Dir : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttExtender, IAttLinerend, IAttLinerendBase, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttTyped
    {
        
        public Dir() : base("dir") { }

        public Dir(object _content) : base("dir", _content) { }

        public Dir(params object[] _content) : base("dir", _content) { }


        
    }
}
