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
    /// <dynam/>
    /// </summary>
    public class Dynam : MeiElement, IAttCommon, IAttCommonPart, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttLang, IAttTyped
    {
        
        public Dynam() : base("dynam") { }

        public Dynam(object _content) : base("dynam", _content) { }

        public Dynam(params object[] _content) : base("dynam", _content) { }


        
    }
}
