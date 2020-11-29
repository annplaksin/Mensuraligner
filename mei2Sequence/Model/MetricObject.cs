using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mehroz;

namespace mei2Sequence.Model
{
  [KnownType(typeof(Proportion))]
  [DataContract]
  public abstract class MetricObject : ObjectInSequence
  {
    /// <summary>
    /// Costructor with type
    /// </summary>
    /// <param name="_type">ObjectType</param>
    protected MetricObject(ObjectType _type) : base(_type) { }

    /// <summary>
    /// Gets @num attribute
    /// </summary>
    [DataMember()]
    public int Num { get; internal set; }

    /// <summary>
    /// Gets @numbase
    /// </summary>
    [DataMember()]
    public int Numbase { get; internal set; }

    /// <summary>
    /// @num / @numbase
    /// </summary>
    public Fraction Ratio
    {
      get
      {
        if(Num == 0 || Numbase == 0)
        {
          return new Fraction(1);
        }
        else
        {
          return new Fraction(Num, Numbase);
        }
      }
    }
  }
}
