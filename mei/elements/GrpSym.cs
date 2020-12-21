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
    /// <grpSym/>
    /// </summary>
    public class GrpSym : MeiElement, IAttCommon, IAttCommonPart, IAttGrpSymLog, IAttStaffgroupingsym, IAttStartendid, IAttStartid, IAttAltsym, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttCommonAnl
    {
        
        public GrpSym() : base("grpSym") { }

        public GrpSym(object _content) : base("grpSym", _content) { }

        public GrpSym(params object[] _content) : base("grpSym", _content) { }


        
    }
}
