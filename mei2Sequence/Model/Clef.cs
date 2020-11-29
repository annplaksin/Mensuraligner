using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Clef : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Clef() : base(ObjectType.Clef) { }

    /// <summary>
    /// Number of line upon which clef stands, from lowest uo.
    /// </summary>
    [DataMember()]
    public int Line { get; internal set; }

    /// <summary>
    /// Shape of Clef
    /// </summary>
    [DataMember()]
    public Model.Clefshape Shape { get; internal set; }
  }
}
