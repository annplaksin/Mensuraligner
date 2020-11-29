namespace CSVExport
{
  partial class DialogCSVExport
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCSVExport));
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblEncoding = new System.Windows.Forms.Label();
      this.txtDelimiter = new System.Windows.Forms.TextBox();
      this.cbxWriteheaders = new System.Windows.Forms.CheckBox();
      this.cmbEncoding = new System.Windows.Forms.ComboBox();
      this.lblDelimiter = new System.Windows.Forms.Label();
      this.lblSavepath = new System.Windows.Forms.Label();
      this.lblEscape = new System.Windows.Forms.Label();
      this.lblQuote = new System.Windows.Forms.Label();
      this.txtEscape = new System.Windows.Forms.TextBox();
      this.txtQuote = new System.Windows.Forms.TextBox();
      this.txtSavepath = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(349, 119);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.Location = new System.Drawing.Point(268, 119);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 12;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblEncoding
      // 
      this.lblEncoding.AutoSize = true;
      this.lblEncoding.Location = new System.Drawing.Point(12, 15);
      this.lblEncoding.Name = "lblEncoding";
      this.lblEncoding.Size = new System.Drawing.Size(55, 13);
      this.lblEncoding.TabIndex = 0;
      this.lblEncoding.Text = "&Encoding:";
      // 
      // txtDelimiter
      // 
      this.txtDelimiter.Location = new System.Drawing.Point(73, 39);
      this.txtDelimiter.Name = "txtDelimiter";
      this.txtDelimiter.Size = new System.Drawing.Size(150, 20);
      this.txtDelimiter.TabIndex = 3;
      // 
      // cbxWriteheaders
      // 
      this.cbxWriteheaders.AutoSize = true;
      this.cbxWriteheaders.Location = new System.Drawing.Point(73, 65);
      this.cbxWriteheaders.Name = "cbxWriteheaders";
      this.cbxWriteheaders.Size = new System.Drawing.Size(94, 17);
      this.cbxWriteheaders.TabIndex = 8;
      this.cbxWriteheaders.Text = "&Write Headers";
      this.cbxWriteheaders.UseVisualStyleBackColor = true;
      // 
      // cmbEncoding
      // 
      this.cmbEncoding.FormattingEnabled = true;
      this.cmbEncoding.Location = new System.Drawing.Point(73, 12);
      this.cmbEncoding.Name = "cmbEncoding";
      this.cmbEncoding.Size = new System.Drawing.Size(150, 21);
      this.cmbEncoding.TabIndex = 1;
      // 
      // lblDelimiter
      // 
      this.lblDelimiter.AutoSize = true;
      this.lblDelimiter.Location = new System.Drawing.Point(12, 42);
      this.lblDelimiter.Name = "lblDelimiter";
      this.lblDelimiter.Size = new System.Drawing.Size(50, 13);
      this.lblDelimiter.TabIndex = 2;
      this.lblDelimiter.Text = "&Delimiter:";
      // 
      // lblSavepath
      // 
      this.lblSavepath.AutoSize = true;
      this.lblSavepath.Location = new System.Drawing.Point(12, 91);
      this.lblSavepath.Name = "lblSavepath";
      this.lblSavepath.Size = new System.Drawing.Size(56, 13);
      this.lblSavepath.TabIndex = 9;
      this.lblSavepath.Text = "&Savepath:";
      // 
      // lblEscape
      // 
      this.lblEscape.AutoSize = true;
      this.lblEscape.Location = new System.Drawing.Point(229, 42);
      this.lblEscape.Name = "lblEscape";
      this.lblEscape.Size = new System.Drawing.Size(46, 13);
      this.lblEscape.TabIndex = 6;
      this.lblEscape.Text = "Esc&ape:";
      // 
      // lblQuote
      // 
      this.lblQuote.AutoSize = true;
      this.lblQuote.Location = new System.Drawing.Point(229, 15);
      this.lblQuote.Name = "lblQuote";
      this.lblQuote.Size = new System.Drawing.Size(39, 13);
      this.lblQuote.TabIndex = 4;
      this.lblQuote.Text = "&Quote:";
      // 
      // txtEscape
      // 
      this.txtEscape.Location = new System.Drawing.Point(281, 39);
      this.txtEscape.Name = "txtEscape";
      this.txtEscape.Size = new System.Drawing.Size(143, 20);
      this.txtEscape.TabIndex = 7;
      // 
      // txtQuote
      // 
      this.txtQuote.Location = new System.Drawing.Point(281, 12);
      this.txtQuote.Name = "txtQuote";
      this.txtQuote.Size = new System.Drawing.Size(143, 20);
      this.txtQuote.TabIndex = 5;
      // 
      // txtSavepath
      // 
      this.txtSavepath.Location = new System.Drawing.Point(73, 88);
      this.txtSavepath.Name = "txtSavepath";
      this.txtSavepath.Size = new System.Drawing.Size(270, 20);
      this.txtSavepath.TabIndex = 10;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(349, 86);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 11;
      this.btnSearch.Text = "Search...";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "csv";
      this.saveFileDialog.Filter = "CSV-Files|*.csv|All files|*.*";
      // 
      // DialogCSVExport
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(436, 154);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtSavepath);
      this.Controls.Add(this.txtQuote);
      this.Controls.Add(this.txtEscape);
      this.Controls.Add(this.lblQuote);
      this.Controls.Add(this.lblEscape);
      this.Controls.Add(this.lblSavepath);
      this.Controls.Add(this.lblDelimiter);
      this.Controls.Add(this.cmbEncoding);
      this.Controls.Add(this.cbxWriteheaders);
      this.Controls.Add(this.txtDelimiter);
      this.Controls.Add(this.lblEncoding);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnCancel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DialogCSVExport";
      this.ShowInTaskbar = false;
      this.Text = "CSV-Export";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label lblEncoding;
    private System.Windows.Forms.TextBox txtDelimiter;
    private System.Windows.Forms.CheckBox cbxWriteheaders;
    private System.Windows.Forms.ComboBox cmbEncoding;
    private System.Windows.Forms.Label lblDelimiter;
    private System.Windows.Forms.Label lblSavepath;
    private System.Windows.Forms.Label lblEscape;
    private System.Windows.Forms.Label lblQuote;
    private System.Windows.Forms.TextBox txtEscape;
    private System.Windows.Forms.TextBox txtQuote;
    private System.Windows.Forms.TextBox txtSavepath;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
  }
}