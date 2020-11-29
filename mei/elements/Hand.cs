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

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <hand/>
    /// </summary>
    public class Hand : MeiElement, IAttCommon, IAttBibl, IAttLang, IAttMedium, IAttResponsibility
    {
        
        public Hand() : base("hand") { }

        public Hand(object _content) : base("hand", _content) { }

        public Hand(params object[] _content) : base("hand", _content) { }


        #region initial
    
    public void SetInitial(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "initial", _val);
    }

    public XAttribute GetInitialAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "initial");
    }

    public string GetInitialValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "initial");
    }

    public bool HasInitial()
    {
      return MeiAtt_controller.HasAttribute(this, "initial");
    }

    public void RemoveInitial()
    {
      MeiAtt_controller.RemoveAttribute(this, "initial");
    }
    #endregion

    }
}
