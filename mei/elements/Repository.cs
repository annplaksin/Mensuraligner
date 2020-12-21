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
    /// <repository/>
    /// </summary>
    public class Repository : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttLang, IAttName, IAttAuthorized, IAttCanonical, IAttDatable, IAttFiling, IAttTyped
    {
        
        public Repository() : base("repository") { }

        public Repository(object _content) : base("repository", _content) { }

        public Repository(params object[] _content) : base("repository", _content) { }


        
    }
}
