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
    /// <score/>
    /// </summary>
    public class Score : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttCommonAnl, IAttTyped
    {
        
        public Score() : base("score") { }

        public Score(object _content) : base("score", _content) { }

        public Score(params object[] _content) : base("score", _content) { }


        
    }
}
