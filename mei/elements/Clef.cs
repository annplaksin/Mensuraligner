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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <clef/>
    /// </summary>
    public class Clef : MeiElement, IAttCommon, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttCommonAnl, IAttClefLog, IAttClefshape, IAttLineloc, IAttOctave, IAttOctavedisplacement, IAttAltsym, IAttColor
    {
        
        public Clef() : base("clef") { }

        public Clef(object _content) : base("clef", _content) { }

        public Clef(params object[] _content) : base("clef", _content) { }


        
    }
}
