using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [KnownType(typeof(Mensur))]
  [DataContract]
  public class Proportion : MetricObject
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Proportion() : base(ObjectType.Proportion) { }

    /// <summary>
    /// Protected constructor to invoke inherited classes with type
    /// </summary>
    /// <param name="_type">Object type</param>
    protected Proportion(ObjectType _type) : base(_type)
    {
      if (_type != ObjectType.Mensur)
      {
        throw new InvalidOperationException("Invalid ObjectType!");
      }
    }

    /// <summary>
    /// Duration affected by proportion
    /// </summary>
    [DataMember()]
    public Duration Affected { get; internal set; }

    /// <summary>
    /// Shortcut for used sign from list
    /// </summary>
    [DataMember()]
    public Sign Sign { get; internal set; }
  }
}
