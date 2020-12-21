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
    /// <revisionDesc/>
    /// </summary>
    public class RevisionDesc : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public RevisionDesc() : base("revisionDesc") { }

        public RevisionDesc(object _content) : base("revisionDesc", _content) { }

        public RevisionDesc(params object[] _content) : base("revisionDesc", _content) { }


        
    }
}
