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
    /// <artic/>
    /// </summary>
    public class Artic : MeiElement, IAttCommon, IAttCommonPart, IAttArticulation, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAltsym, IAttColor, IAttEnclosingchars, IAttPlacement, IAttStaffloc, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttArticulationPerformed, IAttCommonAnl
    {
        
        public Artic() : base("artic") { }

        public Artic(object _content) : base("artic", _content) { }

        public Artic(params object[] _content) : base("artic", _content) { }


        
    }
}
