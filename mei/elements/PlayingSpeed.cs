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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <playingSpeed/>
    /// </summary>
    public class PlayingSpeed : MeiElement, IAttCommon, IAttBibl
    {
        
        public PlayingSpeed() : base("playingSpeed") { }

        public PlayingSpeed(object _content) : base("playingSpeed", _content) { }

        public PlayingSpeed(params object[] _content) : base("playingSpeed", _content) { }


        
    }
}
