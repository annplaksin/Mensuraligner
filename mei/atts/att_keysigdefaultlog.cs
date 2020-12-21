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
  /// Interface for att.keySigDefault.log
  /// </summary>
  public interface IAttKeySigDefaultLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.keySigDefault.log
  /// </summary>
  public static class AttKeySigDefaultLog_extensions
  {
    #region key.accid
    
    public static void SetKeyAccid(this IAttKeySigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.accid", _val);
    }

    public static XAttribute GetKeyAccidAttribute(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.accid");
    }
    
    public static string GetKeyAccidValue(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.accid");
    }
    
    public static bool HasKeyAccid(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.accid");
    }

    public static void RemoveKeyAccid(this IAttKeySigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.accid");
    }
    #endregion

    #region key.mode
    
    public static void SetKeyMode(this IAttKeySigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.mode", _val);
    }

    public static XAttribute GetKeyModeAttribute(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.mode");
    }
    
    public static string GetKeyModeValue(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.mode");
    }
    
    public static bool HasKeyMode(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.mode");
    }

    public static void RemoveKeyMode(this IAttKeySigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.mode");
    }
    #endregion

    #region key.pname
    
    public static void SetKeyPname(this IAttKeySigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.pname", _val);
    }

    public static XAttribute GetKeyPnameAttribute(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.pname");
    }
    
    public static string GetKeyPnameValue(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.pname");
    }
    
    public static bool HasKeyPname(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.pname");
    }

    public static void RemoveKeyPname(this IAttKeySigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.pname");
    }
    #endregion

    #region key.sig
    
    public static void SetKeySig(this IAttKeySigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.sig", _val);
    }

    public static XAttribute GetKeySigAttribute(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.sig");
    }
    
    public static string GetKeySigValue(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.sig");
    }
    
    public static bool HasKeySig(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.sig");
    }

    public static void RemoveKeySig(this IAttKeySigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.sig");
    }
    #endregion

    #region key.sig.mixed
    
    public static void SetKeySigMixed(this IAttKeySigDefaultLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "key.sig.mixed", _val);
    }

    public static XAttribute GetKeySigMixedAttribute(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "key.sig.mixed");
    }
    
    public static string GetKeySigMixedValue(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "key.sig.mixed");
    }
    
    public static bool HasKeySigMixed(this IAttKeySigDefaultLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "key.sig.mixed");
    }

    public static void RemoveKeySigMixed(this IAttKeySigDefaultLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "key.sig.mixed");
    }
    #endregion

  }

}