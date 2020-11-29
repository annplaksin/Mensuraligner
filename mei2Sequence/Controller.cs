using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei;
using mei2Sequence.Model;

namespace mei2Sequence
{
  public static class Controller
  {
    

    /// <summary>
    /// Adds for each event in a layer within a panel, an object to the sequence
    /// </summary>
    /// <param name="_sequence">Empty sequence</param>
    /// <param name="_panel">Mei-Panel to read</param>
    public static void BuildSequence(Sequence _sequence)
    {
      foreach (MeiElement layerElement in _sequence.MeiObjects.Values)
      {
        InvokeSequenceObject(_sequence, layerElement);
      }
    }

    /// <summary>
    /// Invokes a Sequence object for the given MEI element
    /// </summary>
    /// <param name="_sequence">Sequence</param>
    /// <param name="layerElement">MEI Element to process</param>
    internal static ObjectInSequence InvokeSequenceObject(Sequence _sequence, MeiElement layerElement, Evidence evidence = Evidence.Clear, int ligaturePos = 0, string ligForm = null)
    {
      ObjectInSequence obj = null;

      if (layerElement is mei.Note note)
      {
        obj = new Model.Note();
        NoteConverter.ConvertNote((Model.Note)obj, note);

        //check for @lig attribute
        if (note.HasLig())
        {
          ligForm = note.GetLigValue();
        }

        TinyConverters.LigatureHandler((Model.Note)obj, ligaturePos, ligForm);
      }
      // Ligatures needs to be be handled recursively to get their elements and store related data
      else if (layerElement is mei.Ligature ligature)
      {
        foreach (MeiElement ligaturChild in ligature.Elements())
        {
          ligaturePos++;
          InvokeSequenceObject(_sequence, ligaturChild, evidence, ligaturePos, ligature.GetFormValue());
        }
        ligaturePos = 0;
      }
      else if (layerElement is mei.Rest)
      {
        obj = new Model.Rest();
        RestConverter.ConvertRest((Model.Rest)obj, (mei.Rest)layerElement);
      }
      else if (layerElement is Chord)
      {
        // We need a List of all objects in the Chord to add them to the sequence at the same position
        List<ObjectInSequence> lstChordEvents = new List<ObjectInSequence>();
        foreach (MeiElement noteRest in layerElement.Descendants())
        {
          ObjectInSequence objNoteRest = InvokeSequenceObject(null, noteRest);
          if (objNoteRest != null)
          {
            lstChordEvents.Add(objNoteRest);
          }
        }

        _sequence?.AddToSequence(lstChordEvents.ToArray());
      }
      else if (layerElement is mei.KeySig)
      {
        // We need a List of all KeyAccids in the KeySig to add them to the sequence at the same position
        List<ObjectInSequence> lstAcids = new List<ObjectInSequence>();
        foreach (KeyAccid keyAccid in layerElement.Elements())
        {
          lstAcids.Add(InvokeSequenceObject(null, keyAccid));
        }
        
        _sequence?.AddToSequence(lstAcids.ToArray());
      }
      else if (layerElement is KeyAccid)
      {
        obj = new Model.KeyAccidental();
        AccidentalConverter.ConvertKeyAccidental((Model.KeyAccidental)obj, (mei.KeyAccid)layerElement);
      }
      else if (layerElement is mei.Accid)
      {
        obj = new Model.Accidental();
        AccidentalConverter.ConvertAccidental((Model.Accidental)obj, (mei.Accid)layerElement);
      }
      else if (layerElement is mei.Mensur)
      {
        obj = new Model.Mensur();
        MensurProportionConverter.ConvertMensur((Model.Mensur)obj, (mei.Mensur)layerElement);
      }
      else if (layerElement is mei.Proport)
      {
        obj = new Model.Proportion();
        MensurProportionConverter.ConvertProportion((Model.Proportion)obj, (mei.Proport)layerElement);
      }
      else if (layerElement is mei.BarLine)
      {
        obj = new Model.Barline();
        TinyConverters.ConvertBarline((Model.Barline)obj, (mei.BarLine)layerElement);
      }
      else if (layerElement is mei.Dot)
      {
        obj = new Model.Dot();
      }
      else if (layerElement is mei.Clef)
      {
        obj = new Model.Clef();
        TinyConverters.ConvertClef((Model.Clef)obj, (mei.Clef)layerElement);
      }
      else if (layerElement is mei.Custos)
      {
        obj = new Model.Custos();
        TinyConverters.ConvertCustos((Model.Custos)obj, (mei.Custos)layerElement);
      }
      else if (layerElement is mei.Unclear || layerElement is mei.Supplied)
      {
        Evidence evd = TinyConverters.GetEvidence(layerElement);
        foreach (MeiElement evdChild in layerElement.Elements())
        {
          InvokeSequenceObject(_sequence, evdChild, evd);
        }
      }
      else if (layerElement is mei.Damage || layerElement is mei.Gap)
      {
        obj = new Model.Gap();
        TinyConverters.ConvertGap((Model.Gap)obj, layerElement);
      }

      if (obj != null)
      {
        //After type definition, add ID of MEI element
        obj.ID = layerElement.GetId();

        //Set Evidence
        obj.Evidence = evidence;

        //Add to sequence if defined
        _sequence?.AddToSequence(obj);
      }

      return obj;
    }

    /// <summary>
    /// Reads Mei-File and generates sequences per panel.
    /// </summary>
    /// <param name="_filedir">Path to Mei file</param>
    /// <returns>List of sequence objects</returns>
    public static List<Sequence> GetSequences (string _filedir)
    {
      MeiDocument doc = MeiImport.ImportDocument(_filedir);
      MeiElement root = doc.Root;

      List<Sequence> sequences = new List<Sequence>();

      string piece;
      //Get name of piece
      try
      {
        piece = root.Element<MeiHead>().Element<FileDesc>().Descendants<Title>().FirstOrDefault().Value;
      }
      catch
      {
        string[] splitUri = doc.BaseUri.Split('/');
        piece = splitUri[splitUri.Length - 1];
      }

      foreach (Panel panel in root.Descendants<Panel>())
      {
        List<Sequence> sequencesPerPart = SequenceHandler.GetPreConversionSequence(panel, piece);

        foreach (Sequence stateSequence in sequencesPerPart)
        {
          sequences.Add(stateSequence);
        }
      }

      return sequences;
    }

    #region Extensions
    /// <summary>
    /// An extension To Display a list of sequences
    /// </summary>
    /// <param name="lstSequence"></param>
    /// <param name="_seperator"></param>
    /// <returns></returns>
    public static string ToString(this List<Sequence> lstSequence, string _seperator)
    {
      StringBuilder strBuilderReturn = new StringBuilder();
      foreach (Sequence seq in lstSequence)
      {
        if (strBuilderReturn.Length > 0)
        {
          strBuilderReturn.Append(_seperator);
        }
        strBuilderReturn.Append(seq.Page);
        strBuilderReturn.Append("-");
        strBuilderReturn.Append(seq.Voice);
        strBuilderReturn.Append("-");
        strBuilderReturn.Append(seq.VoiceNr.ToString());

        // When the State ist not null append it
        if (seq.State != State.Null)
        {
          strBuilderReturn.Append("_");
          strBuilderReturn.Append(seq.State.ToString());
        }
      }
      return strBuilderReturn.ToString();
    }
    #endregion
  }
}
