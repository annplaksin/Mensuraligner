using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// The direction from which the alignment was calculated - used for backtracing
  /// </summary>
  [Flags()]
  public enum NeedlemanWunschAlignDirection
  {
    /// <summary>
    /// Invalid Entry
    /// </summary>
    Invalid = 0,
    /// <summary>
    /// The alignment was calculated from the top cell
    /// </summary>
    Above = 1,
    /// <summary>
    /// The alignment was calculated from the left cell
    /// </summary>
    Left = 2,
    /// <summary>
    /// The alignment was calculated from the diagonal cell
    /// </summary>
    Diagonal = 4
  }
}
