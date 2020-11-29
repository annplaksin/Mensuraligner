using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mei2Sequence.Model;
using mei;

namespace mei2Sequence
{
  public static class SequenceHandler
  {
    /// <summary>
    /// Returns a new sequence object
    /// </summary>
    /// <param name="_piece">Name of piece</param>
    /// <param name="_part">Name of musical section, e.g. "Kyrie"</param>
    /// <param name="_voice">Name of voice/part</param>
    /// <param name="_voiceNr">Number of voice</param>
    /// <returns>Sequence with metadata</returns>
    public static Sequence CreateNewSequence(string _piece, string _part, string _page, string _voice, int _voiceNr)
    {
      return new Sequence(_piece, _part, _page, _voice, _voiceNr);
    }

    /// <summary>
    /// Generates a sequence per state from a panel and adds relevant MEI elements
    /// </summary>
    /// <param name="_panel">Panel</param>
    /// <param name="_piece">Name of piece from file</param>
    /// <returns>List of Sequences</returns>
    public static List<Sequence> GetPreConversionSequence(mei.Panel _panel, string _piece)
    {
      List<Sequence> sequencesPerPart = new List<Sequence>();

      GetMetadata(_panel, out string part, out string page, out string voice, out int nr);
      Sequence sequence = CreateNewSequence(_piece, part, page, voice, nr);

      //At this point, the isolation of states has to be done
      foreach(Layer layer in _panel.Descendants<Layer>())
      {
        if (layer.HasChildren<Subst>() || layer.HasChildren<Add>() || layer.HasChildren<Del>())
        {
          //Add state to first sequence
          sequence.State = State.Before;

          //Create second sequence
          Sequence second = CreateNewSequence(_piece, part, page, voice, nr);
          second.State = State.After;
          sequencesPerPart.Add(second);
          // We only 
          break;
        }
      }

      sequencesPerPart.Add(sequence);

      //Get each layer and flatten MEI structure into sequence dictionary
      FlattenMeiToSequence(_panel, sequencesPerPart);

      return sequencesPerPart;
    }

    /// <summary>
    /// Reads metadata for a sequence out of the Mei tree
    /// </summary>
    /// <param name="_panel">Panel</param>
    /// <param name="_part">Name of section/part</param>
    /// <param name="_page">Page token</param>
    /// <param name="_voice">Name of voice</param>
    /// <param name="_nr">Number of voice</param>
    public static void GetMetadata(mei.Panel _panel, out string _part, out string _page,out string _voice, out int _nr)
    {
      try
      {
        _page = _panel.Ancestors<Page>().FirstOrDefault().GetNValue();
      }
      catch
      {
        throw new InvalidOperationException("Page number could not be loaded!");
      }

      if (_panel?.GetTypeValue() == "part")
      {
        _voice = _panel.GetLabelValue() ?? string.Empty;
        if (Int32.TryParse(_panel.GetNValue(), out _nr) == false)
        {
          throw new InvalidOperationException("Voice number is not a number!");
        }

        Mdiv partContainer = _panel.Ancestors<Mdiv>().Where(e => e.GetTypeValue() == "section").FirstOrDefault();

        if (partContainer == null)
        {
          partContainer = _panel.Ancestors<Mdiv>().FirstOrDefault();

          if (partContainer == null)
          {
            throw new InvalidOperationException("File does not contain any mdiv elements!");
          }
        }

        _part = partContainer.GetLabelValue() ?? string.Empty;
      }
      else if (_panel?.GetTypeValue() == "section")
      {
        _part = _panel.GetLabelValue() ?? string.Empty;

        Mdiv voiceContainer = _panel.Ancestors<Mdiv>().Where(e => e.GetTypeValue() == "part").FirstOrDefault();

        if (voiceContainer == null)
        {
          voiceContainer = _panel.Ancestors<Mdiv>().FirstOrDefault();

          if (voiceContainer == null)
          {
            throw new InvalidOperationException("File does not contain any mdiv elements!");
          }
        }

        _voice = voiceContainer.GetLabelValue() ?? string.Empty;
        if (Int32.TryParse(voiceContainer.GetNValue(), out _nr) == false)
        {
          throw new InvalidOperationException("Voice number is not a number!");
        }

      }
      else
      {
        throw new InvalidOperationException("Metadata of sequences could not be loaded!");
      }
    }

    /// <summary>
    /// Takes Mei element that build a sequence and put them into the dictionary
    /// </summary>
    /// <param name="_panel">MEI Panel</param>
    /// <param name="_sequence">Sequence</param>
    public static void FlattenMeiToSequence(mei.Panel _panel, Sequence _sequence)
    {
      foreach (Layer layer in _panel.Descendants<Layer>())
      {
        foreach (MeiElement element in layer.Elements())
        {
          _sequence.AddToMeiObjects(element);
        }
      }
    }

    /// <summary>
    /// Overloaded Flatten method to build sequences
    /// </summary>
    /// <param name="_panel">MEI panel</param>
    /// <param name="_sequenceList">List of Sequences</param>
    public static void FlattenMeiToSequence(mei.Panel _panel, List<Sequence> _sequenceList)
    {
      //if there is only one sequence per part, use the other Flatten method
      if(_sequenceList.Count == 1)
      {
        FlattenMeiToSequence(_panel, _sequenceList[0]);
      }
      //empty sequenceList must be wrong!
      else if (_sequenceList.Count == 0)
      {
        throw new InvalidOperationException("Ops! The creation of sequences of a part didn't work!");
      }
      //hopefully, there are only 2 sequences in the list
      else
      {
        //iterate through list, and elements of panel layers
        foreach (Sequence stateSequence in _sequenceList)
        {
          foreach (Layer layer in _panel.Descendants<Layer>())
          {
            foreach (MeiElement element in layer.Elements())
            {
              if (element is Subst subst)
              {
                if (stateSequence.State == State.Before)
                {
                  //if stateSequence.State == Before, nimm Inhalt von subst/del
                  foreach (MeiElement substDelChild in subst.Element<Del>().Elements())
                  {
                    stateSequence.AddToMeiObjects(substDelChild);
                  }
                }
                else if (stateSequence.State == State.After)
                {
                  //if stateSequene.State == After, nimm Inhalt von subst/add
                  foreach (MeiElement substAddChild in subst.Element<Add>().Elements())
                  {
                    stateSequence.AddToMeiObjects(substAddChild);
                  }
                }
                else
                {
                  throw new InvalidOperationException("Ops! There is more than one sequence for this part and the state of this sequence is Null!");
                }
              }
              else if (element is Add add)
              {
                if (stateSequence.State == State.Before)
                {
                  //if stateSequence.State == Before, ignorieren
                }
                else if (stateSequence.State == State.After)
                {
                  //if stateSequene.State == After, nimm Inhalt von add
                  foreach(MeiElement addChild in add.Elements())
                  {
                    stateSequence.AddToMeiObjects(addChild);
                  }
                }
                else
                {
                  throw new InvalidOperationException("Ops! There is more than one sequence for this part and the state of this sequence is Null!");
                }
              }
              else if (element is Del del)
              {
                if (stateSequence.State == State.Before)
                {
                  foreach(MeiElement delChild in del.Elements())
                  {
                    stateSequence.AddToMeiObjects(delChild);
                  }
                }
                else if (stateSequence.State == State.After)
                {
                  //if stateSequene.State == After, ignorieren
                }
                else
                {
                  throw new InvalidOperationException("Ops! There is more than one sequence for this part and the state of this sequence is Null!");
                }
              }
              else
              {
                stateSequence.AddToMeiObjects(element);
              }
            }
          }
        }
      }
    }
  }
}
