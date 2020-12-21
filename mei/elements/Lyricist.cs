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
    /// <lyricist/>
    /// </summary>
    public class Lyricist : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang, IAttTyped
    {
        
        public Lyricist() : base("lyricist") { }

        public Lyricist(object _content) : base("lyricist", _content) { }

        public Lyricist(params object[] _content) : base("lyricist", _content) { }


        
    }
}
