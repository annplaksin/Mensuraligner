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
    /// <exhibHist/>
    /// </summary>
    public class ExhibHist : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public ExhibHist() : base("exhibHist") { }

        public ExhibHist(object _content) : base("exhibHist", _content) { }

        public ExhibHist(params object[] _content) : base("exhibHist", _content) { }


        
    }
}
