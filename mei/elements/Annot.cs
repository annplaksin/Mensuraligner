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
    /// <annot/>
    /// </summary>
    public class Annot : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttLang, IAttSource, IAttAugmentdots, IAttDurationAdditive, IAttLayerident, IAttStaffident, IAttStartendid, IAttStartid, IAttTimestampMusical, IAttTimestamp2Musical, IAttTimestampPerformed, IAttDurationPerformed, IAttCommonAnl, IAttPlist, IAttResponsibility, IAttTargeteval, IAttTyped
    {
        
        public Annot() : base("annot") { }

        public Annot(object _content) : base("annot", _content) { }

        public Annot(params object[] _content) : base("annot", _content) { }


        
    }
}
