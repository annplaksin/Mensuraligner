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
    /// <incipCode/>
    /// </summary>
    public class IncipCode : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttInternetmedia, IAttPointing, IAttWhitespace
    {
        
        public IncipCode() : base("incipCode") { }

        public IncipCode(object _content) : base("incipCode", _content) { }

        public IncipCode(params object[] _content) : base("incipCode", _content) { }


        #region form
    
    public void SetForm(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "form", _val);
    }

    public XAttribute GetFormAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "form");
    }
    
    public string GetFormValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "form");
    }
    
    public bool HasForm()
    {
      return MeiAtt_controller.HasAttribute(this, "form");
    }

    public void RemoveForm()
    {
      MeiAtt_controller.RemoveAttribute(this, "form");
    }
    #endregion

    }
}
