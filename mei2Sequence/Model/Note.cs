using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Note : Rest
  {
    public Note() : base(ObjectType.Note) { }

    /// <summary>
    /// Pitch without accidentals
    /// </summary>
    [DataMember()]
    public int WrittenPitch { get; internal set; }

    /// <summary>
    /// Pitch with written accidentals.
    /// This is not meant to be musically correct!
    /// </summary>
    [DataMember()]
    public int PitchWithAccid { get; internal set; }

    /// <summary>
    /// Not has fermata
    /// </summary>
    [DataMember()]
    public bool Fermata { get; internal set; }

    /// <summary>
    /// Note is colored (semantically)
    /// </summary>
    [DataMember()]
    public bool Coloration { get; internal set; }

    /// <summary>
    /// Position within ligature (1-n), 0 if note is not in a ligature
    /// </summary>
    [DataMember()]
    public int LigaturePosition { get; internal set; }

    /// <summary>
    /// Stores stem orientation
    /// </summary>
    [DataMember()]
    public StemDesc Stem { get; internal set; }

    /// <summary>
    /// Stores form of ligature
    /// </summary>
    [DataMember()]
    public LigatureForm LigatureForm { get; internal set; }

    /// <summary>
    /// Stores inflection modifier from @accid.ges
    /// </summary>
    [DataMember()]
    public AccidType AccidGes { get; internal set; }
  }
}
