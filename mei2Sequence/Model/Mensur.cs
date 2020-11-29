using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Mensur : Proportion
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Mensur() : base(ObjectType.Mensur) { }

    /// <summary>
    /// Brevis-Semibrevis relationship
    /// </summary>
    [DataMember()]
    public int Tempus { get; internal set; }

    /// <summary>
    /// Semibrevis-Minima relationship
    /// </summary>
    [DataMember()]
    public int Prolatio { get; internal set; }

    /// <summary>
    /// Longa-Brevis relationship
    /// </summary>
    [DataMember()]
    public int Modus { get; internal set; }

    /// <summary>
    /// Maxima-Longa relationship
    /// </summary>
    [DataMember()]
    public int Maximodus { get; internal set; }
  }
}
