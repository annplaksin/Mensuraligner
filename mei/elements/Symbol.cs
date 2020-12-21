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
    /// <symbol/>
    /// </summary>
    public class Symbol : MeiElement, IAttAltsym, IAttAuthorized, IAttColor, IAttCommon, IAttCommonPart, IAttCommonAnl, IAttScalable, IAttStartid, IAttTyped, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy
    {
        
        public Symbol() : base("symbol") { }

        public Symbol(object _content) : base("symbol", _content) { }

        public Symbol(params object[] _content) : base("symbol", _content) { }


        
    }
}
