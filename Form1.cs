using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XUnpack
{
	public partial class MainForm : Form
	{
		public static string homeworldDir = "";
		public static string outputDir = "";

		public MainForm()
		{
			InitializeComponent();

			if (Properties.Settings.Default.DoUpgrade)
			{
				Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.DoUpgrade = false;
				Properties.Settings.Default.Save();
			}

			homeworldDir = Properties.Settings.Default.HomeworldDir;
			outputDir = Properties.Settings.Default.Output;

			txtHWDir.Text = homeworldDir;
			txtOutput.Text = outputDir;

			UpdateList();
			CheckVersion();
		}

		private void CheckVersion()
		{
			var client = new Octokit.GitHubClient(new ProductHeaderValue("XUnpack"));
			var releases = client.Release.GetAll("xercodo", "XUnpack");
			try
			{
				var latest = releases.Result[0];

				Version ver = Assembly.GetExecutingAssembly().GetName().Version;
				string currentVersion = ver.Major + "." + ver.Minor;
				if (currentVersion != latest.TagName)
				{
					DialogResult result = MessageBox.Show(this, "There's a newer version of XUnpack!\r\n\r\n" +
						"Current: " + currentVersion + "\r\n" +
						"Latest Version: " + latest.TagName + "\r\n\r\n" +
						"Do you want to visit the release page now?",
						"Newer Version", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						Process proc = new Process();
						proc.StartInfo = new ProcessStartInfo(latest.HtmlUrl);
						proc.Start();
						this.Close();
					}
				}
			}
			catch { }
		}

		private void UpdateList()
		{
			string dataDir = homeworldDir + @"\HomeworldRM\Data\";
			if (Directory.Exists(dataDir))
			{
				DirectoryInfo info = new DirectoryInfo(dataDir);
				var files = info.EnumerateFiles("*.big", SearchOption.TopDirectoryOnly);

				foreach (FileInfo item in files)
				{
					listBoxData.Items.Add(item.Name);
				}
			}

			string dataUpdateDir = homeworldDir + @"\HomeworldRM\DataUpdates\";
			if (Directory.Exists(dataUpdateDir))
			{
				DirectoryInfo info = new DirectoryInfo(dataUpdateDir);
				var files = info.EnumerateFiles("*.big", SearchOption.TopDirectoryOnly);

				foreach (FileInfo item in files)
				{
					listBoxUpdate.Items.Add(item.Name);
				}
			}
		}

		private void btnHWDir_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				homeworldDir = folderBrowserDialog1.SelectedPath;
				txtHWDir.Text = homeworldDir;
				Properties.Settings.Default.HomeworldDir = homeworldDir;
				Properties.Settings.Default.Save();

				UpdateList();
			}
		}

		RunWindow runner;
		private void btnGo_Click(object sender, EventArgs e)
		{
			if (outputDir == "")
			{
				MessageBox.Show(this, "Please select an output directory.");
				return;
			}

			if(listBoxData.CheckedItems.Count == 0 && listBoxUpdate.CheckedItems.Count == 0)
			{
				MessageBox.Show(this, "Please select at least one big file to extract.");
				return;
			}

			List<String> sendList = new List<string>();

			if (tabControl1.SelectedTab == tabData)
			{
				string dataDir = homeworldDir + @"\HomeworldRM\Data\";
				foreach (var item in listBoxData.CheckedItems)
				{
					sendList.Add(dataDir + item.ToString());
				}
			}
			else if (tabControl1.SelectedTab == tabUpdates)
			{
				string dataDir = homeworldDir + @"\HomeworldRM\DataUpdates\";
				foreach (var item in listBoxUpdate.CheckedItems)
				{
					sendList.Add(dataDir + item.ToString());
				}
			}

			runner = new RunWindow(sendList);
			runner.ShowDialog();
		}

		private void chkAll_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < listBoxData.Items.Count; i++)
			{
				listBoxData.SetItemChecked(i, chkAll.Checked);
			}
		}

		private void btnOutput_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				outputDir = folderBrowserDialog1.SelectedPath;
				txtOutput.Text = outputDir;
				Properties.Settings.Default.Output = outputDir;
				Properties.Settings.Default.Save();
			}
		}

		private void chkAllUpdate_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < listBoxUpdate.Items.Count; i++)
			{
				listBoxUpdate.SetItemChecked(i, chkAllUpdate.Checked);
			}
		}
	}
}
