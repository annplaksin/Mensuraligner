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
    /// <rend/>
    /// </summary>
    public class Rend : MeiElement, IAttColor, IAttCommon, IAttCommonPart, IAttHorizontalalign, IAttLang, IAttTypography, IAttWhitespace
    {
        
        public Rend() : base("rend") { }

        public Rend(object _content) : base("rend", _content) { }

        public Rend(params object[] _content) : base("rend", _content) { }


        #region altrend
    
    public void SetAltrend(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "altrend", _val);
    }

    public XAttribute GetAltrendAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "altrend");
    }
    
    public string GetAltrendValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "altrend");
    }
    
    public bool HasAltrend()
    {
      return MeiAtt_controller.HasAttribute(this, "altrend");
    }

    public void RemoveAltrend()
    {
      MeiAtt_controller.RemoveAttribute(this, "altrend");
    }
    #endregion

        #region rend
    
    public void SetRend(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rend", _val);
    }

    public XAttribute GetRendAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "rend");
    }
    
    public string GetRendValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "rend");
    }
    
    public bool HasRend()
    {
      return MeiAtt_controller.HasAttribute(this, "rend");
    }

    public void RemoveRend()
    {
      MeiAtt_controller.RemoveAttribute(this, "rend");
    }
    #endregion

        #region rotation
    
    public void SetRotation(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rotation", _val);
    }

    public XAttribute GetRotationAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "rotation");
    }
    
    public string GetRotationValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "rotation");
    }
    
    public bool HasRotation()
    {
      return MeiAtt_controller.HasAttribute(this, "rotation");
    }

    public void RemoveRotation()
    {
      MeiAtt_controller.RemoveAttribute(this, "rotation");
    }
    #endregion

        #region valign
    
    public void SetValign(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "valign", _val);
    }

    public XAttribute GetValignAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "valign");
    }
    
    public string GetValignValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "valign");
    }
    
    public bool HasValign()
    {
      return MeiAtt_controller.HasAttribute(this, "valign");
    }

    public void RemoveValign()
    {
      MeiAtt_controller.RemoveAttribute(this, "valign");
    }
    #endregion

    }
}
