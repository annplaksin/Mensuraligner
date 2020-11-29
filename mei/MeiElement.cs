using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  public abstract class MeiElement : XElement, IAttId
  {
    public static readonly XNamespace meins = "http://www.music-encoding.org/ns/mei";

    //public string ID { get; set; } = null;

    #region Constructors
    /// <summary>
    /// Constroctor with MEI namespace
    /// </summary>
    /// <param name="_name">name of element</param>
    public MeiElement(string _name) : base(meins + _name)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with MEI namespace and content
    /// </summary>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    public MeiElement(string _name, params object[] _content) : base(meins + _name, _content)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with MEI namespace and content
    /// </summary>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    public MeiElement(string _name, object _content) : base(meins + _name, _content)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace
    /// </summary>
    /// <param name="_namespace">namespace of element</param>
    /// <param name="_name">name of element</param>
    protected MeiElement(XNamespace _namespace, string _name) : base (_namespace + _name)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace and content
    /// </summary>
    /// <param name="_namespace">namespace of element</param>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    protected MeiElement(XNamespace _namespace, string _name, object _content) : base(_namespace + _name, _content)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace and content
    /// </summary>
    /// <param name="_namespace">namespace of element</param>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    protected MeiElement(XNamespace _namespace, string _name, params object[] _content) : base (_namespace + _name, _content)
    {
      this.GenerateAndSetID();
    }
    #endregion

    private void GenerateAndSetID()
    {
      if(this.HasId() == false)
      {
        this.SetId(string.Concat("m-", Guid.NewGuid().ToString().ToLower()));
      }
    }

    public string GetName()
    {
      return this.Name.LocalName;
    }

    //GetValue(_bla) -> this.Value

    //SetValue(_bla) -> XElement.SetValue (object value)

    //getTail & setTail are not available... no proper handling of mixed content in Linq to Xml

    #region obfuscated XElement methods
    /*
     * Makes the axis methods of XElement available within libmei and masks the XElement.Name with MEI object types.
     * E.G.: beam_object.Elements<Note>() returns all children Note objects of this Beam object.
     */

    /// <summary>
    /// Returns a collection of all ancestors
    /// Obfuscation of XElement.Ancestors()
    /// </summary>
    /// <returns>Collection of ancestor elements</returns>
    public new IEnumerable<MeiElement> Ancestors()
    {
      return base.Ancestors().Cast<MeiElement>();
    }

    /// <summary>
    /// Returns a collection of ancestors of the given type
    /// Obfuscation of XElement.Ancestors(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>Collection of ancestor elements of the given type</returns>
    public IEnumerable<T> Ancestors<T>() where T : MeiElement
    {
      return base.Ancestors().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns a collection of all ancestors (including self)
    /// Obfuscation of XElement.AncestorsAndSelf()
    /// </summary>
    /// <returns>Collection of ancestor elements</returns>
    public new IEnumerable<MeiElement> AncestorsAndSelf()
    {
      return base.AncestorsAndSelf().Cast<MeiElement>();
    }

    /// <summary>
    /// Returns a collection of ancestors (including self) of the given type
    /// Obfuscation of XElement.AncestorsAndSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>Collection of ancestor elements of the given type</returns>
    public IEnumerable<T> AncestorsAndSelf<T>() where T : MeiElement
    {
      return base.AncestorsAndSelf().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns a collection of all descendants
    /// Obfuscation of XElement.Descendants()
    /// </summary>
    /// <returns>Collection of descendants elements</returns>
    public new IEnumerable<MeiElement> Descendants()
    {
      return base.Descendants().Cast<MeiElement>();
    }

    /// <summary>
    /// Returns a collection of descendants of the given type
    /// Obfuscation of XElement.Descendants(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>Collection of descendants elements of the given type</returns>
    public IEnumerable<T> Descendants<T>() where T : MeiElement
    {
      return base.Descendants().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns a collection of all descendants (including self)
    /// Obfuscation of XElement.DescendantsAndSelf()
    /// </summary>
    /// <returns>Collection of all descendants elements</returns>
    public new IEnumerable<MeiElement> DescendantsAndSelf()
    {
      return base.DescendantsAndSelf().Cast<MeiElement>();
    }

    /// <summary>
    /// Returns a collection of descendants (including self) of the given type
    /// Obfuscation of XElement.DescendantsAndSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>Collection of descendants elements of the given type</returns>
    public IEnumerable<T> DescendantsAndSelf<T>() where T : MeiElement
    {
      return base.DescendantsAndSelf().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns the first child element with specific type
    /// Workaround for XElement.Element(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>First child MeiElement</returns>
    public T Element<T>() where T : MeiElement
    {
      return (T)base.Elements().FirstOrDefault(element => element is T);
    }

    /// <summary>
    /// Returns a collection of all child elements
    /// Obfuscation of XElement.Elements()
    /// </summary>
    /// <returns>collection of all child elements</returns>
    public new IEnumerable<MeiElement> Elements()
    {
      return base.Elements().Cast<MeiElement>();
    }

    /// <summary>
    /// Returns a collection of child elements of the given type
    /// Obfuscation of XElement.Elements(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of child elements of the given type</returns>
    public IEnumerable<T> Elements<T>() where T : MeiElement
    {
      return base.Elements().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns a collection of all sibling element after the current node
    /// Obfuscation of XElement.ElementsAfterSelf()
    /// </summary>
    /// <returns>Collection of sibling elements</returns>
    public new IEnumerable<MeiElement> ElementsAfterSelf()
    {
      return base.ElementsAfterSelf().Cast<MeiElement>();
    }

    /// <summary>
    /// Return collection of sibling elements of the given type after the current node
    /// Obfuscation of XElement.ElementsAfterSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of sibling elements of the given type</returns>
    public IEnumerable<T> ElementsAfterSelf<T>() where T : MeiElement
    {
      return base.ElementsAfterSelf().Where(element => element is T).Cast<T>();
    }

    /// <summary>
    /// Returns a collection of all sibling element before the current node
    /// Obfuscation of XElement.ElementsBeforeSelf()
    /// </summary>
    /// <returns>Collection of sibling elements</returns>
    public new IEnumerable<MeiElement> ElementsBeforeSelf()
    {
      return base.ElementsBeforeSelf().Cast<MeiElement>();
    }

    /// <summary>
    /// Return collection of sibling elements of the given type before the current node
    /// Obfuscation of XElement.ElementsBeforeSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of sibling elements of the given type</returns>
    public IEnumerable<T> ElementsBeforeSelf<T>() where T : MeiElement
    {
      return base.ElementsBeforeSelf().Where(element => element is T).Cast<T>();
    }
    #endregion

    #region Attribute methods
    //this.HasAttributes

    //getAttributes() -> XElement.Attributes()

    //setAttributes() -> within constructor or: for each (att in atts( {element.Add(att);} and 

    //setAttribute() XElement.SetAttributeValue(XName, Object)

    //addAttribute() -> XElement.Add(attribute)
    #endregion

    #region Parent methods
    //getParent() -> this.Parent

    /// <summary>
    /// Changes parent of current element
    /// </summary>
    /// <param name="_parent">new parent node</param>
    public void SetParent(XElement _parent)
    {
      //Remove current element from its parent
      this.Remove();

      //Add current element to new parent node
      _parent.Add(this);
    }

    /// <summary>
    /// Checks for parent of an element
    /// </summary>
    /// <returns>true if element has parent</returns>
    public bool HasParent()
    {
      return (this.Parent != null) ;
    }
    #endregion

    #region Children methods
    //addChild(MeiElement* child) -> this.Add(child)

    //XElement.SetElementValue(XName, Object)

    //addChildBefore() -> XElement.AddBeforeSelf(Object) & XElement.AddAfterSelf(Object)

    /// <summary>
    /// Set the children of this element to be the given children.
    /// This will remove any existing children!
    /// </summary>
    /// <param name="_newChildren">Collection of new children</param>
    public void SetChildren(IEnumerable<MeiElement> _newChildren)
    {
      ReplaceNodes(_newChildren);
    }

    /// <summary>
    /// Get all of the children of this element.
    /// </summary>
    /// <returns>IEnumerable with all children</returns>
    public IEnumerable<MeiElement> GetChildren()
    {
      return this.Elements();
    }

    /// <summary>
    /// Get all of the children of this element that have a given type.
    /// </summary>
    /// <returns>IEnumerable with children</returns>
    public IEnumerable<T> GetChildrenByType<T> () where T : MeiElement
    {
      return this.Elements<T>();
    }
    
    /// <summary>
    /// Remove all of the children of this element.
    /// The children are deleted and removed from the element.
    /// </summary>
    public void DeleteAllChildren()
    {
      foreach (MeiElement child in this.Elements())
      {
        child.Remove();
      }
    }

    /// <summary>
    /// Remove the children from this element that have a given type.
    /// </summary>
    /// <typeparam name="T">Type of MeiElement</typeparam>
    public void RemoveChildrenByType<T>() where T : MeiElement
    {
      foreach (T child in Elements<T>())
      {
        child.Remove();
      }
    }

    /// <summary>
    /// Remove the specified element as a child from this element.
    /// Elements are compared by memory address. It is the responsibility
    /// of the caller to free elements after they have been removed.
    /// </summary>
    /// <param name="_child">Child to be removed</param>
    public void RemoveChild(MeiElement _child)
    {
      _child.Remove();
    }

    /// <summary>
    /// Check if this element has any children with the given type.
    /// </summary>
    /// <returns>true if element has children with given type</returns>
    public bool HasChildren<T>() where T : MeiElement
    {
      return (Elements<T>().Count() > 0);
    }

    //hasChildren() -> this.HasElements

    #endregion
  }
}
