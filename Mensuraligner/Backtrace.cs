using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// A Backtrace
  /// </summary>
  public class Backtrace
  {
    private decimal decLastDifference;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="_diference">The difference of the Alignment for initializing the Counting of Changes</param>
    public Backtrace(decimal _diference)
    {
      this.decLastDifference = _diference;
    }

    /// <summary>
    /// The coordinates of the way back starting at the end
    /// </summary>
    public List<Tuple<ushort, ushort>> WayBack
    {
      get;
      private set;
    } = new List<Tuple<ushort, ushort>>();

    /// <summary>
    /// The Number of changes that needed to be made for this Backtrace
    /// </summary>
    public int CountChanges
    {
      get;
      private set;
    } = 0;

    /// <summary>
    /// Adds the next waypoint to the Wayback
    /// </summary>
    /// <param name="_x"></param>
    /// <param name="_y"></param>
    /// <param name="_difference"></param>
    public void AddWaypoint(ushort _x, ushort _y, decimal _difference)
    {
      WayBack.Add(Tuple.Create(_x, _y));
      if (_difference < this.decLastDifference)
      {
        CountChanges++;
        this.decLastDifference = _difference;
      }
    }

    /// <summary>
    /// Get a copy of this backtrace
    /// </summary>
    /// <returns></returns>
    public Backtrace Copy()
    {
      Backtrace btCopy = new Backtrace(this.decLastDifference);
      btCopy.CountChanges = this.CountChanges;
      btCopy.WayBack = new List<Tuple<ushort, ushort>>(this.WayBack);

      return btCopy;
    }
  }
}
