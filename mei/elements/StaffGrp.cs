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
    /// <staffGrp/>
    /// </summary>
    public class StaffGrp : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttStaffGrpVis, IAttLabelsAddl, IAttStaffgroupingsym, IAttVisibility, IAttInstrumentident
    {
        
        public StaffGrp() : base("staffGrp") { }

        public StaffGrp(object _content) : base("staffGrp", _content) { }

        public StaffGrp(params object[] _content) : base("staffGrp", _content) { }


        
    }
}
