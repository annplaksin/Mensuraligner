using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Accidental : KeyAccidental
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Accidental() : base(ObjectType.Accidental) { }

    /// <summary>
    /// Position of accidental relative to following note
    /// </summary>
    [DataMember()]
    public Position AccidentalPosition { get; internal set; }
  }
}
