using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mensuraligner
{
  /// <summary>
  /// A class to hold all possible Options to build the Needleman-Wunsch
  /// </summary>
  public class NeedlemanWunschOptions
  {
    /// <summary>
    /// The usergiven name of this options
    /// </summary>
    public string Name
    {
      get;
      set;
    }

    #region Settings

    /// <summary>
    /// When true everything except notes and rests will be removed before building the alignment
    /// </summary>
    public bool UberLogic
    {
      get;
      set;
    } = false;

    #region Note
    /// <summary>
    /// The weight of the "Duration" attribute from the note
    /// </summary>
    public decimal WeightNoteDuration
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "WrittenPitc" attribute from the note
    /// </summary>
    public decimal WeightNoteWrittenPitch
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Coloration" attribute from the note
    /// </summary>
    public decimal WeightNoteColoration
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Fermate" attribute from the note
    /// </summary>
    public decimal WeightNoteFermata
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "LigaturePosition" attribute from the note
    /// </summary>
    public decimal WeightNoteLigaturePosition
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "LigatureForm" attribute from the note
    /// </summary>
    public decimal WeightNoteLigatureForm
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Stem" attribute from the note
    /// </summary>
    public decimal WeightNoteStem
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "BreveDuration" attribute from the note
    /// </summary>
    public decimal WeightNoteBreveduration
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "PitchWithAccid" attribute from the note
    /// </summary>
    public decimal WeightNotePitchWithAccid
    {
      get;
      set;
    } = 1m;
    #endregion

    #region Rest
    /// <summary>
    /// The weight of the "Duration" attribute from the rest
    /// </summary>
    public decimal WeightRestDuration
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "BreveDuration" attribute from the rest
    /// </summary>
    public decimal WeightRestBreveDuration
    {
      get;
      set;
    } = 1m;
    #endregion

    #region Mensur
    /// <summary>
    /// The weight of the "Ratio" attribute from the mensur
    /// </summary>
    public decimal WeightMensurRatio
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Tempus" attribute from the mensur
    /// </summary>
    public decimal WeightMensurTempus
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Prolatio" attribute from the mensur
    /// </summary>
    public decimal WeightMensurProlatio
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Modus" attribute from the mensur
    /// </summary>
    public decimal WeightMensurModus
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Maximodus" attribute from the mensur
    /// </summary>
    public decimal WeightMensurMaximodus
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Sign" attribute from the mensur
    /// </summary>
    public decimal WeightMensurSign
    {
      get;
      set;
    } = 1m;
    #endregion

    #region Proportion
    /// <summary>
    /// The weight of the "Sign" attribute from the proportion
    /// </summary>
    public decimal WeightProportionSign
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Ratio" attribute from the proportion
    /// </summary>
    public decimal WeightProportionRatio
    {
      get;
      set;
    } = 1m;

    /// <summary>
    /// The weight of the "Affected" attribute from the proportion
    /// </summary>
    public decimal WeightProportionAffected
    {
      get;
      set;
    } = 1m;
    #endregion
    
    #endregion

    #region Penalties
    /// <summary>
    /// The penalty of a gap
    /// </summary>
    public decimal GapPenalty
    {
      get;
      set;
    } = 2m;

    /// <summary>
    /// The penalty of a damage
    /// </summary>
    public decimal DamagePenalty
    {
      get;
      set;
    } = 1.5m;

    /// <summary>
    /// The penalty for a "conversion" - means a compare between two non-comparable objects
    /// </summary>
    public decimal ConversionPenalty
    {
      get;
      set;
    } = 100m;
    #endregion

    #region Affine Gaps/Damages
    /// <summary>
    /// Should the affine gap penalty be used?
    /// </summary>
    public bool UseAffineGaps
    {
      get;
      set;
    } = false;

    /// <summary>
    /// The penalty for extending a gap
    /// </summary>
    public decimal GapExtensionPenalty
    {
      get;
      set;
    } = 1.8m;

    /// <summary>
    /// Should the affine damage-penalty be used?
    /// </summary>
    public bool UseAffineDamages
    {
      get;
      set;
    } = false;

    /// <summary>
    /// The penalty for extending a damage
    /// </summary>
    public decimal DamageExtensionPenalty
    {
      get;
      set;
    } = 1.3m;
    #endregion

    #region Static Methods
    private const string SAVEFOLDERSETTINGSNAME = "Mensuraligner";
    private static readonly string SaveFolderSettings = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SAVEFOLDERSETTINGSNAME);
    private static string SavePathSettings;

    private static List<NeedlemanWunschOptions> lstOptions = null;

    /// <summary>
    /// Loads the Options from the Settings folder and returns them
    /// </summary>
    /// <returns></returns>
    public static List<NeedlemanWunschOptions> LoadOptions()
    {
      if (lstOptions == null)
      {
        // Initialize the SavePath for the settingsfile
        SavePathSettings = Path.Combine(SaveFolderSettings, "Settings.xml");

        // Check if the user has saved Settings
        if (File.Exists(SavePathSettings))
        {
          XmlSerializer serializer = new XmlSerializer(typeof(List<NeedlemanWunschOptions>));
          using (FileStream fs = new FileStream(SavePathSettings, FileMode.Open))
          {
            lstOptions = (List<NeedlemanWunschOptions>)serializer.Deserialize(fs);
            fs.Close();
          }
        }
        else
        {
          lstOptions = new List<NeedlemanWunschOptions>();
        }
      }

      return lstOptions;
    }

    /// <summary>
    /// Saves all options to the Settings folder
    /// </summary>
    public static void SaveOptions()
    {
      if (lstOptions != null)
      {
        // Check if the AppData-Folder exists - if not create it
        if (Directory.Exists(SaveFolderSettings) == false)
        {
          Directory.CreateDirectory(SaveFolderSettings);
        }

        // Save the settings
        XmlSerializer serializer = new XmlSerializer(typeof(List<NeedlemanWunschOptions>));
        using (TextWriter writer = new StreamWriter(SavePathSettings))
        {
          serializer.Serialize(writer, lstOptions);
          writer.Close();
        }
      }
    }
    #endregion
  }
}
