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
    /// <termList/>
    /// </summary>
    public class TermList : MeiElement, IAttCommon, IAttBibl
    {
        
        public TermList() : base("termList") { }

        public TermList(object _content) : base("termList", _content) { }

        public TermList(params object[] _content) : base("termList", _content) { }


        #region classcode
    
    public void SetClasscode(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "classcode", _val);
    }

    public XAttribute GetClasscodeAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "classcode");
    }

    public string GetClasscodeValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "classcode");
    }

    public bool HasClasscode()
    {
      return MeiAtt_controller.HasAttribute(this, "classcode");
    }

    public void RemoveClasscode()
    {
      MeiAtt_controller.RemoveAttribute(this, "classcode");
    }
    #endregion

    }
}
