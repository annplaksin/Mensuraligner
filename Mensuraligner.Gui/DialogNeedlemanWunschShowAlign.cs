using mei2Sequence.Model;
using Mensuraligner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensuraligner.Gui
{
  /// <summary>
  /// A Dialog to show the result of an Needleman-Wunsch Alignment
  /// Icon taken from http://www.iconninja.com/oct-icon-sets-762
  /// </summary>
  public partial class DialogNeedlemanWunschShowAlign : Form
  {
    #region Constants
    private const string COL_POSITION = "COL_POSITION";
    private const string COL_OBJECT_TYPE_A = "COL_OBJECT_TYPE_A";
    private const string COL_CLASSIFICATION_A = "COL_CLASSIFICATION_A";
    private const string COL_PITCHPOSITION_A = "COL_PITCHPOSITION_A";
    private const string COL_OBJECT_TYPE_B = "COL_OBJECT_TYPE_B";
    private const string COL_CLASSIFICATION_B = "COL_CLASSIFICATION_B";
    private const string COL_PITCHPOSITION_B = "COL_PITCHPOSITION_B";
    private const string COL_DIFFERENCE = "COL_DIFFERENCE";
    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    public DialogNeedlemanWunschShowAlign()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Setting the data to display
    /// </summary>
    /// <param name="_alignment"></param>
    public void SetData(NeedlemanWunsch _alignment)
    {
      // For every possible Traceback a new TabPage
      int intCountBacktrace = 1;
      foreach (Backtrace btAktuell in _alignment.Backtraces)
      {
        if (intCountBacktrace > 10)
        {
          MessageBox.Show($"There are {_alignment.CountBacktraces} possible alignments. Because of performance and memory issues the first 10 will be displayed.");
          break;
        }

        TabPage tabPageNew = new TabPage($"Alignment {intCountBacktrace++}");
        // For unknown reasons inserting won't work.....so remove the AlignmentPage, add the new one and readd the alignment page
        this.tabControl.TabPages.Remove(this.tabPageMatrix);
        this.tabControl.TabPages.Add(tabPageNew);
        this.tabControl.TabPages.Add(this.tabPageMatrix);

        DataGridView dataGrid = new DataGridView();
        dataGrid.AllowUserToAddRows = false;
        dataGrid.AllowUserToDeleteRows = false;
        dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGrid.ColumnHeadersVisible = true;
        dataGrid.Location = new System.Drawing.Point(3, 3);
        dataGrid.RowHeadersVisible = false;
        dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dataGrid.ShowEditingIcon = false;
        dataGrid.TabIndex = 0;
        dataGrid.Dock = DockStyle.Fill;

        dataGrid.Columns.Add(COL_POSITION, "Position");
        dataGrid.Columns.Add(COL_OBJECT_TYPE_A, "A - Object Type");
        dataGrid.Columns.Add(COL_CLASSIFICATION_A, "A - Classification");
        dataGrid.Columns.Add(COL_PITCHPOSITION_A, "A - Pitch Position");
        dataGrid.Columns.Add(COL_OBJECT_TYPE_B, "B - Object Type");
        dataGrid.Columns.Add(COL_CLASSIFICATION_B, "B - Classification");
        dataGrid.Columns.Add(COL_PITCHPOSITION_B, "B - Pitch Position");
        dataGrid.Columns.Add(COL_DIFFERENCE, "Current Difference");

        tabPageNew.Controls.Add(dataGrid);

        // Indexes that have been written so far - 1-based!
        int intIndexA = 0, intIndexB = 0;
        // Loop over the tuples leaving out the first one (that's always 0,0)
        for (int intIndexTuple = btAktuell.WayBack.Count - 2; intIndexTuple >= 0; intIndexTuple--)
        {
          int intIndexRow = dataGrid.Rows.Add();
          dataGrid[COL_POSITION, intIndexRow].Value = intIndexRow;

          // Remember objects for comparison
          ObjectType objTypeA = ObjectType.Invalid, objTypeB = ObjectType.Invalid;
          string classificationA = string.Empty, classificationB = string.Empty;
          int? pitchPosA = null, pitchPosB = null;

          if (btAktuell.WayBack[intIndexTuple].Item1 > intIndexA)
          {
            // Since the index used is 1-based first use it and then increment it
            dataGrid[COL_OBJECT_TYPE_A, intIndexRow].Value = _alignment.SequenceA[intIndexA].Type;
            objTypeA = _alignment.SequenceA[intIndexA].Type;
            dataGrid[COL_CLASSIFICATION_A, intIndexRow].Value = ObjectWriter.GetClassification(_alignment.SequenceA[intIndexA]);
            classificationA = ObjectWriter.GetClassification(_alignment.SequenceA[intIndexA]);
            dataGrid[COL_PITCHPOSITION_A, intIndexRow].Value = ObjectWriter.GetPitchPosition(_alignment.SequenceA[intIndexA]);
            pitchPosA = ObjectWriter.GetPitchPosition(_alignment.SequenceA[intIndexA]);

            intIndexA++;
          }
          else
          {
            dataGrid[COL_OBJECT_TYPE_A, intIndexRow].Value = "---";
            dataGrid[COL_CLASSIFICATION_A, intIndexRow].Value = "---";
            dataGrid[COL_PITCHPOSITION_A, intIndexRow].Value = "---";
            dataGrid.Rows[intIndexRow].DefaultCellStyle.BackColor = Color.Thistle;
          }

          if (btAktuell.WayBack[intIndexTuple].Item2 > intIndexB)
          {
            // Since the index used is 1-based first use it and then increment it
            dataGrid[COL_OBJECT_TYPE_B, intIndexRow].Value = _alignment.SequenceB[intIndexB].Type;
            objTypeB = _alignment.SequenceB[intIndexB].Type;
            dataGrid[COL_CLASSIFICATION_B, intIndexRow].Value = ObjectWriter.GetClassification(_alignment.SequenceB[intIndexB]);
            classificationB = ObjectWriter.GetClassification(_alignment.SequenceB[intIndexB]);
            dataGrid[COL_PITCHPOSITION_B, intIndexRow].Value = ObjectWriter.GetPitchPosition(_alignment.SequenceB[intIndexB]);
            pitchPosB = ObjectWriter.GetPitchPosition(_alignment.SequenceB[intIndexB]);

            intIndexB++;
          }
          else
          {
            dataGrid[COL_OBJECT_TYPE_B, intIndexRow].Value = "---";
            dataGrid[COL_CLASSIFICATION_B, intIndexRow].Value = "---";
            dataGrid[COL_PITCHPOSITION_B, intIndexRow].Value = "---";
            dataGrid.Rows[intIndexRow].DefaultCellStyle.BackColor = Color.Thistle;
          }

          // Fill current difference into column
          dataGrid[COL_DIFFERENCE, intIndexRow].Value = Math.Round(_alignment.Alignments[intIndexA, intIndexB].Alignment, 3);

          // Change background color for differing cells
          if (objTypeA != ObjectType.Invalid && objTypeB != ObjectType.Invalid && objTypeA != objTypeB)
          {
            dataGrid[COL_OBJECT_TYPE_A, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid[COL_OBJECT_TYPE_B, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid.Rows[intIndexRow].DefaultCellStyle.BackColor = Color.Thistle;
          }
          if (classificationA != classificationB && classificationA != string.Empty && classificationB != string.Empty)
          {
            dataGrid[COL_CLASSIFICATION_A, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid[COL_CLASSIFICATION_B, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid.Rows[intIndexRow].DefaultCellStyle.BackColor = Color.Thistle;
          }
          if (pitchPosA != pitchPosB && pitchPosA != null && pitchPosB != null)
          {
            dataGrid[COL_PITCHPOSITION_A, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid[COL_PITCHPOSITION_B, intIndexRow].Style.BackColor = Color.Gold;
            dataGrid.Rows[intIndexRow].DefaultCellStyle.BackColor = Color.Thistle;
          }
        }
      }

      #region Show Alignment
      // Clear the Grid
      this.dataGridViewAlignment.Columns.Clear();
      this.dataGridViewAlignment.Rows.Clear();

      // Now initialize Rows and Columns
      for (int intIndexColumn = 0; intIndexColumn < _alignment.Alignments.GetLength(1); intIndexColumn++)
      {
        this.dataGridViewAlignment.Columns.Add("Column_" + intIndexColumn.ToString("0000"), "");
        // The DataGridView has a FillWeight-Default of 100 and allows a maximum FillWeight-Sum of 65500....we cannot set it to 0 so we take a veeeery small number ;-)
        this.dataGridViewAlignment.Columns["Column_" + intIndexColumn.ToString("0000")].FillWeight = 0.0000000001f;
      }
      for (int intIndexRow = 0; intIndexRow < _alignment.Alignments.GetLength(0); intIndexRow++)
      {
        this.dataGridViewAlignment.Rows.Add();
        // And directly fill the row with Data
        for (int intIndexColumn = 0; intIndexColumn < _alignment.Alignments.GetLength(1); intIndexColumn++)
        {
          // Round the decimals to 3
          this.dataGridViewAlignment[intIndexColumn, intIndexRow].Value = Math.Round(_alignment.Alignments[intIndexRow, intIndexColumn].Alignment, 3);
          this.dataGridViewAlignment[intIndexColumn, intIndexRow].ToolTipText = _alignment.Alignments[intIndexRow, intIndexColumn].AlignDirection.ToString();
        }
      }

      // Now color the traces
      foreach (Backtrace btAktuell in _alignment.Backtraces)
      {
        foreach (Tuple<ushort, ushort> tupAktuell in btAktuell.WayBack)
        {
          this.dataGridViewAlignment[tupAktuell.Item2, tupAktuell.Item1].Style.BackColor = Color.Green;
        }
      }
      #endregion
    }

    /// <summary>
    /// Overriden OnFormClosing
    /// </summary>
    /// <param name="e"></param>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      this.Dispose();
    }

    /// <summary>
    /// Creates an Dialog for the given Alignment und shows it
    /// </summary>
    /// <param name="_alignment"></param>
    public static void ShowDialogForAlignment(NeedlemanWunsch _alignment)
    {
      DialogNeedlemanWunschShowAlign dialog = new DialogNeedlemanWunschShowAlign();
      
      dialog.SetData(_alignment);
      dialog.Show();
    }
  }
}
