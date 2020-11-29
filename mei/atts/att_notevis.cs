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
  /// Interface for att.note.vis
  /// </summary>
  public interface IAttNoteVis : IMEiAtt, IAttAltsym, IAttColor, IAttColoration, IAttEnclosingchars, IAttRelativesize, IAttStaffloc, IAttStemmed, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy
  {

  }


    /// <summary>
  /// Extension methods for att.note.vis
  /// </summary>
  public static class AttNoteVis_extensions
  {
    #region headshape
    
    public static void SetHeadshape(this IAttNoteVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "headshape", _val);
    }

    public static XAttribute GetHeadshapeAttribute(this IAttNoteVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "headshape");
    }

    public static string GetHeadshapeValue(this IAttNoteVis e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "headshape");
    }

    public static bool HasHeadshape(this IAttNoteVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "headshape");
    }

    public static void RemoveHeadshape(this IAttNoteVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "headshape");
    }
    #endregion

  }

}