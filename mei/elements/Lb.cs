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
    /// <lb/>
    /// </summary>
    public class Lb : MeiElement, IAttCommon, IAttCommonPart, IAttSource, IAttTyped
    {
        
        public Lb() : base("lb") { }

        public Lb(object _content) : base("lb", _content) { }

        public Lb(params object[] _content) : base("lb", _content) { }


        #region func
    
    public void SetFunc(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "func", _val);
    }

    public XAttribute GetFuncAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "func");
    }
    
    public string GetFuncValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "func");
    }
    
    public bool HasFunc()
    {
      return MeiAtt_controller.HasAttribute(this, "func");
    }

    public void RemoveFunc()
    {
      MeiAtt_controller.RemoveAttribute(this, "func");
    }
    #endregion

    }
}
