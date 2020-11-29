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
  /// Interface for att.edit
  /// </summary>
  public interface IAttEdit : IMEiAtt, IAttResponsibility, IAttSource
  {

  }


    /// <summary>
  /// Extension methods for att.edit
  /// </summary>
  public static class AttEdit_extensions
  {
    #region cert
    
    public static void SetCert(this IAttEdit e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cert", _val);
    }

    public static XAttribute GetCertAttribute(this IAttEdit e)
    {
      return MeiAtt_controller.GetAttribute(e, "cert");
    }

    public static string GetCertValue(this IAttEdit e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "cert");
    }

    public static bool HasCert(this IAttEdit e)
    {
      return MeiAtt_controller.HasAttribute(e, "cert");
    }

    public static void RemoveCert(this IAttEdit e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cert");
    }
    #endregion

    #region evidence
    
    public static void SetEvidence(this IAttEdit e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "evidence", _val);
    }

    public static XAttribute GetEvidenceAttribute(this IAttEdit e)
    {
      return MeiAtt_controller.GetAttribute(e, "evidence");
    }

    public static string GetEvidenceValue(this IAttEdit e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "evidence");
    }

    public static bool HasEvidence(this IAttEdit e)
    {
      return MeiAtt_controller.HasAttribute(e, "evidence");
    }

    public static void RemoveEvidence(this IAttEdit e)
    {
      MeiAtt_controller.RemoveAttribute(e, "evidence");
    }
    #endregion

  }

}