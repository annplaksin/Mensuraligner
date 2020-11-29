using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mei2Sequence.Model
{

  [KnownType(typeof(Accidental)),
    KnownType(typeof(Barline)),
    KnownType(typeof(Clef)),
    KnownType(typeof(Custos)),
    KnownType(typeof(Dot)),
    KnownType(typeof(Gap)),
    KnownType(typeof(KeyAccidental)),
    // KnownType(typeof(Mensur)),
    KnownType(typeof(MetricObject)),
    // KnownType(typeof(Note)),
    // KnownType(typeof(Proportion)),
    KnownType(typeof(Rest))]
  [DataContract]
  public abstract class ObjectInSequence
  {
    /// <summary>
    /// Type of object
    /// </summary>
    [DataMember()]
    public ObjectType Type { get; internal set; }

    /// <summary>
    /// Stores pointer to parent sequence object
    /// </summary>
    [DataMember()]
    public Sequence ParentSequence { get; internal set; }

    /// <summary>
    /// Position counter of object in sequence
    /// </summary>
    [DataMember()]
    public int Position { get; internal set; }

    /// <summary>
    /// Xml-ID of object, not to be compared
    /// </summary>
    [DataMember()]
    public string ID { get; internal set; }

    /// <summary>
    /// Gives information about the evidence of an object, if it is clearly readable or unclear.
    /// </summary>
    [DataMember()]
    public Evidence Evidence { get; internal set; }

    /// <summary>
    /// ID of parent phrase (matching verse element in vocal works with full lyrics)
    /// </summary>
    [DataMember()]
    public string ParentPhrase { get; internal set; }

    /// <summary>
    /// Constructor without parameters
    /// </summary>
    private ObjectInSequence() { }

    /// <summary>
    /// Constructor with Type
    /// </summary>
    /// <param name="_type">Type of Object</param>
    public ObjectInSequence(ObjectType _type)
    {
      this.Type = _type;
    }
  }
}
