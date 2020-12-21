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
    /// <seriesStmt/>
    /// </summary>
    public class SeriesStmt : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public SeriesStmt() : base("seriesStmt") { }

        public SeriesStmt(object _content) : base("seriesStmt", _content) { }

        public SeriesStmt(params object[] _content) : base("seriesStmt", _content) { }


        
    }
}
