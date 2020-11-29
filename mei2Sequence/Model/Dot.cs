using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Dot : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Dot() : base(ObjectType.Dot) { }
  }
}
