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
  /// Interface for att.staffgroupingsym
  /// </summary>
  public interface IAttStaffgroupingsym : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.staffgroupingsym
  /// </summary>
  public static class AttStaffgroupingsym_extensions
  {
    #region symbol
    
    public static void SetSymbol(this IAttStaffgroupingsym e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "symbol", _val);
    }

    public static XAttribute GetSymbolAttribute(this IAttStaffgroupingsym e)
    {
      return MeiAtt_controller.GetAttribute(e, "symbol");
    }
    
    public static string GetSymbolValue(this IAttStaffgroupingsym e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "symbol");
    }
    
    public static bool HasSymbol(this IAttStaffgroupingsym e)
    {
      return MeiAtt_controller.HasAttribute(e, "symbol");
    }

    public static void RemoveSymbol(this IAttStaffgroupingsym e)
    {
      MeiAtt_controller.RemoveAttribute(e, "symbol");
    }
    #endregion

  }

}