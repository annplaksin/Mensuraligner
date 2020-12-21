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
    /// <staffDef/>
    /// </summary>
    public class StaffDef : MeiElement, IAttCommonPart, IAttDeclaring, IAttCleffingLog, IAttDurationDefault, IAttKeySigDefaultLog, IAttMeterSigDefaultLog, IAttNotationtype, IAttOctavedefault, IAttTransposition, IAttMensuralLog, IAttMensuralShared, IAttStaffDefVis, IAttCleffingVis, IAttDistances, IAttKeySigDefaultVis, IAttLabelsAddl, IAttLyricstyle, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttOnelinestaff, IAttScalable, IAttTextstyle, IAttVisibility, IAttMensuralVis, IAttInstrumentident
    {
        
        public StaffDef() : base("staffDef") { }

        public StaffDef(object _content) : base("staffDef", _content) { }

        public StaffDef(params object[] _content) : base("staffDef", _content) { }


        #region n
    
    public void SetN(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "n", _val);
    }

    public XAttribute GetNAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "n");
    }
    
    public string GetNValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "n");
    }
    
    public bool HasN()
    {
      return MeiAtt_controller.HasAttribute(this, "n");
    }

    public void RemoveN()
    {
      MeiAtt_controller.RemoveAttribute(this, "n");
    }
    #endregion

    }
}
