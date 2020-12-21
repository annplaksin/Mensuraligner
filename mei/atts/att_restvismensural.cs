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
  /// Interface for att.rest.vis.mensural
  /// </summary>
  public interface IAttRestVisMensural : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.rest.vis.mensural
  /// </summary>
  public static class AttRestVisMensural_extensions
  {
    #region spaces
    
    public static void SetSpaces(this IAttRestVisMensural e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "spaces", _val);
    }

    public static XAttribute GetSpacesAttribute(this IAttRestVisMensural e)
    {
      return MeiAtt_controller.GetAttribute(e, "spaces");
    }
    
    public static string GetSpacesValue(this IAttRestVisMensural e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "spaces");
    }
    
    public static bool HasSpaces(this IAttRestVisMensural e)
    {
      return MeiAtt_controller.HasAttribute(e, "spaces");
    }

    public static void RemoveSpaces(this IAttRestVisMensural e)
    {
      MeiAtt_controller.RemoveAttribute(e, "spaces");
    }
    #endregion

  }

}