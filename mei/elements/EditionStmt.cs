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
    /// <editionStmt/>
    /// </summary>
    public class EditionStmt : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public EditionStmt() : base("editionStmt") { }

        public EditionStmt(object _content) : base("editionStmt", _content) { }

        public EditionStmt(params object[] _content) : base("editionStmt", _content) { }


        
    }
}
