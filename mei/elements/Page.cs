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
    /// <page/>
    /// </summary>
    public class Page : MeiElement, IAttCommon, IAttCommonAnl, IAttSurface, IAttSpacing, IAttSystems
    {
        
        public Page() : base("page") { }

        public Page(object _content) : base("page", _content) { }

        public Page(params object[] _content) : base("page", _content) { }


        #region height
    
    public void SetHeight(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "height", _val);
    }

    public XAttribute GetHeightAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "height");
    }

    public string GetHeightValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "height");
    }

    public bool HasHeight()
    {
      return MeiAtt_controller.HasAttribute(this, "height");
    }

    public void RemoveHeight()
    {
      MeiAtt_controller.RemoveAttribute(this, "height");
    }
    #endregion

        #region width
    
    public void SetWidth(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "width", _val);
    }

    public XAttribute GetWidthAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "width");
    }

    public string GetWidthValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "width");
    }

    public bool HasWidth()
    {
      return MeiAtt_controller.HasAttribute(this, "width");
    }

    public void RemoveWidth()
    {
      MeiAtt_controller.RemoveAttribute(this, "width");
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

        #region botmar
    
    public void SetBotmar(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "botmar", _val);
    }

    public XAttribute GetBotmarAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "botmar");
    }

    public string GetBotmarValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "botmar");
    }

    public bool HasBotmar()
    {
      return MeiAtt_controller.HasAttribute(this, "botmar");
    }

    public void RemoveBotmar()
    {
      MeiAtt_controller.RemoveAttribute(this, "botmar");
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

        #region panels
    
    public void SetPanels(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "panels", _val);
    }

    public XAttribute GetPanelsAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "panels");
    }

    public string GetPanelsValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "panels");
    }

    public bool HasPanels()
    {
      return MeiAtt_controller.HasAttribute(this, "panels");
    }

    public void RemovePanels()
    {
      MeiAtt_controller.RemoveAttribute(this, "panels");
    }
    #endregion

        #region scale
    
    public void SetScale(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "scale", _val);
    }

    public XAttribute GetScaleAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "scale");
    }

    public string GetScaleValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "scale");
    }

    public bool HasScale()
    {
      return MeiAtt_controller.HasAttribute(this, "scale");
    }

    public void RemoveScale()
    {
      MeiAtt_controller.RemoveAttribute(this, "scale");
    }
    #endregion

    }
}
