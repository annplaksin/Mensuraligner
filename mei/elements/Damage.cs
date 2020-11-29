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
    /// <damage/>
    /// </summary>
    public class Damage : MeiElement, IAttAgentident, IAttCommon, IAttExtent, IAttHandident, IAttTyped
    {
        
        public Damage() : base("damage") { }

        public Damage(object _content) : base("damage", _content) { }

        public Damage(params object[] _content) : base("damage", _content) { }


        #region degree
    
    public void SetDegree(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "degree", _val);
    }

    public XAttribute GetDegreeAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "degree");
    }

    public string GetDegreeValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "degree");
    }

    public bool HasDegree()
    {
      return MeiAtt_controller.HasAttribute(this, "degree");
    }

    public void RemoveDegree()
    {
      MeiAtt_controller.RemoveAttribute(this, "degree");
    }
    #endregion

    }
}
