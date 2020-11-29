using Mehroz;
using mei2Sequence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensuraligner
{
  /// <summary>
  /// Class to build a Needleman-Wunsch over 2 given Sequences
  /// </summary>
  public class NeedlemanWunsch
  {
    #region Members
    private NeedlemanWunschAlignObject[,] arrAlignment;
    private Tuple<int, int>[,] backtraceOptimums;
    private List<Backtrace> lstBacktraces;
    private List<ObjectInSequence> objectsA, objectsB;
    private NeedlemanWunschOptions options;

    /// <summary>
    /// List in which we collect all the consolidations/fragmentations
    /// </summary>
    private List<List<NeedlemanWunschAlignObject>> lstConsolidationsFragmentations = new List<List<NeedlemanWunschAlignObject>>();
    /// <summary>
    /// After we collected all consolidations/fragmentations we put them into this array
    /// </summary>
    private List<List<NeedlemanWunschAlignObject>>[,] arrConsolidationFragmentation;

    private bool bolSingleBacktrace = false;


    #endregion

    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="_sequencA">List of Sequences A</param>
    /// <param name="_sequenceB">List of Sequences B</param>
    /// <param name="_options">The Options to build the Alignment</param>
    /// <param name="_singleBacktrace">Should we calculate only a single backtrace?</param>
    public NeedlemanWunsch(
      List<Sequence> _sequencA,
      List<Sequence> _sequenceB,
      NeedlemanWunschOptions _options,
      bool _singleBacktrace = false)
    {
      // Write everything in their members
      this.objectsA = new List<ObjectInSequence>();
      _sequencA.ForEach(item => this.objectsA.AddRange(item.ObjectsInSequence));
      this.objectsB = new List<ObjectInSequence>();
      _sequenceB.ForEach(item => this.objectsB.AddRange(item.ObjectsInSequence));
      this.options = _options;
      this.bolSingleBacktrace = _singleBacktrace;

      Initialize();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="_sequencA">List of ObjectsInSequence A</param>
    /// <param name="_sequenceB">List of ObjectsInSequence B</param>
    /// <param name="_options">The Options to build the Alignment</param>
    /// <param name="_singleBacktrace">Should we calculate only a single backtrace?</param>
    public NeedlemanWunsch(
      List<ObjectInSequence> _sequencA, 
      List<ObjectInSequence> _sequenceB,
      NeedlemanWunschOptions _options,
      bool _singleBacktrace = false)
    {
      this.objectsA = _sequencA;
      this.objectsB = _sequenceB;
      this.options = _options;
      this.bolSingleBacktrace = _singleBacktrace;

      Initialize();
    }
    #endregion

    #region Properties
    /// <summary>
    /// Get the calculated AlignmentMatrix
    /// </summary>
    public NeedlemanWunschAlignObject[,] Alignments
    {
      get
      {
        return this.arrAlignment;
      }
    }

    /// <summary>
    /// Get the calculated Distance
    /// </summary>
    public decimal Distance
    {
      get
      {
        return this.arrAlignment[this.arrAlignment.GetLength(0) - 1, this.arrAlignment.GetLength(1) - 1].Alignment;
      }
    }

    /// <summary>
    /// Get the backtrace(s) from the AlignmentMatrix
    /// </summary>
    public List<Backtrace> Backtraces
    {
      get
      {
        return lstBacktraces;
      }
    }

    /// <summary>
    /// Returns this Number of Changes that needed to be done for the Alignment
    /// </summary>
    public int NumberOfChanges
    {
      get
      {
        if (this.lstBacktraces.Count > 0)
        {
          return this.lstBacktraces[0].CountChanges;
        }
        else
        {
          return 0;
        }
      }
    }

    /// <summary>
    /// Returns the real number of backtraces in case we have so many that we hit the threshhold
    /// </summary>
    public int CountBacktraces
    {
      get;
      private set;
    } = 0;

    /// <summary>
    /// Sequence A from which the Alignment was calculated
    /// </summary>
    public List<ObjectInSequence> SequenceA
    {
      get
      {
        return this.objectsA;
      }
    }

    /// <summary>
    /// Sequence B from which the Alignment was calculated
    /// </summary>
    public List<ObjectInSequence> SequenceB
    {
      get
      {
        return this.objectsB;
      }
    }
    #endregion

    #region Private Helpers
    private void Initialize()
    {
      // If wanted remove everything except notes and rests (and damages)
      if (this.options.UberLogic)
      {
        this.objectsA = new List<ObjectInSequence>(this.objectsA.Where(item => item.Type == ObjectType.Note || item.Type == ObjectType.Rest || item.Type == ObjectType.Gap));
        this.objectsB = new List<ObjectInSequence>(this.objectsB.Where(item => item.Type == ObjectType.Note || item.Type == ObjectType.Rest || item.Type == ObjectType.Gap));
      }

      // Initialize the AlignmentArray - Count + 1 for every dimension
      this.arrAlignment = new NeedlemanWunschAlignObject[this.objectsA.Count + 1, this.objectsB.Count + 1];
      this.backtraceOptimums = new Tuple<int, int>[this.objectsA.Count + 1, this.objectsB.Count + 1];
      // And fill an Object into each cell
      for (int intIndexA = 0; intIndexA <= this.objectsA.Count; intIndexA++)
      {
        for (int intIndexB = 0; intIndexB <= this.objectsB.Count; intIndexB++)
        {
          this.arrAlignment[intIndexA, intIndexB] = new NeedlemanWunschAlignObject();
        }
      }

      // Now let the games begin
      this.BuildAlignments();
      this.BuildConsolidationsFragmentations();
      this.BuildBacktraces();
    }

    private void BuildAlignments()
    {
      // First write the "gap" weight in every zero-field
      for (int intIndex = 0; intIndex <= this.objectsA.Count; intIndex++)
      {
        this.arrAlignment[intIndex, 0].Alignment = intIndex * this.options.GapPenalty;
        this.arrAlignment[intIndex, 0].AlignDirection = NeedlemanWunschAlignDirection.Above;
      }
      for (int intIndex = 0; intIndex <= this.objectsB.Count; intIndex++)
      {
        this.arrAlignment[0, intIndex].Alignment = intIndex * this.options.GapPenalty;
        this.arrAlignment[0, intIndex].AlignDirection = NeedlemanWunschAlignDirection.Left;
      }
      // Write Invalid in the topupper cell
      this.arrAlignment[0, 0].AlignDirection = NeedlemanWunschAlignDirection.Invalid;

      #region Unused Code
      /* Was never used...
      // Then get the min and max duration for each sequence
      Duration durationMinA = Duration.Maxima, durationMaxA = Duration.Semifusa, durationMinB = Duration.Maxima, durationMaxB = Duration.Semifusa;
      foreach (ObjectInSequence objAktuell in this.objectsA)
      {
        if (objAktuell is Note objNote)
        {
          // The Duration must be at least a maxima
          if (objNote.Duration >= Duration.Maxima)
          {
            if (objNote.Duration > durationMinA)
            {
              durationMinA = objNote.Duration;
            }
            if (objNote.Duration < durationMaxA)
            {
              durationMaxA = objNote.Duration;
            }
          }
        }
      }
      foreach (ObjectInSequence objAktuell in this.objectsB)
      {
        if (objAktuell is Note objNote)
        {
          // The Duration must be at least a maxima
          if (objNote.Duration >= Duration.Maxima)
          {
            if (objNote.Duration > durationMinB)
            {
              durationMinB = objNote.Duration;
            }
            if (objNote.Duration < durationMaxB)
            {
              durationMaxB = objNote.Duration;
            }
          }
        }
      }
      */
      #endregion

      // Now we'll start the calculation
      for (int intIndexA = 1; intIndexA <= this.objectsA.Count; intIndexA++)
      {
        for (int intIndexB = 1; intIndexB <= this.objectsB.Count; intIndexB++)
        {
          // Now we need to calculate everything
          decimal decReplacement, decInsertion, decDeletion, decFragmentation, decConsolidation;
          // Deletion is the value from the cell above + the distance between objectA and null
          decDeletion = Math.Round(GetAlignment(this.arrAlignment[intIndexA - 1, intIndexB]) + CalculateDistance(null, this.objectsB[intIndexB - 1], this.arrAlignment[intIndexA - 1, intIndexB].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Above)), 10);
          // Replacement is the value from the cell diagonaly above + the cost between the two objects
          decReplacement = Math.Round(GetAlignment(this.arrAlignment[intIndexA - 1, intIndexB - 1]) + CalculateDistance(this.objectsA[intIndexA - 1], this.objectsB[intIndexB - 1]), 10);
          // Insertion is the value from the cell left + the distance between null and objectB
          decInsertion = Math.Round(GetAlignment(this.arrAlignment[intIndexA, intIndexB - 1]) + CalculateDistance(this.objectsA[intIndexA - 1], null, this.arrAlignment[intIndexA, intIndexB - 1].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Left)), 10);
          // Fragmentation
          decFragmentation = Math.Round(GetAlignment(this.arrAlignment[intIndexA - 1, intIndexB - 1]) + CheckFragmentationConsolidation(this.objectsA[intIndexA - 1], this.objectsB, intIndexB - 1, out int intEndFragmentation), 10);
          // Consolidation
          decConsolidation = Math.Round(GetAlignment(this.arrAlignment[intIndexA - 1, intIndexB - 1]) + CheckFragmentationConsolidation(this.objectsB[intIndexB - 1], this.objectsA, intIndexA - 1, out int intEndConsolidation), 10);

          // Now calculate the minimum
          decimal decMinWithoutFragCon = GetMin(decDeletion, decInsertion, decReplacement);
          decimal decMin = GetMin(decMinWithoutFragCon, decFragmentation, decConsolidation);

          // If we have a consolidation/Fragmentation or we are in the middle of one (alignment already calculated) remember the value without it in the object
          if ((decFragmentation == decMin && intEndFragmentation > intIndexB) 
            || (decConsolidation == decMin && intEndConsolidation > intIndexA) 
            || this.arrAlignment[intIndexA, intIndexB].Alignment != -1m)
          {
            this.arrAlignment[intIndexA, intIndexB].AlignmentWithoutConsolidationFragmentation = decMinWithoutFragCon;
            if (decDeletion == decMinWithoutFragCon)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirectionWithoutConsolidationFragmentation |= NeedlemanWunschAlignDirection.Above;
            }
            if (decReplacement == decMinWithoutFragCon)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirectionWithoutConsolidationFragmentation |= NeedlemanWunschAlignDirection.Diagonal;
            }
            if (decInsertion == decMinWithoutFragCon)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirectionWithoutConsolidationFragmentation |= NeedlemanWunschAlignDirection.Left;
            }
          }

          // Only proceed if the current Alignment has never been assigned (-1) or is higher then the current calculated value
          if (this.arrAlignment[intIndexA, intIndexB].Alignment == -1m || decMin < this.arrAlignment[intIndexA, intIndexB].Alignment)
          {
            // If we are at the end of an consolidation/fragmentation remove it!
            if (this.arrAlignment[intIndexA, intIndexB].Alignment != -1m)
            {
              var lst2remove = this.lstConsolidationsFragmentations.Where(lst => lst.IndexOf(this.arrAlignment[intIndexA, intIndexB]) == (lst.Count - 1));

              for (int intIndex = lst2remove.Count() - 1; intIndex >= 0; intIndex--)
              {
                List<NeedlemanWunschAlignObject> lstAktuell = lst2remove.ElementAt(intIndex);

                // Don't touch the last item in the list
                for (int intIndexObjects = 0; intIndexObjects < lstAktuell.Count - 1; intIndexObjects++)
                {
                  NeedlemanWunschAlignObject objAktuell = lstAktuell.ElementAt(intIndexObjects);
                  // Only reset the object if it has an existing AlignmentWithoutConsolidationFragmentation value
                  if (objAktuell.AlignmentWithoutConsolidationFragmentation != -1m)
                  {
                    // Write the "alternative" Alignment
                    objAktuell.Alignment = objAktuell.AlignmentWithoutConsolidationFragmentation;
                    objAktuell.AlignmentWithoutConsolidationFragmentation = -1m;
                    // I think we don't need to adjust the AlignmentDirection because the direction of this node is resettet
                  }
                }
                // Remove it from the list, this one will not be traced back
                this.lstConsolidationsFragmentations.Remove(lstAktuell);
              }
            }
            // Reset the Direction
            this.arrAlignment[intIndexA, intIndexB].AlignDirection = NeedlemanWunschAlignDirection.Invalid;
            // Store the Value in the array
            this.arrAlignment[intIndexA, intIndexB].Alignment = decMin;
            // Now check where the value came from
            if (decDeletion == decMin)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirection |= NeedlemanWunschAlignDirection.Above;
              // if affine gaps are used and we expand a gap check if we need to modify the previous alinment
              if (this.options.UseAffineGaps && this.arrAlignment[intIndexA - 1, intIndexB].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Above))
              {
                // if the cost to expand a gap are smaller then the cost of opening a gap remove the diagonal direction from the field above
                if (this.options.GapExtensionPenalty < this.options.GapPenalty)
                {
                  // Remove Diagonal
                  this.arrAlignment[intIndexA - 1, intIndexB].AlignDirection &= ~NeedlemanWunschAlignDirection.Diagonal;
                }
                // if the cost to expand are lager remove the above direction
                else if(this.options.GapExtensionPenalty > this.options.GapPenalty)
                {
                  // Remove Above
                  this.arrAlignment[intIndexA - 1, intIndexB].AlignDirection &= ~NeedlemanWunschAlignDirection.Above;
                }
              }
            }

            if (decReplacement == decMin)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirection |= NeedlemanWunschAlignDirection.Diagonal;
            }

            if (decInsertion == decMin)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirection |= NeedlemanWunschAlignDirection.Left;
              // if affine gaps are used and we expand a gap check if we need to modify the previous alinment
              if (this.options.UseAffineGaps && this.arrAlignment[intIndexA, intIndexB - 1].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Left))
              {
                // if the cost to expand a gap are smaller then the cost of opening a gap remove the diagonal direction from the field left
                if (this.options.GapExtensionPenalty < this.options.GapPenalty)
                {
                  // Remove Diagonal
                  this.arrAlignment[intIndexA, intIndexB - 1].AlignDirection &= ~NeedlemanWunschAlignDirection.Diagonal;
                }
                // if the cost to expand are lager remove the left direction
                else if (this.options.GapExtensionPenalty > this.options.GapPenalty)
                {
                  // Remove Left
                  this.arrAlignment[intIndexA, intIndexB - 1].AlignDirection &= ~NeedlemanWunschAlignDirection.Left;
                }
              }
            }

            if (decFragmentation == decMin && intEndFragmentation > intIndexB)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirection |= NeedlemanWunschAlignDirection.Diagonal;
              List<NeedlemanWunschAlignObject> lstFragmentation = new List<NeedlemanWunschAlignObject>(intEndFragmentation - intIndexB + 1)
              {
                this.arrAlignment[intIndexA, intIndexB]
              };
              // Additionally write the value in all notes touched by the fragmentation
              for (int intIndexAktuell = intIndexB + 1; intIndexAktuell <= intEndFragmentation; intIndexAktuell++)
              {
                this.arrAlignment[intIndexA, intIndexAktuell].Alignment = decMin;
                this.arrAlignment[intIndexA, intIndexAktuell].AlignDirection = NeedlemanWunschAlignDirection.Left;
                lstFragmentation.Add(this.arrAlignment[intIndexA, intIndexAktuell]);
              }
              this.lstConsolidationsFragmentations.Add(lstFragmentation);
            }

            if (decConsolidation == decMin && intEndConsolidation > intIndexA)
            {
              this.arrAlignment[intIndexA, intIndexB].AlignDirection |= NeedlemanWunschAlignDirection.Diagonal;
              List<NeedlemanWunschAlignObject> lstConsolidation = new List<NeedlemanWunschAlignObject>(intEndConsolidation - intIndexA + 1)
              {
                this.arrAlignment[intIndexA, intIndexB]
              };
              // Additionally write the value in all notes touched by the consolidation
              for (int intIndexAktuell = intIndexA + 1; intIndexAktuell <= intEndConsolidation; intIndexAktuell++)
              {
                this.arrAlignment[intIndexAktuell, intIndexB].Alignment = decMin;
                this.arrAlignment[intIndexAktuell, intIndexB].AlignDirection = NeedlemanWunschAlignDirection.Above;
                lstConsolidation.Add(this.arrAlignment[intIndexAktuell, intIndexB]);
              }
              this.lstConsolidationsFragmentations.Add(lstConsolidation);
            }
          }
        }
      }
    }

    /// <summary>
    /// Calculates the distance between the two given objects
    /// </summary>
    /// <param name="_objectA"></param>
    /// <param name="_objectB"></param>
    /// <param name="_gapOpened">Has the gap been opened? Only necessary for deletion/insertion</param>
    /// <param name="_compareDuration">Should the Duration compared? Default: true. Should only be set to false for consolidatio/fragmentation!</param>
    /// <returns></returns>
    private decimal CalculateDistance(
      ObjectInSequence _objectA, 
      ObjectInSequence _objectB,
      bool _gapOpened = false,
      bool _compareDuration = true)
    {
      // One of the objects can be null
      if (_objectA == null || _objectB == null)
      {
        // If we use affine damages and one of the objects is a gap (=damage) return the Penalty for extending a damage rather then the gap penalty
        if (this.options.UseAffineDamages && ((_objectA != null && _objectA.Type == ObjectType.Gap) || (_objectB != null && _objectB.Type == ObjectType.Gap)))
        {
          return this.options.DamageExtensionPenalty;
        }
        else
        {
          // If affine gaps are used and the gap is opened return the extension penalty - otherwise the opening penalty
          if (this.options.UseAffineGaps && _gapOpened)
          {
            return this.options.GapExtensionPenalty;
          }
          else
          {
            return this.options.GapPenalty;
          }
        }
      }
      else
      {
        // Both objects have a value..
        // First check if the Type matches and one of the objects has the supplied evidence
        if (_objectA.Type == _objectB.Type && (_objectA.Evidence == Evidence.Supplied || _objectB.Evidence == Evidence.Supplied))
        {
          // If both are supplied return zero
          if (_objectA.Evidence == Evidence.Supplied && _objectB.Evidence == Evidence.Supplied)
          {
            return 0m;
          }
          else
          {
            // Treat it as a gap
            return this.options.GapPenalty;
          }
        }
        // Then check for damages
        else if (_objectA.Type == ObjectType.Gap || _objectB.Type == ObjectType.Gap)
        {
          if (_objectA.Type == ObjectType.Gap && _objectB.Type == ObjectType.Gap)
          {
            // Compare the gaps - we take them as equal for the first try
            return 0m;
          }
          else
          {
            return this.options.DamagePenalty;
          }
        }
        else
        {
          // No damage - now the objects need to be of the same type
          if (_objectA.Type == ObjectType.Clef && _objectB.Type == ObjectType.Clef)
          {
            Clef clefA = (Clef)_objectA, clefB = (Clef)_objectB;
            if (clefA.Line == clefB.Line && clefA.Shape == clefB.Shape)
            {
              // Equality
              return 0m;
            }
            else
            {
              return 1m;
            }
          }
          else if (_objectA.Type == ObjectType.KeyAccidental && _objectB.Type == ObjectType.KeyAccidental)
          {
            KeyAccidental kaA = (KeyAccidental)_objectA, kaB = (KeyAccidental)_objectB;
            if (kaA.AccidentalType == kaB.AccidentalType && kaA.PitchLocation == kaB.PitchLocation)
            {
              // Equality
              return 0m;
            }
            else
            {
              return 1m;
            }
          }
          else if (_objectA.Type == ObjectType.Accidental && _objectB.Type == ObjectType.Accidental)
          {
            Accidental accA = (Accidental)_objectA, accB = (Accidental)_objectB;
            if (accA.AccidentalPosition == accB.AccidentalPosition && accA.AccidentalType == accB.AccidentalType && accA.PitchLocation == accB.PitchLocation)
            {
              // Equality
              return 0m;
            }
            else
            {
              return 1m;
            }
          }
          else if (_objectA.Type == ObjectType.Dot && _objectB.Type == ObjectType.Dot)
          {
            // Dot dotA = (Dot)_objectA, dotB = (Dot)_objectB;
            // So far a dot is always equal to any other dot
            return 0m;
          }
          else if (_objectA.Type == ObjectType.Custos && _objectB.Type == ObjectType.Custos)
          {
            Custos custA = (Custos)_objectA, custB = (Custos)_objectB;
            if (custA.PitchLocation == custB.PitchLocation)
            {
              // Equality
              return 0m;
            }
            else
            {
              return 1m;
            }
          }
          else if (_objectA.Type == ObjectType.Barline && _objectB.Type == ObjectType.Barline)
          {
            Barline barA = (Barline)_objectA, barB = (Barline)_objectB;
            if (barA.BarlineType == barB.BarlineType)
            {
              // Equality
              return 0m;
            }
            else
            {
              return 1m;
            }
          }
          else if ((_objectA.Type == ObjectType.Rest || _objectA.Type == ObjectType.Note) && (_objectB.Type == ObjectType.Rest || _objectB.Type == ObjectType.Note))
          {
            #region Rest/Note comparison
            // Compare Note with Note or Rest with Rest
            if (_objectA.Type == ObjectType.Rest && _objectB.Type == ObjectType.Rest)
            {
              Rest resA = (Rest)_objectA, resB = (Rest)_objectB;
              decimal decDistance = 0m, decDivisor = 0m;
              if (_compareDuration && this.options.WeightRestDuration > 0m)
              {
                decDivisor += this.options.WeightRestDuration;
                if (resA.Duration != resB.Duration)
                {
                  decDistance += this.options.WeightRestDuration;
                }
              }
              if (_compareDuration && this.options.WeightRestBreveDuration > 0m)
              {
                decDivisor += this.options.WeightRestBreveDuration;
                if (resA.BreveDuration != resB.BreveDuration)
                {
                  decDistance += this.options.WeightRestBreveDuration;
                }
              }

              if (decDivisor > 0m)
              {
                return decDistance / decDivisor;
              }
              else
              {
                // There was no divisor which means all weights must be 0!
                return 0m;
              }
            }
            else if (_objectA.Type == ObjectType.Note && _objectB.Type == ObjectType.Note)
            {
              Note noteA = (Note)_objectA, noteB = (Note)_objectB;
              decimal decDistance = 0m, decDivisor = 0m;

              if (_compareDuration && this.options.WeightNoteDuration > 0m)
              {
                decDivisor += this.options.WeightNoteDuration;
                if (noteA.Duration != noteB.Duration)
                {
                  decDistance += this.options.WeightNoteDuration;
                }
              }
              if (this.options.WeightNoteWrittenPitch > 0m)
              {
                decDivisor += this.options.WeightNoteWrittenPitch;
                if (noteA.WrittenPitch != noteB.WrittenPitch)
                {
                  decDistance += this.options.WeightNoteWrittenPitch;
                }
              }
              if (this.options.WeightNoteColoration > 0m)
              {
                decDivisor += this.options.WeightNoteColoration;
                if (noteA.Coloration != noteB.Coloration)
                {
                  decDistance += this.options.WeightNoteColoration;
                }
              }
              if(this.options.WeightNoteFermata > 0m)
              {
                decDivisor += this.options.WeightNoteFermata;
                if (noteA.Fermata != noteB.Fermata)
                {
                  decDistance += this.options.WeightNoteFermata;
                }
              }
              if (this.options.WeightNoteLigaturePosition > 0m)
              {
                decDivisor += this.options.WeightNoteLigaturePosition;
                if (noteA.LigaturePosition != noteB.LigaturePosition)
                {
                  decDistance += this.options.WeightNoteLigaturePosition;
                }
              }
              if (this.options.WeightNoteLigatureForm > 0m)
              {
                decDivisor += this.options.WeightNoteLigatureForm;
                if (noteA.LigatureForm != noteB.LigatureForm)
                {
                  decDistance += this.options.WeightNoteLigatureForm;
                }
              }
              if (this.options.WeightNoteStem > 0m)
              {
                decDivisor += this.options.WeightNoteStem;
                if (noteA.Stem != noteB.Stem)
                {
                  decDistance += this.options.WeightNoteStem;
                }
              }
              if (_compareDuration && this.options.WeightNoteBreveduration > 0m)
              {
                decDivisor += this.options.WeightNoteBreveduration;
                if (noteA.BreveDuration != noteB.BreveDuration)
                {
                  decDistance += this.options.WeightNoteBreveduration;
                }
              }
              if (this.options.WeightNotePitchWithAccid > 0m)
              {
                decDivisor += this.options.WeightNotePitchWithAccid;
                if (noteA.PitchWithAccid != noteB.PitchWithAccid)
                {
                  decDistance += this.options.WeightNotePitchWithAccid;
                }
              }

              if (decDivisor > 0m)
              {
                return decDistance / decDivisor;
              }
              else
              {
                // There was no divisor which means all weights must be 0!
                return 0m;
              }
            }
            else
            {
              return 1m;
            }
            #endregion
          }
          else if ((_objectA.Type == ObjectType.Mensur || _objectA.Type == ObjectType.Proportion) && (_objectB.Type == ObjectType.Mensur || _objectB.Type == ObjectType.Proportion))
          {
            #region Proportion/Menus comparison
            // If both objects are Proportion check for this distance
            if (_objectA.Type == ObjectType.Proportion && _objectB.Type == ObjectType.Proportion)
            {
              Proportion propA = (Proportion)_objectA, propB = (Proportion)_objectB;
              decimal decDistance = 0m, decDivisor = 0m;
              if (this.options.WeightProportionAffected > 0m)
              {
                decDivisor += this.options.WeightProportionAffected;
                if (propA.Affected != propB.Affected)
                {
                  decDistance += this.options.WeightProportionAffected;
                }
              }
              if (this.options.WeightProportionRatio > 0m)
              {
                decDivisor += this.options.WeightProportionRatio;
                if (propA.Ratio != propB.Ratio)
                {
                  decDistance += this.options.WeightProportionRatio;
                }
              }
              if (this.options.WeightProportionSign > 0m)
              {
                decDivisor += this.options.WeightProportionSign;
                if (propA.Sign != propB.Sign)
                {
                  decDistance += this.options.WeightProportionSign;
                }
              }

              if (decDivisor > 0m)
              {
                return decDistance / decDivisor;
              }
              else
              {
                // There was no divisor which means all weights must be 0!
                return 0m;
              }
            }
            else if (_objectA.Type == ObjectType.Mensur && _objectB.Type == ObjectType.Mensur)
            {
              Mensur menA = (Mensur)_objectA, menB = (Mensur)_objectB;
              decimal decDistance = 0m, decDivisor = 0m;
              if (this.options.WeightMensurRatio > 0m)
              {
                decDivisor += this.options.WeightMensurRatio;
                if (menA.Ratio != menB.Ratio)
                {
                  decDistance += this.options.WeightMensurRatio;
                }
              }
              if (this.options.WeightMensurTempus > 0m)
              {
                decDivisor += this.options.WeightMensurTempus;
                if (menA.Tempus != menB.Tempus)
                {
                  decDistance += this.options.WeightMensurTempus;
                }
              }
              if (this.options.WeightMensurProlatio > 0m)
              {
                decDivisor += this.options.WeightMensurProlatio;
                if (menA.Prolatio != menB.Prolatio)
                {
                  decDistance += this.options.WeightMensurProlatio;
                }
              }
              if (this.options.WeightMensurModus > 0m)
              {
                decDivisor += this.options.WeightMensurModus;
                if (menA.Modus != menB.Modus)
                {
                  decDistance += this.options.WeightMensurModus;
                }
              }
              if (this.options.WeightMensurMaximodus > 0m)
              {
                decDivisor += this.options.WeightMensurMaximodus;
                if (menA.Maximodus != menB.Maximodus)
                {
                  decDistance += this.options.WeightMensurMaximodus;
                }
              }
              if (this.options.WeightMensurSign > 0m)
              {
                decDivisor += this.options.WeightMensurSign;
                if (menA.Sign != menB.Sign)
                {
                  decDistance += this.options.WeightMensurSign;
                }
              }

              if (decDivisor > 0m)
              {
                return decDistance / decDivisor;
              }
              else
              {
                // There was no divisor which means all weights must be 0!
                return 0m;
              }
            }
            else
            {
              return 1m;
            }
            #endregion
          }
          // In the end return the defined penalty
          return this.options.ConversionPenalty;
        }
      }
    }

    /// <summary>
    /// This method calculates the Distance of an fragmentation/consolidation between the given object and the given sequence starting from the given index
    /// </summary>
    /// <param name="_object"></param>
    /// <param name="_lst2Check"></param>
    /// <param name="_startingIndex"></param>
    /// <param name="_endIndex">The index where an possible fragmantation/consolidation ends</param>
    /// <returns></returns>
    private decimal CheckFragmentationConsolidation(
      ObjectInSequence _object,
      List<ObjectInSequence> _lst2Check,
      int _startingIndex,
      out int _endIndex)
    {
      // When in the options the BreveDuration of either a note or a rest is zero never do a fragmantation/consolidation!
      // The given object needs to be a note or a rest
      if (this.options.WeightRestBreveDuration > 0m 
        && this.options.WeightNoteBreveduration > 0m 
        && (_object.Type == ObjectType.Note || _object.Type == ObjectType.Rest))
      {
        // Also the object at the starting index needs to be a note or a rest
        if (_lst2Check[_startingIndex].Type == ObjectType.Note || _lst2Check[_startingIndex].Type == ObjectType.Rest)
        {
          // We can start checking - sum up the duration and the distance (multiplied with duration of the note / duration of the _object)
          Fraction durationObject = ((Rest)_object).BreveDuration;
          Fraction duration = new Fraction(0);
          decimal decDistance = 0m;
          int intCurrentIndex = _startingIndex;
          do
          {
            // if the current object is a note or a rest sum the duration and get the difference
            if (_lst2Check[intCurrentIndex].Type == ObjectType.Note || _lst2Check[intCurrentIndex].Type == ObjectType.Rest)
            {
              Fraction currentDuration = ((Rest)_lst2Check[intCurrentIndex]).BreveDuration;
              // Directly build the fraction of the distance over the durations
              decimal decCurrentDistance = CalculateDistance(_object, _lst2Check[intCurrentIndex], _compareDuration: false) * Convert.ToDecimal(currentDuration.ToDouble()) / Convert.ToDecimal(durationObject.ToDouble());
              // Now sum it up
              duration += currentDuration;
              decDistance += decCurrentDistance;
            }
            else if (_lst2Check[intCurrentIndex].Type == ObjectType.Gap)
            {
              // A damage is a damage....since we don't know how long it is add the DamagePenalty
              decDistance += this.options.DamagePenalty;
            }
            else if (_lst2Check[intCurrentIndex].Type == ObjectType.Mensur || _lst2Check[intCurrentIndex].Type == ObjectType.Proportion || _lst2Check[intCurrentIndex].Type == ObjectType.Barline)
            {
              // Reaching one of these breaks every attempt...
              _endIndex = intCurrentIndex;
              return 100m;
            }
            else
            {
              // Here we are at a Clef/KeyAccidental/Accidental/Dot/Custos
              // Jump over it and do nothing
            }
            // In the end increase the current index
            intCurrentIndex++;
          }
          while (duration < durationObject && intCurrentIndex < _lst2Check.Count);

          // After the search check if the Duration matches that of the note
          if (duration == durationObject)
          {
            // if yes return the calculated distance
            _endIndex = intCurrentIndex;
            return decDistance;
          }
        }
      }

      // No return yet - return a very high value so that this is most unlikely
      _endIndex = _startingIndex;
      return 100m;
    }

    /// <summary>
    /// Calculates the minimum value from all given decimals
    /// </summary>
    /// <param name="_values"></param>
    /// <returns></returns>
    private static decimal GetMin(params decimal[] _values)
    {
      return _values.Min();
    }

    /// <summary>
    /// Get's the Alignment needed for calculating
    /// </summary>
    /// <returns></returns>
    private decimal GetAlignment(NeedlemanWunschAlignObject _alignObject)
    {
      // If the object has a value without consolidation/fragmentation and is not the end of one use this value for calculation
      if (_alignObject.AlignmentWithoutConsolidationFragmentation != -1m
        && this.lstConsolidationsFragmentations.Any(lst => lst.IndexOf(_alignObject) == (lst.Count - 1)) == false)
      {
        return _alignObject.AlignmentWithoutConsolidationFragmentation;
      }
      else
      {
        return _alignObject.Alignment;
      }
    }

    /// <summary>
    /// Calculates the changes needed to be made in the given backtrace
    /// </summary>
    /// <param name="_backtrace"></param>
    /// <returns></returns>
    private int GetCountChangesForBacktrace(List<Tuple<ushort, ushort>> _backtrace)
    {
      // Go back the trace and count every Distance-Change
      // We just take the first Trace - there should be no difference
      int intNumberOfChanges = 0;
      decimal decLastDistance = this.arrAlignment[_backtrace[0].Item1, _backtrace[0].Item2].Alignment;

      // Going back
      for (int intIndexTrace = 1; intIndexTrace < _backtrace.Count; intIndexTrace++)
      {
        // Get the current distance
        var traceActuell = _backtrace[intIndexTrace];
        decimal decDistance = this.arrAlignment[traceActuell.Item1, traceActuell.Item2].Alignment;
        // Check for an difference
        if (decDistance != decLastDistance)
        {
          // Increment
          intNumberOfChanges++;
        }

        // Save the last Distance
        decLastDistance = decDistance;
      }

      return intNumberOfChanges;
    }

    #region Consolidations/Fragmentations
    private void BuildConsolidationsFragmentations()
    {
      // Create the array with the same dimensions as the alignment-array
      this.arrConsolidationFragmentation = new List<List<NeedlemanWunschAlignObject>>[this.objectsA.Count + 1, this.objectsB.Count + 1];
      // Create a dictionary to store the data related to the last object
      Dictionary<NeedlemanWunschAlignObject, List<List<NeedlemanWunschAlignObject>>> dicConFrag2EndObject = new Dictionary<NeedlemanWunschAlignObject, List<List<NeedlemanWunschAlignObject>>>();
      // Fill the dictionary
      List<List<NeedlemanWunschAlignObject>> lst2Add;
      foreach (List<NeedlemanWunschAlignObject> lstAktuell in this.lstConsolidationsFragmentations)
      {
        NeedlemanWunschAlignObject objAktuell = lstAktuell.ElementAt(lstAktuell.Count - 1);
        if (dicConFrag2EndObject.TryGetValue(objAktuell, out lst2Add) == false)
        {
          lst2Add = new List<List<NeedlemanWunschAlignObject>>();
          dicConFrag2EndObject.Add(objAktuell, lst2Add);
        }

        lst2Add.Add(lstAktuell);
      }

      // Now we have our dictionary - go over the array and fill when we find something
      for (int intRow = 0; intRow <= this.objectsA.Count; intRow++)
      {
        for (int intCol = 0; intCol <= this.objectsB.Count; intCol++)
        {
          NeedlemanWunschAlignObject objAktuell = this.arrAlignment[intRow, intCol];
          if (objAktuell != null && dicConFrag2EndObject.TryGetValue(objAktuell, out lst2Add))
          {
            this.arrConsolidationFragmentation[intRow, intCol] = lst2Add;
          }
        }
      }
    }
    #endregion

    #region Backtracing
    private void BuildBacktraces()
    {
      // Just a safetycheck
      if (this.arrAlignment != null)
      {
        // Initialize the Member
        this.lstBacktraces = new List<Backtrace>();
        // We'll start at the end an trace backwards and we have at least in backtrace
        Backtrace lstBacktraceAktuell = new Backtrace(this.Distance);
        // this.lstBacktraces.Add(lstBacktraceAktuell);
        FollowTrace(lstBacktraceAktuell, this.arrAlignment.GetLength(0) - 1, this.arrAlignment.GetLength(1) - 1);
        // Cleanup - Only take the Traces with the minimum length
        //int intMinimum = this.lstBacktraces.Min(itemLength => itemLength.Count);
        //this.lstBacktraces = this.lstBacktraces.Where(item => item.Count == intMinimum).ToList();
      }
    }

    private void FollowTrace(Backtrace _traceAktuell, int _row, int _col)
    {
      // First put the given Tupel in the List
      _traceAktuell.AddWaypoint((ushort)_row, (ushort)_col, this.arrAlignment[_row, _col].Alignment);

      // Boil out if we are at the beginning
      if (_row == 0 && _col == 0)
      {
        if (this.lstBacktraces.Count == 0)
        {
          // We are the first one calculated to the end - keep it and write it's Stats in the Optimums
          this.lstBacktraces.Add(_traceAktuell);
          this.CountBacktraces++;
          backtraceOptimums[0, 0] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
        }
        else
        {
          // When we already have at least one backtrace check if the actual backtrace ist longer or shorter and if the made changes differ
          if (_traceAktuell.WayBack.Count == backtraceOptimums[0,0].Item1 && _traceAktuell.CountChanges == backtraceOptimums[0,0].Item2)
          {
            // equal length and number of changes - add it to the list except we excced the treshold or we only want one
            if (this.lstBacktraces.Count < 100 && this.bolSingleBacktrace == false)
            {
              this.lstBacktraces.Add(_traceAktuell);
            }
            this.CountBacktraces++;
          }
          else if (_traceAktuell.CountChanges < backtraceOptimums[0, 0].Item2)
          {
            // The trace has less changes - no matter the length keep this und remove the rest
            this.lstBacktraces.Clear();
            this.lstBacktraces.Add(_traceAktuell);
            this.CountBacktraces = 1;
            backtraceOptimums[0, 0] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
          }
          else if (_traceAktuell.CountChanges < this.lstBacktraces[0].CountChanges && _traceAktuell.WayBack.Count == this.lstBacktraces[0].WayBack.Count)
          {
            // this trace is shorter and has the same number of changes - clear the list and add it
            this.lstBacktraces.Clear();
            this.lstBacktraces.Add(_traceAktuell);
            this.CountBacktraces = 1;
            backtraceOptimums[0, 0] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
          }
          else
          {
            // Trace is longer - nothing to do
          }
        }
        return;
      }
      else
      {
        // Check if there's an entry in the optimal traces for this field
        Tuple<int, int> optimum = backtraceOptimums[_row, _col];
        if (optimum == null)
        {
          // We are the first one - add the data
          backtraceOptimums[_row, _col] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
        }
        else
        {
          // We are not the first - check if one was better at that point
          if (_traceAktuell.CountChanges < optimum.Item2)
          {
            // Oh yes we are - write the new Values in optimum and carry on
            backtraceOptimums[_row, _col] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
          }
          else if (optimum.Item2 == _traceAktuell.CountChanges && optimum.Item1 < _traceAktuell.WayBack.Count)
          {
            // We have the same number of changes but a shorter Way back - keep this one
            backtraceOptimums[_row, _col] = Tuple.Create(_traceAktuell.WayBack.Count, _traceAktuell.CountChanges);
          }
          else if (this.bolSingleBacktrace == false && optimum.Item2 == _traceAktuell.CountChanges && optimum.Item1 == _traceAktuell.WayBack.Count)
          {
            // This one is euqally good AND we don't just want one single best backtrace - just carry on
          }
          else
          {
            // We are not better - give up
            return;
          }
        }
      }

      // Check if we are at the end of a consolidation/fragmentation
      var lstCF = this.arrConsolidationFragmentation[_row, _col];
      if (lstCF != null)
      {
        // It could happen that we get more then one con/frag ending in this point so copy the traceback
        Backtrace traceCopy = _traceAktuell.Copy();
        // Flag if the original trace has continued
        bool bolOriginalTraceUsed = false;
        // Now add the route for the con/frag
        foreach (List<NeedlemanWunschAlignObject> lstAktuell in lstCF)
        {
          Backtrace trace2Use = bolOriginalTraceUsed ? traceCopy.Copy() : _traceAktuell;
          int intRow = _row, intCol = _col;
          // Backwards the the con/frag, leaving the last (actual object) out
          for (int intIndex = lstAktuell.Count - 2; intIndex >= 0; intIndex--)
          {
            NeedlemanWunschAlignObject objAktuel = lstAktuell[intIndex];

            if (intRow > 0 && this.arrAlignment[intRow - 1, intCol] == objAktuel)
            {
              intRow--;
            }
            else
            {
              intCol--;
            }
            trace2Use.AddWaypoint((ushort)intRow, (ushort)intCol, objAktuel.Alignment);
          }

          FollowTrace(trace2Use, intRow, intCol);
        }
      }
      // Now check if we need to split
      else if (Enum.IsDefined(typeof(NeedlemanWunschAlignDirection), this.arrAlignment[_row, _col].AlignDirection) == false)
      {
        
        // Flag if the original trace has continued
        bool bolOriginalTraceUsed = false;
        // Make a copy of the original track
        Backtrace traceCopy = _traceAktuell.Copy();

        if (this.arrAlignment[_row, _col].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Diagonal))
        {
          // And follow the trace - at this point the original trace can be used
          FollowTrace(_traceAktuell, _row - 1, _col - 1);
          bolOriginalTraceUsed = true;
        }
        if (this.arrAlignment[_row, _col].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Above))
        {
          if (bolOriginalTraceUsed)
          {
            // Split up!
            // Copy the actual Traceback if we also have an alignment from the left, otherwise just use the already copied Traceback
            Backtrace traceNew = this.arrAlignment[_row, _col].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Left) ? traceCopy.Copy() : traceCopy;
            FollowTrace(traceNew, _row - 1, _col);
          }
          else
          {
            FollowTrace(_traceAktuell, _row - 1, _col);
            bolOriginalTraceUsed = true;
          }
        }
        if (this.arrAlignment[_row, _col].AlignDirection.HasFlag(NeedlemanWunschAlignDirection.Left))
        {
          if (bolOriginalTraceUsed)
          {
            // Split up! Here we can directly use the already copied Traceback
            FollowTrace(traceCopy, _row, _col - 1);
          }
          else
          {
            FollowTrace(_traceAktuell, _row, _col - 1);
            // No need to set the variable
          }
        }
      }
      else
      {
        // No splitting - follow the Line
        int intNextRow = _row - (this.arrAlignment[_row, _col].AlignDirection == NeedlemanWunschAlignDirection.Left ? 0 : 1);
        int intNextCol = _col - (this.arrAlignment[_row, _col].AlignDirection == NeedlemanWunschAlignDirection.Above ? 0 : 1);
        FollowTrace(_traceAktuell, intNextRow, intNextCol);
      }
    }
    #endregion
    #endregion
  }
}
