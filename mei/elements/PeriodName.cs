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
    /// <periodName/>
    /// </summary>
    public class PeriodName : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttLang, IAttName, IAttAuthorized, IAttCanonical, IAttDatable, IAttFiling, IAttTyped
    {
        
        public PeriodName() : base("periodName") { }

        public PeriodName(object _content) : base("periodName", _content) { }

        public PeriodName(params object[] _content) : base("periodName", _content) { }


        
    }
}
