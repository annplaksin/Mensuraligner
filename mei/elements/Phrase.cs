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
    /// <phrase/>
    /// </summary>
    public class Phrase : MeiElement, IAttCommon, IAttCommonPart, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttColor, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2, IAttDurationPerformed, IAttCommonAnl, IAttJoined, IAttTyped
    {
        
        public Phrase() : base("phrase") { }

        public Phrase(object _content) : base("phrase", _content) { }

        public Phrase(params object[] _content) : base("phrase", _content) { }


        
    }
}
