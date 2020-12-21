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
    /// <expressionList/>
    /// </summary>
    public class ExpressionList : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public ExpressionList() : base("expressionList") { }

        public ExpressionList(object _content) : base("expressionList", _content) { }

        public ExpressionList(params object[] _content) : base("expressionList", _content) { }


        
    }
}
