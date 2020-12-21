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
    /// <trackConfig/>
    /// </summary>
    public class TrackConfig : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttLang
    {
        
        public TrackConfig() : base("trackConfig") { }

        public TrackConfig(object _content) : base("trackConfig", _content) { }

        public TrackConfig(params object[] _content) : base("trackConfig", _content) { }


        #region num
    
    public void SetNum(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "num", _val);
    }

    public XAttribute GetNumAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "num");
    }
    
    public string GetNumValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "num");
    }
    
    public bool HasNum()
    {
      return MeiAtt_controller.HasAttribute(this, "num");
    }

    public void RemoveNum()
    {
      MeiAtt_controller.RemoveAttribute(this, "num");
    }
    #endregion

    }
}
