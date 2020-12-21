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
  /// Interface for att.agentident
  /// </summary>
  public interface IAttAgentident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.agentident
  /// </summary>
  public static class AttAgentident_extensions
  {
    #region agent
    
    public static void SetAgent(this IAttAgentident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "agent", _val);
    }

    public static XAttribute GetAgentAttribute(this IAttAgentident e)
    {
      return MeiAtt_controller.GetAttribute(e, "agent");
    }
    
    public static string GetAgentValue(this IAttAgentident e)
    {
      return MeiAtt_controller.GetAttributeValue(e, "agent");
    }
    
    public static bool HasAgent(this IAttAgentident e)
    {
      return MeiAtt_controller.HasAttribute(e, "agent");
    }

    public static void RemoveAgent(this IAttAgentident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "agent");
    }
    #endregion

  }

}