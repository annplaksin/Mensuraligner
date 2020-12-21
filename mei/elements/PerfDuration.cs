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
    /// <perfDuration/>
    /// </summary>
    public class PerfDuration : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public PerfDuration() : base("perfDuration") { }

        public PerfDuration(object _content) : base("perfDuration", _content) { }

        public PerfDuration(params object[] _content) : base("perfDuration", _content) { }


        #region isodur
    
    public void SetIsodur(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "isodur", _val);
    }

    public XAttribute GetIsodurAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "isodur");
    }
    
    public string GetIsodurValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "isodur");
    }
    
    public bool HasIsodur()
    {
      return MeiAtt_controller.HasAttribute(this, "isodur");
    }

    public void RemoveIsodur()
    {
      MeiAtt_controller.RemoveAttribute(this, "isodur");
    }
    #endregion

    }
}
