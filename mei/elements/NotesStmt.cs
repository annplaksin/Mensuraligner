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
    /// <notesStmt/>
    /// </summary>
    public class NotesStmt : MeiElement, IAttCommon, IAttCommonPart, IAttBibl
    {
        
        public NotesStmt() : base("notesStmt") { }

        public NotesStmt(object _content) : base("notesStmt", _content) { }

        public NotesStmt(params object[] _content) : base("notesStmt", _content) { }


        
    }
}
