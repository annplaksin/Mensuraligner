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
    /// <correction/>
    /// </summary>
    public class Correction : MeiElement, IAttCommon, IAttBibl, IAttDatapointing, IAttLang, IAttRegularmethod
    {
        
        public Correction() : base("correction") { }

        public Correction(object _content) : base("correction", _content) { }

        public Correction(params object[] _content) : base("correction", _content) { }


        #region corrlevel
    
    public void SetCorrlevel(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "corrlevel", _val);
    }

    public XAttribute GetCorrlevelAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "corrlevel");
    }

    public string GetCorrlevelValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "corrlevel");
    }

    public bool HasCorrlevel()
    {
      return MeiAtt_controller.HasAttribute(this, "corrlevel");
    }

    public void RemoveCorrlevel()
    {
      MeiAtt_controller.RemoveAttribute(this, "corrlevel");
    }
    #endregion

    }
}
