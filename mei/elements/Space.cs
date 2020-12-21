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
    /// <space/>
    /// </summary>
    public class Space : MeiElement, IAttCommon, IAttCommonPart, IAttAugmentdots, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationMusical, IAttFermatapresent, IAttTupletpresent, IAttSpaceVis, IAttDurationPerformed, IAttCommonAnl
    {
        
        public Space() : base("space") { }

        public Space(object _content) : base("space", _content) { }

        public Space(params object[] _content) : base("space", _content) { }


        
    }
}
