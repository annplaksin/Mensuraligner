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
    /// <verse/>
    /// </summary>
    public class Verse : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttVerseLog, IAttColor, IAttTypography, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttCommonAnl, IAttLyricsorder
    {
        
        public Verse() : base("verse") { }

        public Verse(object _content) : base("verse", _content) { }

        public Verse(params object[] _content) : base("verse", _content) { }


        
    }
}
