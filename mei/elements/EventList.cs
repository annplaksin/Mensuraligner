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
    /// <eventList/>
    /// </summary>
    public class EventList : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttTyped
    {
        
        public EventList() : base("eventList") { }

        public EventList(object _content) : base("eventList", _content) { }

        public EventList(params object[] _content) : base("eventList", _content) { }


        
    }
}
