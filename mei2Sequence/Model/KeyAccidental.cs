using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class KeyAccidental : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public KeyAccidental() : base(ObjectType.KeyAccidental) { }

    /// <summary>
    /// Protected constructor to invoke inherited classes with type
    /// </summary>
    /// <param name="_type">Object type</param>
    protected KeyAccidental(ObjectType _type) : base(_type)
    {
      if (_type != ObjectType.Accidental)
      {
        throw new InvalidOperationException("Invalid ObjectType!");
      }
    }

    /// <summary>
    /// Type of accidental
    /// </summary>
    [DataMember()]
    public AccidType AccidentalType { get; internal set; }

    /// <summary>
    /// Affected diatonic pitch in base-40
    /// </summary>
    [DataMember()]
    public int PitchLocation { get; internal set; }
  }
}
