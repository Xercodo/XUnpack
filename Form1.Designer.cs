namespace XUnpack
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listBoxData = new System.Windows.Forms.CheckedListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHWDir = new System.Windows.Forms.Button();
			this.txtHWDir = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOutput = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabData = new System.Windows.Forms.TabPage();
			this.chkAll = new System.Windows.Forms.CheckBox();
			this.tabUpdates = new System.Windows.Forms.TabPage();
			this.listBoxUpdate = new System.Windows.Forms.CheckedListBox();
			this.chkAllUpdate = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkMultiLingual = new System.Windows.Forms.CheckBox();
			this.chkSpanish = new System.Windows.Forms.CheckBox();
			this.chkRussian = new System.Windows.Forms.CheckBox();
			this.chkItalian = new System.Windows.Forms.CheckBox();
			this.chkFrench = new System.Windows.Forms.CheckBox();
			this.chkGerman = new System.Windows.Forms.CheckBox();
			this.chkEnglish = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.rdoSeperate = new System.Windows.Forms.RadioButton();
			this.rdoDataAndUpdates = new System.Windows.Forms.RadioButton();
			this.rdoOnlyData = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabData.SuspendLayout();
			this.tabUpdates.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxData
			// 
			this.listBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxData.FormattingEnabled = true;
			this.listBoxData.Location = new System.Drawing.Point(3, 20);
			this.listBoxData.Name = "listBoxData";
			this.listBoxData.ScrollAlwaysVisible = true;
			this.listBoxData.Size = new System.Drawing.Size(220, 476);
			this.listBoxData.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnHWDir);
			this.groupBox1.Controls.Add(this.txtHWDir);
			this.groupBox1.Location = new System.Drawing.Point(17, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(397, 55);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "HW Directory";
			// 
			// btnHWDir
			// 
			this.btnHWDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHWDir.Location = new System.Drawing.Point(316, 19);
			this.btnHWDir.Name = "btnHWDir";
			this.btnHWDir.Size = new System.Drawing.Size(75, 23);
			this.btnHWDir.TabIndex = 1;
			this.btnHWDir.Text = "Browse";
			this.btnHWDir.UseVisualStyleBackColor = true;
			this.btnHWDir.Click += new System.EventHandler(this.btnHWDir_Click);
			// 
			// txtHWDir
			// 
			this.txtHWDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHWDir.Location = new System.Drawing.Point(6, 21);
			this.txtHWDir.Name = "txtHWDir";
			this.txtHWDir.ReadOnly = true;
			this.txtHWDir.Size = new System.Drawing.Size(304, 20);
			this.txtHWDir.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnOutput);
			this.groupBox2.Controls.Add(this.txtOutput);
			this.groupBox2.Location = new System.Drawing.Point(17, 74);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(397, 55);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output Directory";
			// 
			// btnOutput
			// 
			this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOutput.Location = new System.Drawing.Point(316, 19);
			this.btnOutput.Name = "btnOutput";
			this.btnOutput.Size = new System.Drawing.Size(75, 23);
			this.btnOutput.TabIndex = 1;
			this.btnOutput.Text = "Browse";
			this.btnOutput.UseVisualStyleBackColor = true;
			this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(6, 21);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(304, 20);
			this.txtOutput.TabIndex = 0;
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(333, 135);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 3;
			this.btnGo.Text = "Extract...";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.btnGo);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(664, 525);
			this.splitContainer1.SplitterDistance = 234;
			this.splitContainer1.TabIndex = 4;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabData);
			this.tabControl1.Controls.Add(this.tabUpdates);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(234, 525);
			this.tabControl1.TabIndex = 2;
			// 
			// tabData
			// 
			this.tabData.Controls.Add(this.listBoxData);
			this.tabData.Controls.Add(this.chkAll);
			this.tabData.Location = new System.Drawing.Point(4, 22);
			this.tabData.Name = "tabData";
			this.tabData.Padding = new System.Windows.Forms.Padding(3);
			this.tabData.Size = new System.Drawing.Size(226, 499);
			this.tabData.TabIndex = 0;
			this.tabData.Text = "Data";
			this.tabData.UseVisualStyleBackColor = true;
			// 
			// chkAll
			// 
			this.chkAll.AutoSize = true;
			this.chkAll.Dock = System.Windows.Forms.DockStyle.Top;
			this.chkAll.Location = new System.Drawing.Point(3, 3);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new System.Drawing.Size(220, 17);
			this.chkAll.TabIndex = 1;
			this.chkAll.Text = "(De)Select All";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
			// 
			// tabUpdates
			// 
			this.tabUpdates.Controls.Add(this.listBoxUpdate);
			this.tabUpdates.Controls.Add(this.chkAllUpdate);
			this.tabUpdates.Location = new System.Drawing.Point(4, 22);
			this.tabUpdates.Name = "tabUpdates";
			this.tabUpdates.Padding = new System.Windows.Forms.Padding(3);
			this.tabUpdates.Size = new System.Drawing.Size(226, 499);
			this.tabUpdates.TabIndex = 1;
			this.tabUpdates.Text = "DataUpdates";
			this.tabUpdates.UseVisualStyleBackColor = true;
			// 
			// listBoxUpdate
			// 
			this.listBoxUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxUpdate.FormattingEnabled = true;
			this.listBoxUpdate.Location = new System.Drawing.Point(3, 20);
			this.listBoxUpdate.Name = "listBoxUpdate";
			this.listBoxUpdate.ScrollAlwaysVisible = true;
			this.listBoxUpdate.Size = new System.Drawing.Size(220, 476);
			this.listBoxUpdate.TabIndex = 2;
			// 
			// chkAllUpdate
			// 
			this.chkAllUpdate.AutoSize = true;
			this.chkAllUpdate.Dock = System.Windows.Forms.DockStyle.Top;
			this.chkAllUpdate.Location = new System.Drawing.Point(3, 3);
			this.chkAllUpdate.Name = "chkAllUpdate";
			this.chkAllUpdate.Size = new System.Drawing.Size(220, 17);
			this.chkAllUpdate.TabIndex = 3;
			this.chkAllUpdate.Text = "(De)Select All";
			this.chkAllUpdate.UseVisualStyleBackColor = true;
			this.chkAllUpdate.CheckedChanged += new System.EventHandler(this.chkAllUpdate_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkMultiLingual);
			this.groupBox3.Controls.Add(this.chkSpanish);
			this.groupBox3.Controls.Add(this.chkRussian);
			this.groupBox3.Controls.Add(this.chkItalian);
			this.groupBox3.Controls.Add(this.chkFrench);
			this.groupBox3.Controls.Add(this.chkGerman);
			this.groupBox3.Controls.Add(this.chkEnglish);
			this.groupBox3.Location = new System.Drawing.Point(17, 135);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(130, 183);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "What\'s your language?";
			// 
			// chkMultiLingual
			// 
			this.chkMultiLingual.AutoSize = true;
			this.chkMultiLingual.Location = new System.Drawing.Point(6, 157);
			this.chkMultiLingual.Name = "chkMultiLingual";
			this.chkMultiLingual.Size = new System.Drawing.Size(111, 17);
			this.chkMultiLingual.TabIndex = 0;
			this.chkMultiLingual.Text = "Multilingual as hell";
			this.chkMultiLingual.UseVisualStyleBackColor = true;
			this.chkMultiLingual.CheckedChanged += new System.EventHandler(this.chkMultiLingual_CheckedChanged);
			// 
			// chkSpanish
			// 
			this.chkSpanish.AutoSize = true;
			this.chkSpanish.Location = new System.Drawing.Point(6, 134);
			this.chkSpanish.Name = "chkSpanish";
			this.chkSpanish.Size = new System.Drawing.Size(64, 17);
			this.chkSpanish.TabIndex = 0;
			this.chkSpanish.Text = "Spanish";
			this.chkSpanish.UseVisualStyleBackColor = true;
			this.chkSpanish.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// chkRussian
			// 
			this.chkRussian.AutoSize = true;
			this.chkRussian.Location = new System.Drawing.Point(6, 111);
			this.chkRussian.Name = "chkRussian";
			this.chkRussian.Size = new System.Drawing.Size(64, 17);
			this.chkRussian.TabIndex = 0;
			this.chkRussian.Text = "Russian";
			this.chkRussian.UseVisualStyleBackColor = true;
			this.chkRussian.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// chkItalian
			// 
			this.chkItalian.AutoSize = true;
			this.chkItalian.Location = new System.Drawing.Point(6, 88);
			this.chkItalian.Name = "chkItalian";
			this.chkItalian.Size = new System.Drawing.Size(54, 17);
			this.chkItalian.TabIndex = 0;
			this.chkItalian.Text = "Italian";
			this.chkItalian.UseVisualStyleBackColor = true;
			this.chkItalian.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// chkFrench
			// 
			this.chkFrench.AutoSize = true;
			this.chkFrench.Location = new System.Drawing.Point(6, 65);
			this.chkFrench.Name = "chkFrench";
			this.chkFrench.Size = new System.Drawing.Size(59, 17);
			this.chkFrench.TabIndex = 0;
			this.chkFrench.Text = "French";
			this.chkFrench.UseVisualStyleBackColor = true;
			this.chkFrench.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// chkGerman
			// 
			this.chkGerman.AutoSize = true;
			this.chkGerman.Location = new System.Drawing.Point(6, 42);
			this.chkGerman.Name = "chkGerman";
			this.chkGerman.Size = new System.Drawing.Size(63, 17);
			this.chkGerman.TabIndex = 0;
			this.chkGerman.Text = "German";
			this.chkGerman.UseVisualStyleBackColor = true;
			this.chkGerman.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// chkEnglish
			// 
			this.chkEnglish.AutoSize = true;
			this.chkEnglish.Location = new System.Drawing.Point(6, 19);
			this.chkEnglish.Name = "chkEnglish";
			this.chkEnglish.Size = new System.Drawing.Size(60, 17);
			this.chkEnglish.TabIndex = 0;
			this.chkEnglish.Text = "English";
			this.chkEnglish.UseVisualStyleBackColor = true;
			this.chkEnglish.CheckedChanged += new System.EventHandler(this.chkLanguage_CheckedChanged);
			// 
			// rdoSeperate
			// 
			this.rdoSeperate.AutoSize = true;
			this.rdoSeperate.Location = new System.Drawing.Point(6, 19);
			this.rdoSeperate.Name = "rdoSeperate";
			this.rdoSeperate.Size = new System.Drawing.Size(68, 17);
			this.rdoSeperate.TabIndex = 7;
			this.rdoSeperate.TabStop = true;
			this.rdoSeperate.Text = "Seperate";
			this.toolTip1.SetToolTip(this.rdoSeperate, "Each .big file will have its own folder.");
			this.rdoSeperate.UseVisualStyleBackColor = true;
			this.rdoSeperate.CheckedChanged += new System.EventHandler(this.rdoSeperate_CheckedChanged);
			// 
			// rdoDataAndUpdates
			// 
			this.rdoDataAndUpdates.AutoSize = true;
			this.rdoDataAndUpdates.Location = new System.Drawing.Point(6, 42);
			this.rdoDataAndUpdates.Name = "rdoDataAndUpdates";
			this.rdoDataAndUpdates.Size = new System.Drawing.Size(66, 17);
			this.rdoDataAndUpdates.TabIndex = 8;
			this.rdoDataAndUpdates.TabStop = true;
			this.rdoDataAndUpdates.Text = "Grouped";
			this.toolTip1.SetToolTip(this.rdoDataAndUpdates, "The Data and DataUpdates .big files will be kept seperate.");
			this.rdoDataAndUpdates.UseVisualStyleBackColor = true;
			this.rdoDataAndUpdates.CheckedChanged += new System.EventHandler(this.rdoSeperate_CheckedChanged);
			// 
			// rdoOnlyData
			// 
			this.rdoOnlyData.AutoSize = true;
			this.rdoOnlyData.Location = new System.Drawing.Point(6, 65);
			this.rdoOnlyData.Name = "rdoOnlyData";
			this.rdoOnlyData.Size = new System.Drawing.Size(72, 17);
			this.rdoOnlyData.TabIndex = 9;
			this.rdoOnlyData.TabStop = true;
			this.rdoOnlyData.Text = "Combined";
			this.toolTip1.SetToolTip(this.rdoOnlyData, "All files in the same folder with the most recent extraction replacing the one pr" +
        "ior.");
			this.rdoOnlyData.UseVisualStyleBackColor = true;
			this.rdoOnlyData.CheckedChanged += new System.EventHandler(this.rdoSeperate_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rdoSeperate);
			this.groupBox4.Controls.Add(this.rdoOnlyData);
			this.groupBox4.Controls.Add(this.rdoDataAndUpdates);
			this.groupBox4.Location = new System.Drawing.Point(153, 135);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(90, 92);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Folder Ouput";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 525);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "XUnpack";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabData.ResumeLayout(false);
			this.tabData.PerformLayout();
			this.tabUpdates.ResumeLayout(false);
			this.tabUpdates.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox listBoxData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnHWDir;
		private System.Windows.Forms.TextBox txtHWDir;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOutput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox chkAll;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabData;
		private System.Windows.Forms.TabPage tabUpdates;
		private System.Windows.Forms.CheckedListBox listBoxUpdate;
		private System.Windows.Forms.CheckBox chkAllUpdate;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkRussian;
		private System.Windows.Forms.CheckBox chkItalian;
		private System.Windows.Forms.CheckBox chkFrench;
		private System.Windows.Forms.CheckBox chkGerman;
		private System.Windows.Forms.CheckBox chkEnglish;
		private System.Windows.Forms.CheckBox chkMultiLingual;
		private System.Windows.Forms.CheckBox chkSpanish;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rdoSeperate;
		private System.Windows.Forms.RadioButton rdoOnlyData;
		private System.Windows.Forms.RadioButton rdoDataAndUpdates;
	}
}

