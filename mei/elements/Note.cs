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
    /// <note/>
    /// </summary>
    public class Note : MeiElement, IAttCommon, IAttCommonPart, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationMusical, IAttFermatapresent, IAttPitch, IAttOctave, IAttNoteLogMensural, IAttAltsym, IAttColor, IAttColoration, IAttEnclosingchars, IAttNoteheads, IAttRelativesize, IAttStaffloc, IAttStems, IAttTypography, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy, IAttNoteGes, IAttAccidentalPerformed, IAttDurationRatio, IAttCommonAnl
    {
        
        public Note() : base("note") { }

        public Note(object _content) : base("note", _content) { }

        public Note(params object[] _content) : base("note", _content) { }


        
    }
}
