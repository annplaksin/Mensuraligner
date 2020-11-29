using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mei2Sequence.Model
{
  [DataContract()]
  public class Sequence
  {
    /// <summary>
    /// Saves name of piece
    /// </summary>
    [DataMember()]
    public string Piece { get; internal set; }

    /// <summary>
    /// Saves part of piece
    /// </summary>
    [DataMember()]
    public string PartOfPiece { get; internal set; }

    /// <summary>
    /// Page number
    /// </summary>
    [DataMember()]
    public string Page { get; internal set; }

    /// <summary>
    /// Saves name of voice
    /// </summary>
    [DataMember()]
    public string Voice { get; internal set; }

    /// <summary>
    /// Number of voice
    /// </summary>
    [DataMember()]
    public int VoiceNr { get; internal set; }

    /// <summary>
    /// Records depicted state
    /// </summary>
    [DataMember()]
    public State State { get; internal set; }

    /// <summary>
    /// Saved objects in order
    /// Incrementing key is position in sequence
    /// </summary>
    [XmlIgnore]
    public List<ObjectInSequence> ObjectsInSequence { get; private set; }

    /// <summary>
    /// Saves original MEI elements to be transformed
    /// </summary>
    [XmlIgnore]
    public Dictionary<int,mei.MeiElement> MeiObjects { get; internal set; }

    /// <summary>
    /// Parameterless Constructor for Xml-Serialization
    /// </summary>
    private Sequence() { }

    /// <summary>
    /// Creates new sequence with metadata
    /// </summary>
    /// <param name="_piece">Name of piece</param>
    /// <param name="_part">Part of piece</param>
    /// <param name="_voice">Name of voice</param>
    /// <param name="_voiceNr">Number of voice</param>
    public Sequence(string _piece, string _part, string _page, string _voice, int _voiceNr)
    {
      this.Piece = _piece;
      this.PartOfPiece = _part;
      this.Page = _page;
      this.Voice = _voice;
      this.VoiceNr = _voiceNr;
    }

    /// <summary>
    /// Adds Object to sequence dictionary and generates incremental key
    /// </summary>
    /// <param name="_obj">Object to add</param>
    internal void AddToSequence(params ObjectInSequence[] _obj) 
    {
      if (this.ObjectsInSequence == null)
      {
        this.ObjectsInSequence = new List<ObjectInSequence>();
      }

      int intIndex = this.ObjectsInSequence.Count == 0 ? 0 : this.ObjectsInSequence.Max(item => item.Position) + 1;

      foreach (ObjectInSequence objInSequ in _obj)
      {
        //Add position to object and then add object to list
        objInSequ.Position = intIndex;
        this.ObjectsInSequence.Add(objInSequ);
        objInSequ.ParentSequence = this;
      }
    }

    /// <summary>
    /// Builds dictionary of MEI elements to prepare the conversion
    /// </summary>
    /// <param name="_meiObject">MEI element to add</param>
    internal void AddToMeiObjects(mei.MeiElement _meiObject)
    {
      int index;

      if (this.MeiObjects == null)
      {
        this.MeiObjects = new Dictionary<int, mei.MeiElement>();
        index = 0;
      }
      else
      {
        index = this.MeiObjects.Count;
      }

      this.MeiObjects.Add(index, _meiObject);
    }
  }
}
