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
    /// <handShift/>
    /// </summary>
    public class HandShift : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttMedium
    {
        
        public HandShift() : base("handShift") { }

        public HandShift(object _content) : base("handShift", _content) { }

        public HandShift(params object[] _content) : base("handShift", _content) { }


        #region character
    
    public void SetCharacter(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "character", _val);
    }

    public XAttribute GetCharacterAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "character");
    }
    
    public string GetCharacterValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "character");
    }
    
    public bool HasCharacter()
    {
      return MeiAtt_controller.HasAttribute(this, "character");
    }

    public void RemoveCharacter()
    {
      MeiAtt_controller.RemoveAttribute(this, "character");
    }
    #endregion

        #region new
    
    public void SetNew(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "new", _val);
    }

    public XAttribute GetNewAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "new");
    }
    
    public string GetNewValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "new");
    }
    
    public bool HasNew()
    {
      return MeiAtt_controller.HasAttribute(this, "new");
    }

    public void RemoveNew()
    {
      MeiAtt_controller.RemoveAttribute(this, "new");
    }
    #endregion

        #region old
    
    public void SetOld(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "old", _val);
    }

    public XAttribute GetOldAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "old");
    }
    
    public string GetOldValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "old");
    }
    
    public bool HasOld()
    {
      return MeiAtt_controller.HasAttribute(this, "old");
    }

    public void RemoveOld()
    {
      MeiAtt_controller.RemoveAttribute(this, "old");
    }
    #endregion

    }
}
