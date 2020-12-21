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
    /// <chord/>
    /// </summary>
    public class Chord : MeiElement, IAttCommon, IAttCommonPart, IAttChordVis, IAttAltsym, IAttColor, IAttEnclosingchars, IAttRelativesize, IAttStems, IAttTypography, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy, IAttCommonAnl
    {
        
        public Chord() : base("chord") { }

        public Chord(object _content) : base("chord", _content) { }

        public Chord(params object[] _content) : base("chord", _content) { }


        
    }
}
