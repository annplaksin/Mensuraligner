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
    /// <editorialDecl/>
    /// </summary>
    public class EditorialDecl : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttDatapointing, IAttLang
    {
        
        public EditorialDecl() : base("editorialDecl") { }

        public EditorialDecl(object _content) : base("editorialDecl", _content) { }

        public EditorialDecl(params object[] _content) : base("editorialDecl", _content) { }


        
    }
}
