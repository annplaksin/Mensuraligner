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
    /// <scoreFormat/>
    /// </summary>
    public class ScoreFormat : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttLang
    {
        
        public ScoreFormat() : base("scoreFormat") { }

        public ScoreFormat(object _content) : base("scoreFormat", _content) { }

        public ScoreFormat(params object[] _content) : base("scoreFormat", _content) { }


        
    }
}
