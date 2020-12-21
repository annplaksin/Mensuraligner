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
    /// <curve/>
    /// </summary>
    public class Curve : MeiElement, IAttCommonAnl, IAttColor, IAttCommon, IAttCommonPart, IAttCurvature, IAttCurverend, IAttStartendid, IAttStartid, IAttTyped, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2
    {
        
        public Curve() : base("curve") { }

        public Curve(object _content) : base("curve", _content) { }

        public Curve(params object[] _content) : base("curve", _content) { }


        
    }
}
