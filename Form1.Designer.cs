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
			this.chkAll = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabData = new System.Windows.Forms.TabPage();
			this.tabUpdates = new System.Windows.Forms.TabPage();
			this.listBoxUpdate = new System.Windows.Forms.CheckedListBox();
			this.chkAllUpdate = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabData.SuspendLayout();
			this.tabUpdates.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxData
			// 
			this.listBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxData.FormattingEnabled = true;
			this.listBoxData.Location = new System.Drawing.Point(3, 20);
			this.listBoxData.Name = "listBoxData";
			this.listBoxData.ScrollAlwaysVisible = true;
			this.listBoxData.Size = new System.Drawing.Size(186, 123);
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
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.btnGo);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(664, 525);
			this.splitContainer1.SplitterDistance = 234;
			this.splitContainer1.TabIndex = 4;
			// 
			// chkAll
			// 
			this.chkAll.AutoSize = true;
			this.chkAll.Dock = System.Windows.Forms.DockStyle.Top;
			this.chkAll.Location = new System.Drawing.Point(3, 3);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new System.Drawing.Size(186, 17);
			this.chkAll.TabIndex = 1;
			this.chkAll.Text = "(De)Select All";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
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
			this.tabData.Size = new System.Drawing.Size(192, 146);
			this.tabData.TabIndex = 0;
			this.tabData.Text = "Data";
			this.tabData.UseVisualStyleBackColor = true;
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
	}
}

