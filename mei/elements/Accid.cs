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
    /// <accid/>
    /// </summary>
    public class Accid : MeiElement, IAttCommon, IAttCommonPart, IAttAccidLog, IAttAccidental, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAltsym, IAttColor, IAttEnclosingchars, IAttPlacement, IAttStaffloc, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetVo, IAttXy, IAttStafflocPitched, IAttAccidentalPerformed, IAttCommonAnl, IAttAccidPos
    {
        
        public Accid() : base("accid") { }

        public Accid(object _content) : base("accid", _content) { }

        public Accid(params object[] _content) : base("accid", _content) { }


        
    }
}
