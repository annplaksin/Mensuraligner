using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mehroz;

namespace mei2Sequence.Model
{
  [DataContract(), KnownType(typeof(Note))]
  public class Rest : MetricObject
  {
    /// <summary>
    /// Constructor sets ObjectType
    /// </summary>
    public Rest() : base(ObjectType.Rest) { }

    /// <summary>
    /// Protected constructor to invoke inherited classes with type
    /// </summary>
    /// <param name="_type">Object type</param>
    protected Rest(ObjectType _type) : base(_type)
    {
      if (_type != ObjectType.Note)
      {
        throw new InvalidOperationException("Invalid ObjectType!");
      }
    }

    /// <summary>
    /// Duration
    /// </summary>
    [DataMember()]
    public Duration Duration { get; internal set; }

    /// <summary>
    /// Breve units within musical section
    /// </summary>
    [DataMember()]
    public Fraction BrevePosition { get; internal set; }

    /// <summary>
    /// Breve unit after a gap...
    /// </summary>
    [DataMember()]
    public Fraction AfterGapPosition { get; internal set; }

    /// <summary>
    /// Breve Unit without summation
    /// </summary>
    [DataMember()]
    public Fraction BreveDuration { get; internal set; }

    /// <summary>
    /// Fraction within musical section
    /// </summary>
    //public decimal SectionPosition { get; internal set; }

    /// <summary>
    /// Fraction within musical phrase of a vocal work with full text underlay
    /// </summary>
    //public decimal PhrasePosition { get; internal set; }
  }
}
