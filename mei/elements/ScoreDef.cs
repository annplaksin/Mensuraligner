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
    /// <scoreDef/>
    /// </summary>
    public class ScoreDef : MeiElement, IAttCommon, IAttCommonPart, IAttCleffingLog, IAttDurationDefault, IAttKeySigDefaultLog, IAttMeterSigDefaultLog, IAttOctavedefault, IAttTransposition, IAttMensuralLog, IAttMensuralShared, IAttScoreDefVis, IAttBarplacement, IAttCleffingVis, IAttDistances, IAttEndings, IAttKeySigDefaultVis, IAttLyricstyle, IAttMeasurenumbers, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttNotationstyle, IAttOnelinestaff, IAttOptimization, IAttPages, IAttSpacing, IAttSystems, IAttTextstyle, IAttMensuralVis, IAttScoreDefGes, IAttMmtempo
    {
        
        public ScoreDef() : base("scoreDef") { }

        public ScoreDef(object _content) : base("scoreDef", _content) { }

        public ScoreDef(params object[] _content) : base("scoreDef", _content) { }


        
    }
}
