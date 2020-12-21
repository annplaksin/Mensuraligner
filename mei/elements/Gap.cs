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
    /// <gap/>
    /// </summary>
    public class Gap : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttExtent, IAttHandident, IAttReasonident, IAttMeasurement
    {
        
        public Gap() : base("gap") { }

        public Gap(object _content) : base("gap", _content) { }

        public Gap(params object[] _content) : base("gap", _content) { }


        
    }
}
