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
    /// <line/>
    /// </summary>
    public class Line : MeiElement, IAttCommonAnl, IAttColor, IAttCommon, IAttStartendid, IAttStartid, IAttTyped, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2, IAttLinerend
    {
        
        public Line() : base("line") { }

        public Line(object _content) : base("line", _content) { }

        public Line(params object[] _content) : base("line", _content) { }


        
    }
}
