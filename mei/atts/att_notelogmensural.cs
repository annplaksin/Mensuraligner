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
  /// Interface for att.note.log.mensural
  /// </summary>
  public interface IAttNoteLogMensural : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.note.log.mensural
  /// </summary>
  public static class AttNoteLogMensural_extensions
  {
    #region lig
    
    public static void SetLig(this IAttNoteLogMensural e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lig", _val);
    }

    public static XAttribute GetLigAttribute(this IAttNoteLogMensural e)
    {
      return MeiAtt_controller.GetAttribute(e, "lig");
    }

    public static string GetLigValue(this IAttNoteLogMensural e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "lig");
    }

    public static bool HasLig(this IAttNoteLogMensural e)
    {
      return MeiAtt_controller.HasAttribute(e, "lig");
    }

    public static void RemoveLig(this IAttNoteLogMensural e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lig");
    }
    #endregion

  }

}