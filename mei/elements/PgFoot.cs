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
    /// <pgFoot/>
    /// </summary>
    public class PgFoot : MeiElement, IAttCommon, IAttCommonPart, IAttLang, IAttTyped
    {
        
        public PgFoot() : base("pgFoot") { }

        public PgFoot(object _content) : base("pgFoot", _content) { }

        public PgFoot(params object[] _content) : base("pgFoot", _content) { }


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
