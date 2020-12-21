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
    /// <syl/>
    /// </summary>
    public class Syl : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttSylLog, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttHorizontalalign, IAttCommonAnl
    {
        
        public Syl() : base("syl") { }

        public Syl(object _content) : base("syl", _content) { }

        public Syl(params object[] _content) : base("syl", _content) { }


        
    }
}
