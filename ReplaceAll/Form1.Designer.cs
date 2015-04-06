namespace ReplaceAll
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.txtSource = new System.Windows.Forms.TextBox();
      this.btnBrowseSource = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMatch = new System.Windows.Forms.TextBox();
      this.txtReplacement = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.chkRetainCase = new System.Windows.Forms.CheckBox();
      this.btnFind = new System.Windows.Forms.Button();
      this.chkReplaceInFiles = new System.Windows.Forms.CheckBox();
      this.btnBrowseTarget = new System.Windows.Forms.Button();
      this.txtTarget = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lstFiles = new System.Windows.Forms.ListBox();
      this.rtbFile = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnReplace = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtExcludeDirectories = new System.Windows.Forms.TextBox();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.pnlOptions = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.pnlOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Root Directory:";
      // 
      // txtSource
      // 
      this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.txtSource.Location = new System.Drawing.Point(6, 23);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(433, 22);
      this.txtSource.TabIndex = 1;
      this.txtSource.Text = "D:\\My Drive\\Code\\Cosmologix\\Objectivizer";
      // 
      // btnBrowseSource
      // 
      this.btnBrowseSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.btnBrowseSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowseSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.btnBrowseSource.Location = new System.Drawing.Point(448, 20);
      this.btnBrowseSource.Name = "btnBrowseSource";
      this.btnBrowseSource.Size = new System.Drawing.Size(39, 24);
      this.btnBrowseSource.TabIndex = 2;
      this.btnBrowseSource.Text = "...";
      this.btnBrowseSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnBrowseSource.UseVisualStyleBackColor = false;
      this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.label2.Location = new System.Drawing.Point(3, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Find:";
      // 
      // txtMatch
      // 
      this.txtMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.txtMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.txtMatch.Location = new System.Drawing.Point(6, 68);
      this.txtMatch.Name = "txtMatch";
      this.txtMatch.Size = new System.Drawing.Size(481, 22);
      this.txtMatch.TabIndex = 4;
      this.txtMatch.Text = "Objectivizer";
      // 
      // txtReplacement
      // 
      this.txtReplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.txtReplacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtReplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.txtReplacement.Location = new System.Drawing.Point(537, 68);
      this.txtReplacement.Name = "txtReplacement";
      this.txtReplacement.Size = new System.Drawing.Size(479, 22);
      this.txtReplacement.TabIndex = 6;
      this.txtReplacement.Text = "Gonami";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.label3.Location = new System.Drawing.Point(534, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Replace With:";
      // 
      // chkRetainCase
      // 
      this.chkRetainCase.AutoSize = true;
      this.chkRetainCase.Checked = true;
      this.chkRetainCase.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkRetainCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkRetainCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.chkRetainCase.Location = new System.Drawing.Point(537, 113);
      this.chkRetainCase.Name = "chkRetainCase";
      this.chkRetainCase.Size = new System.Drawing.Size(174, 21);
      this.chkRetainCase.TabIndex = 7;
      this.chkRetainCase.Text = "Retain the same casing";
      this.chkRetainCase.UseVisualStyleBackColor = true;
      // 
      // btnFind
      // 
      this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFind.ForeColor = System.Drawing.Color.DodgerBlue;
      this.btnFind.Location = new System.Drawing.Point(6, 141);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(104, 24);
      this.btnFind.TabIndex = 8;
      this.btnFind.Text = "Preview";
      this.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnFind.UseVisualStyleBackColor = false;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // chkReplaceInFiles
      // 
      this.chkReplaceInFiles.AutoSize = true;
      this.chkReplaceInFiles.Checked = true;
      this.chkReplaceInFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkReplaceInFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkReplaceInFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.chkReplaceInFiles.Location = new System.Drawing.Point(717, 113);
      this.chkReplaceInFiles.Name = "chkReplaceInFiles";
      this.chkReplaceInFiles.Size = new System.Drawing.Size(178, 21);
      this.chkReplaceInFiles.TabIndex = 9;
      this.chkReplaceInFiles.Text = "Replace inside files also";
      this.chkReplaceInFiles.UseVisualStyleBackColor = true;
      // 
      // btnBrowseTarget
      // 
      this.btnBrowseTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.btnBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowseTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.btnBrowseTarget.Location = new System.Drawing.Point(977, 20);
      this.btnBrowseTarget.Name = "btnBrowseTarget";
      this.btnBrowseTarget.Size = new System.Drawing.Size(39, 24);
      this.btnBrowseTarget.TabIndex = 12;
      this.btnBrowseTarget.Text = "...";
      this.btnBrowseTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnBrowseTarget.UseVisualStyleBackColor = false;
      this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
      // 
      // txtTarget
      // 
      this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.txtTarget.Location = new System.Drawing.Point(537, 23);
      this.txtTarget.Name = "txtTarget";
      this.txtTarget.Size = new System.Drawing.Size(433, 22);
      this.txtTarget.TabIndex = 11;
      this.txtTarget.Text = "c:\\temp";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.label4.Location = new System.Drawing.Point(534, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(120, 17);
      this.label4.TabIndex = 10;
      this.label4.Text = "Results Directory:";
      // 
      // lstFiles
      // 
      this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.lstFiles.Dock = System.Windows.Forms.DockStyle.Left;
      this.lstFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.lstFiles.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.lstFiles.FormattingEnabled = true;
      this.lstFiles.HorizontalScrollbar = true;
      this.lstFiles.ItemHeight = 16;
      this.lstFiles.Location = new System.Drawing.Point(3, 182);
      this.lstFiles.Name = "lstFiles";
      this.lstFiles.Size = new System.Drawing.Size(872, 416);
      this.lstFiles.TabIndex = 13;
      this.lstFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFiles_DrawItem);
      this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
      // 
      // rtbFile
      // 
      this.rtbFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.rtbFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtbFile.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbFile.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.rtbFile.Location = new System.Drawing.Point(1, 1);
      this.rtbFile.Name = "rtbFile";
      this.rtbFile.Size = new System.Drawing.Size(151, 414);
      this.rtbFile.TabIndex = 14;
      this.rtbFile.Text = "";
      this.rtbFile.WordWrap = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.Controls.Add(this.rtbFile);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(880, 182);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(1);
      this.panel1.Size = new System.Drawing.Size(153, 416);
      this.panel1.TabIndex = 15;
      // 
      // btnReplace
      // 
      this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.btnReplace.Enabled = false;
      this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReplace.ForeColor = System.Drawing.Color.OrangeRed;
      this.btnReplace.Location = new System.Drawing.Point(537, 141);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(104, 24);
      this.btnReplace.TabIndex = 16;
      this.btnReplace.Text = "Replace All";
      this.btnReplace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnReplace.UseVisualStyleBackColor = false;
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.label5.Location = new System.Drawing.Point(3, 93);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(287, 17);
      this.label5.TabIndex = 17;
      this.label5.Text = "Exclude Directories (seperate with commas):";
      // 
      // txtExcludeDirectories
      // 
      this.txtExcludeDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.txtExcludeDirectories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtExcludeDirectories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
      this.txtExcludeDirectories.Location = new System.Drawing.Point(6, 113);
      this.txtExcludeDirectories.Name = "txtExcludeDirectories";
      this.txtExcludeDirectories.Size = new System.Drawing.Size(481, 22);
      this.txtExcludeDirectories.TabIndex = 18;
      this.txtExcludeDirectories.Text = "bin,obj,build";
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(875, 182);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(5, 416);
      this.splitter1.TabIndex = 18;
      this.splitter1.TabStop = false;
      // 
      // pnlOptions
      // 
      this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlOptions.Controls.Add(this.label8);
      this.pnlOptions.Controls.Add(this.label7);
      this.pnlOptions.Controls.Add(this.label6);
      this.pnlOptions.Controls.Add(this.label5);
      this.pnlOptions.Controls.Add(this.label1);
      this.pnlOptions.Controls.Add(this.txtExcludeDirectories);
      this.pnlOptions.Controls.Add(this.btnFind);
      this.pnlOptions.Controls.Add(this.chkRetainCase);
      this.pnlOptions.Controls.Add(this.btnReplace);
      this.pnlOptions.Controls.Add(this.chkReplaceInFiles);
      this.pnlOptions.Controls.Add(this.txtSource);
      this.pnlOptions.Controls.Add(this.txtReplacement);
      this.pnlOptions.Controls.Add(this.btnBrowseSource);
      this.pnlOptions.Controls.Add(this.label4);
      this.pnlOptions.Controls.Add(this.label2);
      this.pnlOptions.Controls.Add(this.label3);
      this.pnlOptions.Controls.Add(this.btnBrowseTarget);
      this.pnlOptions.Controls.Add(this.txtTarget);
      this.pnlOptions.Controls.Add(this.txtMatch);
      this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlOptions.Location = new System.Drawing.Point(3, 3);
      this.pnlOptions.Name = "pnlOptions";
      this.pnlOptions.Padding = new System.Windows.Forms.Padding(3);
      this.pnlOptions.Size = new System.Drawing.Size(1030, 179);
      this.pnlOptions.TabIndex = 19;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
      this.label8.Image = global::ReplaceAll.Properties.Resources.square_dodgerblue;
      this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label8.Location = new System.Drawing.Point(390, 141);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(101, 24);
      this.label8.TabIndex = 21;
      this.label8.Text = "File Text";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.LimeGreen;
      this.label7.Image = global::ReplaceAll.Properties.Resources.square_limegreen;
      this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label7.Location = new System.Drawing.Point(275, 141);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(98, 24);
      this.label7.TabIndex = 20;
      this.label7.Text = "File Name";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label6.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Orange;
      this.label6.Image = global::ReplaceAll.Properties.Resources.Orange_Square1;
      this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label6.Location = new System.Drawing.Point(125, 141);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(137, 24);
      this.label6.TabIndex = 19;
      this.label6.Text = "Directory Name";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.ClientSize = new System.Drawing.Size(1036, 601);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.lstFiles);
      this.Controls.Add(this.pnlOptions);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Text = "Replace All";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.pnlOptions.ResumeLayout(false);
      this.pnlOptions.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSource;
    private System.Windows.Forms.Button btnBrowseSource;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMatch;
    private System.Windows.Forms.TextBox txtReplacement;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox chkRetainCase;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.CheckBox chkReplaceInFiles;
    private System.Windows.Forms.Button btnBrowseTarget;
    private System.Windows.Forms.TextBox txtTarget;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox lstFiles;
    private System.Windows.Forms.RichTextBox rtbFile;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtExcludeDirectories;
    private System.Windows.Forms.Panel pnlOptions;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
  }
}

