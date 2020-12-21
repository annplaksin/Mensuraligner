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
    /// <price/>
    /// </summary>
    public class Price : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttLang
    {
        
        public Price() : base("price") { }

        public Price(object _content) : base("price", _content) { }

        public Price(params object[] _content) : base("price", _content) { }


        #region amount
    
    public void SetAmount(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "amount", _val);
    }

    public XAttribute GetAmountAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "amount");
    }
    
    public string GetAmountValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "amount");
    }
    
    public bool HasAmount()
    {
      return MeiAtt_controller.HasAttribute(this, "amount");
    }

    public void RemoveAmount()
    {
      MeiAtt_controller.RemoveAttribute(this, "amount");
    }
    #endregion

        #region currency
    
    public void SetCurrency(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "currency", _val);
    }

    public XAttribute GetCurrencyAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "currency");
    }
    
    public string GetCurrencyValue()
    {
      return MeiAtt_controller.GetAttributeValue(this, "currency");
    }
    
    public bool HasCurrency()
    {
      return MeiAtt_controller.HasAttribute(this, "currency");
    }

    public void RemoveCurrency()
    {
      MeiAtt_controller.RemoveAttribute(this, "currency");
    }
    #endregion

    }
}
