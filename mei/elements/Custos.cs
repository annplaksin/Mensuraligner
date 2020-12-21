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
    /// <custos/>
    /// </summary>
    public class Custos : MeiElement, IAttCommon, IAttCommonPart, IAttSource, IAttCustosLog, IAttPitch, IAttOctave, IAttAltsym, IAttColor, IAttStaffloc, IAttTypography, IAttCommonAnl
    {
        
        public Custos() : base("custos") { }

        public Custos(object _content) : base("custos", _content) { }

        public Custos(params object[] _content) : base("custos", _content) { }


        
    }
}
