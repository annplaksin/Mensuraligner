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
    /// <playingSpeed/>
    /// </summary>
    public class PlayingSpeed : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public PlayingSpeed() : base("playingSpeed") { }

        public PlayingSpeed(object _content) : base("playingSpeed", _content) { }

        public PlayingSpeed(params object[] _content) : base("playingSpeed", _content) { }


        
    }
}
