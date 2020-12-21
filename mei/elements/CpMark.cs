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
    /// <cpMark/>
    /// </summary>
    public class CpMark : MeiElement, IAttCommon, IAttCommonPart, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttOriginTimestampMusical, IAttOriginStaffident, IAttOriginLayerident, IAttOriginStartendid, IAttOctavedisplacement, IAttAltsym, IAttColor, IAttEnclosingchars, IAttPlacement, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttTyped
    {
        
        public CpMark() : base("cpMark") { }

        public CpMark(object _content) : base("cpMark", _content) { }

        public CpMark(params object[] _content) : base("cpMark", _content) { }


        
    }
}
