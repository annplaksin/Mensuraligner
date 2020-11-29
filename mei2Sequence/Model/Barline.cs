using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Barline : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Barline() : base(ObjectType.Barline) { }

    [DataMember()]
    public BarlineType BarlineType { get; internal set; }
  }
}
