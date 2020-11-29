using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// A class to hold all information of an alignment of two sequenceobjects
  /// </summary>
  public class NeedlemanWunschAlignObject
  {

    /// <summary>
    /// The calculated alignment of this object/cell
    /// </summary>
    public decimal Alignment
    {
      get;
      set;
    } = -1m;

    /// <summary>
    /// This Alignment is set when the Cell is contained in an Consolidation/Fragmentation
    /// It is used for cells that would break out of the Consolidation/Fragmentation
    /// </summary>
    public decimal AlignmentWithoutConsolidationFragmentation
    {
      get;
      set;
    } = -1m;

    /// <summary>
    /// The direction from which this was calculated
    /// </summary>
    public NeedlemanWunschAlignDirection AlignDirection
    {
      get;
      set;
    } = NeedlemanWunschAlignDirection.Invalid;

    /// <summary>
    /// The direction from which this was calculated when the Cell is contained in an Consolidation/Fragmentation
    /// It is used for cells that would break out of the Consolidation/Fragmentation
    /// </summary>
    public NeedlemanWunschAlignDirection AlignDirectionWithoutConsolidationFragmentation
    {
      get;
      set;
    } = NeedlemanWunschAlignDirection.Invalid;

    /*
    /// <summary>
    /// Was the alignment calculated with a consolidation or fragmentation?
    /// </summary>
    public bool ConsolidationFragmentation
    {
      get;
      set;
    } = false;

    /// <summary>
    /// Flag that this alignment is the start of an consolidation/fragmentation
    /// </summary>
    public bool ConsolidationFragmentationStart
    {
      get;
      set;
    } = false;

    /// <summary>
    /// Flag that this alignment is the end of an consolidation/fragmentation
    /// </summary>
    public bool ConsolidationFragmentationEnd
    {
      get;
      set;
    } = false;
    */
  }
}
