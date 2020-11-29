using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;
using Mehroz;

namespace mei2Sequence
{
  public static class SequenceConversion
  {
    //Store mensur related int conversion in dictionary, Minima is always 1.
    private static Dictionary<Model.Duration,Fraction> MetricTable { get; set; }

    //Store inter note ratio as dictionary
    private static Dictionary<Model.Duration,int> InterNoteQuotient { get; set; }

    /// <summary>
    /// Initializes metric system according to mensur
    /// </summary>
    /// <param name="_mensur">Mensur Object</param>
    private static void InitMetricTable(Model.Mensur _mensur)
    {
      if (MetricTable == null)
      {
        MetricTable = new Dictionary<Duration, Fraction>
        {
          { Duration.Longa, 1*_mensur.Modus },
          { Duration.Brevis, 1 },
          { Duration.Semibrevis, new Fraction(1, _mensur.Tempus) },
        };

        //Add Maximodus and Prolatio
        MetricTable.Add(Duration.Minima, MetricTable[Duration.Semibrevis] / _mensur.Prolatio);
        MetricTable.Add(Duration.Maxima, MetricTable[Duration.Longa] * _mensur.Maximodus);

        //Add small values always as binary
        MetricTable.Add(Duration.Semiminima, MetricTable[Duration.Minima] / 2);
        MetricTable.Add(Duration.Fusa, MetricTable[Duration.Semiminima] / 2);
        MetricTable.Add(Duration.Semifusa, MetricTable[Duration.Fusa] / 2);
      }
      //For changes of mensuration, rewrite dictionary.
      else
      {
        //Change modus and tempus
        MetricTable[Duration.Longa] = 1 * _mensur.Modus;
        MetricTable[Duration.Semibrevis] = new Fraction(1, _mensur.Tempus);

        //Change Maximodus and Prolatio
        MetricTable[Duration.Maxima] = MetricTable[Duration.Longa] * _mensur.Maximodus;
        MetricTable[Duration.Minima] = MetricTable[Duration.Semibrevis] / _mensur.Prolatio;

        //Reset small values to binary
        MetricTable[Duration.Semiminima] = MetricTable[Duration.Minima] / 2;
        MetricTable[Duration.Fusa] = MetricTable[Duration.Semiminima] / 2;
        MetricTable[Duration.Semifusa] = MetricTable[Duration.Fusa] / 2;
      }

      if (InterNoteQuotient == null)
      {
        InterNoteQuotient = new Dictionary<Duration, int>
        {
          { Duration.Maxima, 1 },
          { Duration.Longa, _mensur.Maximodus },
          { Duration.Brevis, _mensur.Modus },
          { Duration.Semibrevis, _mensur.Tempus },
          { Duration.Minima, _mensur.Prolatio },
          { Duration.Semiminima, 2 },
          { Duration.Fusa, 2 },
          { Duration.Semifusa, 2 }
        };
      }
      //For changes of mensuration, rewrite also this.
      else
      {
        InterNoteQuotient[Duration.Longa] = _mensur.Maximodus;
        InterNoteQuotient[Duration.Brevis] = _mensur.Modus;
        InterNoteQuotient[Duration.Semibrevis] = _mensur.Tempus;
        InterNoteQuotient[Duration.Minima] = _mensur.Prolatio;
        InterNoteQuotient[Duration.Semiminima] = 2;
        InterNoteQuotient[Duration.Fusa] = 2;
        InterNoteQuotient[Duration.Semifusa] = 2;
      }
    }

    /// <summary>
    /// Changes metric system according to proportion
    /// </summary>
    /// <param name="_prop">Proportion object</param>
    private static void SetProportion(Model.Proportion _prop)
    {
      if (MetricTable == null)
      {
        throw new Exception("Proportion without preceding mensur!");
      }
      else
      {
        //Get index value of duration enum
        int affectedInt = (int)_prop.Affected;

        //Affected duration needs to be a valid duration, so the index of the affected duration needs to be at least the value of Maxima
        if ((int)_prop.Affected >= (int)Duration.Maxima)
        {
          for (int i = (int)Duration.Maxima; i <= (int)Duration.Semifusa; i++)
          {
            //Gets index of the next greater note value, if there is no greater value (in case of Maxima), set the actual note value
            int nextGreater = MetricTable.ContainsKey((Duration)i - 1) ? i - 1 : i;

            //Calculate relative duration of actual note value based on the next greater
            MetricTable[(Duration)i] = (MetricTable[(Duration)nextGreater] / InterNoteQuotient[(Duration)i]);

            //If proportion affects the actual note value, modify the relative duration by the proportion ratio.
            if (i == affectedInt)
            {
              MetricTable[(Duration)i] = MetricTable[(Duration)i] * _prop.Ratio;
            }
            //By calculating a duration relative to the duration of the next greater note value, proportion changes are passed to smaller note values.
          }
        }
        else if (_prop.Affected == Duration.Null)
        {
          //if Affected is empty, apply proportion to every value of metric table
          foreach (KeyValuePair<Duration,Fraction> metricPair in MetricTable)
          {
            MetricTable[metricPair.Key] = metricPair.Value * _prop.Ratio;
          }
        }
        else
        {
          throw new Exception("Proportion cannot be applied!");
        }
      }
    }

    /// <summary>
    /// Interates through sequence and adds BrevePosition of a Note or Rest according to the Mensur.
    /// Counter starts at 0 with every Mensur, Proportion, and Barline.
    /// </summary>
    /// <param name="_sequence">Sequence to convert</param>
    public static void ConvertBrevePosition(Sequence _sequence)
    {
      //Initialize position counter
      Fraction brevePos = new Fraction(0);

      //Save last brevePos nulling object.
      ObjectType brevePosNuller = ObjectType.Invalid;

      //Save directly preceeding object for chord handling
      Model.Rest preceedingRest = new Model.Rest();
      //Set Position of Dummy-Rest to -1
      preceedingRest.Position = -1;
      //Save preceeding convertedDur
      Fraction preceedingConvertedDur = -1;

      //Iterate through sequence
      foreach (ObjectInSequence obj in _sequence.ObjectsInSequence)
      {
        if (obj is Model.Mensur mensur)
        {
          InitMetricTable(mensur);
          brevePos = 0;
          brevePosNuller = mensur.Type;
        }
        else if (obj is Model.Proportion prop)
        {
          brevePos = 0;
          brevePosNuller = prop.Type;

          //Set metrical change
          SetProportion(prop);
        }
        else if (obj is Model.Barline)
        {
          brevePos = 0;
          brevePosNuller = obj.Type;
        }
        else if (obj is Model.Gap)
        {
          brevePos = 0;
          brevePosNuller = obj.Type;
        }
        else if (obj is Model.Rest rest)
        {
          //add modify duration with num/numbase
          Fraction convertedDur = MetricTable[rest.Duration] * rest.Ratio;
          brevePos = brevePos + convertedDur;

          rest.BreveDuration = convertedDur;

          //only apply BrevePosition or AfterGapPosition once per Object.Position
          if (obj.Position != preceedingRest.Position)
          {
            //check if last nulling object was a gap or not
            if (brevePosNuller == ObjectType.Gap)
            {
              rest.AfterGapPosition = brevePos;
            }
            else
            {
              rest.BrevePosition = brevePos;
            }
          }
          else
          {
            //check for equality of convertedDur for current and preceeding object with same position
            if (preceedingConvertedDur != convertedDur)
            {
              throw new InvalidOperationException("Severe error in chord! Child elements don't have same duration.");
            }
          }

          preceedingRest = rest;
          preceedingConvertedDur = convertedDur;
        }
      }

      //Reset MetricTable and InterNoteQuotient after conversion is done
      MetricTable = null;
      InterNoteQuotient = null;

      //Reset BrevePos and BrevePosNuller
      brevePos = 0;
      brevePosNuller = ObjectType.Invalid;
    }

    /// <summary>
    /// Calculates AbsolutePitch with WrittenPitch, KeyAccids and directely preceeding accidentals.
    /// </summary>
    /// <param name="_sequence">Sequence object</param>
    public static void ConvertAbsolutePitch(Sequence _sequence)
    {
      Dictionary<int, Model.AccidType> keyAccids = new Dictionary<int, AccidType>();

      Accidental lastAccid = null;

      foreach (ObjectInSequence obj in _sequence.ObjectsInSequence)
      {
        //if Accidental or KeyAccidental has AccidentalType.Null, ignore it
        if (obj is KeyAccidental testaccid)
        {
          if (testaccid.AccidentalType == AccidType.Null)
          {
            continue;
          }
        }

        if (obj.Type == ObjectType.KeyAccidental)
        {
          KeyAccidental keyAcc = (KeyAccidental)obj;

          if (keyAccids.ContainsKey(keyAcc.PitchLocation) == true)
          {
            keyAccids[keyAcc.PitchLocation] = keyAcc.AccidentalType;
          }
          else
          {
            keyAccids.Add(keyAcc.PitchLocation, keyAcc.AccidentalType);
          }
        }
        else if (obj is Model.Custos)
        {
          //reset key accidentals
          keyAccids.Clear();
        }
        else if (obj.Type == ObjectType.Accidental)
        {
          lastAccid = (Accidental)obj;
        }
        else if (obj is Model.Note note)
        {
          int absPitch = note.WrittenPitch;
          
          if (keyAccids.ContainsKey(absPitch))
          {
            absPitch += (int)keyAccids[absPitch];
          }
          
          //only try to change WrittenPitch if lastAccid is not null
          if (lastAccid != null)
          {
            if (lastAccid.PitchLocation == note.WrittenPitch)
            {
              absPitch += (int)lastAccid.AccidentalType;
            }

            //check for bdurum to cancel bmolle signature
            //it would be possible to check only for b/h by if (WrittenPitch % 40 == 36), but to rigid treatment would be not suitable
            if (lastAccid.AccidentalType == AccidType.Neutral && keyAccids.ContainsKey(note.WrittenPitch))
            {
              if (keyAccids[note.WrittenPitch] == AccidType.Flat)
              {
                //apply like a sharp to cancel flat
                absPitch += 1;
              }
            }

            //resets last accidental directly after the first following note
            lastAccid = null;
          }

          //handle @accid.ges
          if (note.AccidGes != AccidType.Null)
          {
            absPitch += (int)note.AccidGes;
          }

          note.PitchWithAccid = absPitch;
        }
        else
        {
          continue;
        }
      }
    }
  }
}
