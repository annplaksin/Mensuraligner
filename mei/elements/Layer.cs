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
    /// <layer/>
    /// </summary>
    public class Layer : MeiElement, IAttCommonPart, IAttDeclaring, IAttLayerLog, IAttMeterconformance, IAttVisibility, IAttCommonAnl
    {
        
        public Layer() : base("layer") { }

        public Layer(object _content) : base("layer", _content) { }

        public Layer(params object[] _content) : base("layer", _content) { }


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
