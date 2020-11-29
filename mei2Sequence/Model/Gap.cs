using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Gap : ObjectInSequence
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Gap() : base(ObjectType.Gap) { }

    /// <summary>
    /// Type: Gap or damage.
    /// </summary>
    [DataMember()]
    public GapType GapType { get; internal set; }

    /// <summary>
    /// Stores @reason of <gap/> or @agent of <damage/>.
    /// </summary>
    [DataMember()]
    public string Reason { get; internal set; }
  }
}
