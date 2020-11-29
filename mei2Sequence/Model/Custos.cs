using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Custos : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Custos() : base(ObjectType.Custos) { }

    /// <summary>
    /// Stores pitch location as Base-40 value
    /// </summary>
    [DataMember()]
    public int PitchLocation { get; internal set; }
  }
}
