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
    /// <system/>
    /// </summary>
    public class System : MeiElement, IAttCommon, IAttSbVis, IAttCommonAnl, IAttSource, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttSpacing, IAttStaffGrpVis, IAttLabelsAddl, IAttStaffgroupingsym, IAttVisibility
    {
        
        public System() : base("system") { }

        public System(object _content) : base("system", _content) { }

        public System(params object[] _content) : base("system", _content) { }


        #region leftline
    
    public void SetLeftline(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "leftline", _val);
    }

    public XAttribute GetLeftlineAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "leftline");
    }

    public string GetLeftlineValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "leftline");
    }

    public bool HasLeftline()
    {
      return MeiAtt_controller.HasAttribute(this, "leftline");
    }

    public void RemoveLeftline()
    {
      MeiAtt_controller.RemoveAttribute(this, "leftline");
    }
    #endregion

        #region leftmar
    
    public void SetLeftmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "leftmar", _val);
    }

    public XAttribute GetLeftmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "leftmar");
    }

    public string GetLeftmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "leftmar");
    }

    public bool HasLeftmar()
    {
      return MeiAtt_controller.HasAttribute(this, "leftmar");
    }

    public void RemoveLeftmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "leftmar");
    }
    #endregion

        #region rightmar
    
    public void SetRightmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rightmar", _val);
    }

    public XAttribute GetRightmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "rightmar");
    }

    public string GetRightmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "rightmar");
    }

    public bool HasRightmar()
    {
      return MeiAtt_controller.HasAttribute(this, "rightmar");
    }

    public void RemoveRightmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "rightmar");
    }
    #endregion

        #region topmar
    
    public void SetTopmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "topmar", _val);
    }

    public XAttribute GetTopmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "topmar");
    }

    public string GetTopmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "topmar");
    }

    public bool HasTopmar()
    {
      return MeiAtt_controller.HasAttribute(this, "topmar");
    }

    public void RemoveTopmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "topmar");
    }
    #endregion

    }
}
