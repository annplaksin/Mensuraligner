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
    /// <segmentation/>
    /// </summary>
    public class Segmentation : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatapointing, IAttLang
    {
        
        public Segmentation() : base("segmentation") { }

        public Segmentation(object _content) : base("segmentation", _content) { }

        public Segmentation(params object[] _content) : base("segmentation", _content) { }


        
    }
}
