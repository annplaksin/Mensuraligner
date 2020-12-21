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
  /// Interface for att.timestamp.musical
  /// </summary>
  public interface IAttTimestampMusical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.timestamp.musical
  /// </summary>
  public static class AttTimestampMusical_extensions
  {
    #region tstamp
    
    public static void SetTstamp(this IAttTimestampMusical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tstamp", _val);
    }

    public static XAttribute GetTstampAttribute(this IAttTimestampMusical e)
    {
      return MeiAtt_controller.GetAttribute(e, "tstamp");
    }
    
    public static string GetTstampValue(this IAttTimestampMusical e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "tstamp");
    }
    
    public static bool HasTstamp(this IAttTimestampMusical e)
    {
      return MeiAtt_controller.HasAttribute(e, "tstamp");
    }

    public static void RemoveTstamp(this IAttTimestampMusical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tstamp");
    }
    #endregion

  }

}