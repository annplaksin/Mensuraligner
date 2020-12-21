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
    /// <titleStmt/>
    /// </summary>
    public class TitleStmt : MeiElement, IAttBibl, IAttCommon, IAttCommonPart
    {
        
        public TitleStmt() : base("titleStmt") { }

        public TitleStmt(object _content) : base("titleStmt", _content) { }

        public TitleStmt(params object[] _content) : base("titleStmt", _content) { }


        
    }
}
