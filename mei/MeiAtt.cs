using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  /// <summary>
  /// Basic interface for all attribute class interfaces
  /// </summary>
  public interface IMEiAtt
  {
    void Add(Object obj);

    XAttribute Attribute(XName name);

    IEnumerable<XAttribute> Attributes(XName name);
    
  }

  /// <summary>
  /// Basis extension class for all attribute class extension classes
  /// </summary>
  public static class MeiAtt_controller
  {
    //Declare XLink namespace
    private static readonly XNamespace xlink = "http://www.w3.org/1999/xlink";
    
    #region SetAttribute
    /// <summary>
    /// Sets the value of an attribute by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_val">value to set</param>
    internal static void SetAttribute(IMEiAtt e, string _name, string _val)
    {
      if (_name.StartsWith("xml:"))
      {
        SetAttribute(e, _name.Substring(4), XNamespace.Xml, _val);
      }
      else if (_name.StartsWith("xlink:"))
      {
        SetAttribute(e, _name.Substring(6), xlink, _val);
      }
      else
      {
        if (HasAttribute(e, _name))
        {
          e.Attribute(_name).SetValue(_val);
        }
        else
        {
          e.Add(new XAttribute(_name, _val));
        }
      }
    }

    /// <summary>
    /// Sets the value of an attribute by name and namespace
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <param name="_val">value to set</param>
    internal static void SetAttribute(IMEiAtt e, string _name, XNamespace _ns, string _val)
    {
      if (HasAttribute(e, _name, _ns))
      {
        e.Attribute(_ns + _name).SetValue(_val);
      }
      else
      {
        e.Add(new XAttribute(_ns + _name, _val));
      }
    }
    #endregion

    #region GetAttribute
    /// <summary>
    /// Get an attribute from an element by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <returns></returns>
    internal static XAttribute GetAttribute(IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        return GetAttribute(e, _name.Substring(4), XNamespace.Xml);
      }
      else if (_name.StartsWith("xlink:"))
      {
        return GetAttribute(e, _name.Substring(6), xlink);
      }
      else
      {
        if (HasAttribute(e, _name))
        {
          return e.Attribute(_name);
        }
        else
        {
          return null;
        }
      }
    }

    /// <summary>
    /// Get an attribute from an element by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <returns></returns>
    internal static XAttribute GetAttribute(IMEiAtt e, string _name, XNamespace _ns)
    {
      if (HasAttribute(e, _name, _ns))
      {
        return e.Attribute(_ns + _name);
      }
      else
      {
        return null;
      }

    }
    #endregion

    #region GetAttributeValue
    /// <summary>
    /// Returns value of an attribute.
    /// </summary>
    /// <param name="e">Element</param>
    /// <param name="_name">Name of attribute</param>
    /// <returns>Attribute value as string</returns>
    internal static string GetAttributeValue(IMEiAtt e, string _name)
    {
      return HasAttribute(e, _name) ? GetAttribute(e, _name)?.Value : null;
    }

    /// <summary>
    /// Returns value of a namespaced attribute.
    /// </summary>
    /// <param name="e">Element</param>
    /// <param name="_name">Name of attribute</param>
    /// <param name="_ns">Namespace of attributr</param>
    /// <returns>Attribute value as string</returns>
    internal static string GetAttributeValue(IMEiAtt e, string _name, XNamespace _ns)
    {
      return HasAttribute(e, _name, _ns) ? GetAttribute(e, _name, _ns)?.Value : null;
    }
    #endregion

    #region HasAttribute
    /// <summary>
    /// Checks if element has an attribute with defined name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <returns></returns>
    internal static bool HasAttribute(IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        return HasAttribute(e, _name.Substring(4), XNamespace.Xml);
      }
      else if (_name.StartsWith("xlink:"))
      {
        return HasAttribute(e, _name.Substring(6), xlink);
      }
      else
      {
        return (e.Attributes(_name).Count() > 0);
      }
    }

    /// <summary>
    /// Checks if element has an attribute with defined name and namespace
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <returns></returns>
    internal static bool HasAttribute(IMEiAtt e, string _name, XNamespace _ns)
    {
      return (e.Attributes(_ns + _name).Count() > 0);
    }
    #endregion

    #region RemoveAttribute
    /// <summary>
    /// Removes attribute
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">Name of attribute</param>
    internal static void RemoveAttribute(IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        RemoveAttribute(e, _name.Substring(4), XNamespace.Xml);
      }
      else if (_name.StartsWith("xlink:"))
      {
        RemoveAttribute(e, _name.Substring(6), xlink);
      }
      else
      {
        if (HasAttribute(e, _name))
        {
          e.Attribute(_name).Remove();
        }
      }
    }

    /// <summary>
    /// Removes namespaced attribute
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    internal static void RemoveAttribute(IMEiAtt e, string _name, XNamespace _ns)
    {
      if (HasAttribute(e, _name, _ns))
      {
        e.Attribute(_ns + _name).Remove();
      }
    }
    #endregion
  }
}
