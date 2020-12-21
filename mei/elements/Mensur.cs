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
    /// <mensur/>
    /// </summary>
    public class Mensur : MeiElement, IAttCommon, IAttCommonPart, IAttMensurLog, IAttDurationRatio, IAttSlashcount, IAttMensuralShared, IAttMensurVis, IAttAltsym, IAttColor, IAttRelativesize, IAttStaffloc, IAttTypography, IAttCommonAnl
    {
        
        public Mensur() : base("mensur") { }

        public Mensur(object _content) : base("mensur", _content) { }

        public Mensur(params object[] _content) : base("mensur", _content) { }


        
    }
}
