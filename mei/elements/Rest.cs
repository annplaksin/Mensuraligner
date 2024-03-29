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
    /// <rest/>
    /// </summary>
    public class Rest : MeiElement, IAttCommon, IAttCommonPart, IAttAugmentdots, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationMusical, IAttFermatapresent, IAttTupletpresent, IAttAltsym, IAttColor, IAttEnclosingchars, IAttRelativesize, IAttRestVisMensural, IAttStaffloc, IAttStafflocPitched, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttDurationPerformed, IAttInstrumentident, IAttDurationRatio, IAttCommonAnl
    {
        
        public Rest() : base("rest") { }

        public Rest(object _content) : base("rest", _content) { }

        public Rest(params object[] _content) : base("rest", _content) { }


        
    }
}
