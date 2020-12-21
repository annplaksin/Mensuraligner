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
  /// Interface for att.classcodeident
  /// </summary>
  public interface IAttClasscodeident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.classcodeident
  /// </summary>
  public static class AttClasscodeident_extensions
  {
    #region classcode
    
    public static void SetClasscode(this IAttClasscodeident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "classcode", _val);
    }

    public static XAttribute GetClasscodeAttribute(this IAttClasscodeident e)
    {
      return MeiAtt_controller.GetAttribute(e, "classcode");
    }
    
    public static string GetClasscodeValue(this IAttClasscodeident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "classcode");
    }
    
    public static bool HasClasscode(this IAttClasscodeident e)
    {
      return MeiAtt_controller.HasAttribute(e, "classcode");
    }

    public static void RemoveClasscode(this IAttClasscodeident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "classcode");
    }
    #endregion

  }

}