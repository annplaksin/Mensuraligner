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
    /// <pgHead2/>
    /// </summary>
    public class PgHead2 : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttTyped
    {
        
        public PgHead2() : base("pgHead2") { }

        public PgHead2(object _content) : base("pgHead2", _content) { }

        public PgHead2(params object[] _content) : base("pgHead2", _content) { }


        #region halign
    
    public void SetHalign(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "halign", _val);
    }

    public XAttribute GetHalignAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "halign");
    }
    
    public string GetHalignValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "halign");
    }
    
    public bool HasHalign()
    {
      return MeiAtt_controller.HasAttribute(this, "halign");
    }

    public void RemoveHalign()
    {
      MeiAtt_controller.RemoveAttribute(this, "halign");
    }
    #endregion

    }
}
