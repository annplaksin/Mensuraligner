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
    /// <tempo/>
    /// </summary>
    public class Tempo : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttTempoLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartid, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttMmtempo, IAttCommonAnl, IAttTyped
    {
        
        public Tempo() : base("tempo") { }

        public Tempo(object _content) : base("tempo", _content) { }

        public Tempo(params object[] _content) : base("tempo", _content) { }


        
    }
}
