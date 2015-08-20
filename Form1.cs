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
		public MainForm()
		{
			InitializeComponent();

			LoadSettings();

			UpdateList();

			CheckVersion();
		}

		private void LoadSettings()
		{
			if (Properties.Settings.Default.DoUpgrade)
			{
				Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.DoUpgrade = false;
				Properties.Settings.Default.Save();
			}

			txtHWDir.Text = Properties.Settings.Default.HomeworldDir;
			txtOutput.Text = Properties.Settings.Default.Output;

			loading = true;
			chkEnglish.Checked = Properties.Settings.Default.English;
			chkFrench.Checked = Properties.Settings.Default.French;
			chkGerman.Checked = Properties.Settings.Default.German;
			chkItalian.Checked = Properties.Settings.Default.Italian;
			chkRussian.Checked = Properties.Settings.Default.Russian;
			chkSpanish.Checked = Properties.Settings.Default.Spanish;
			loading = false;
			chkLanguage_CheckedChanged(this, new EventArgs());

			folderOptionsUpdating = true;
			this.rdoSeperate.Checked = Properties.Settings.Default.Seperate;
			this.rdoDataAndUpdates.Checked = Properties.Settings.Default.Grouped;
			this.rdoOnlyData.Checked = Properties.Settings.Default.Combined;
			folderOptionsUpdating = false;
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
			string dataDir = Properties.Settings.Default.HomeworldDir + @"\HomeworldRM\Data\";
			if (Directory.Exists(dataDir))
			{
				DirectoryInfo info = new DirectoryInfo(dataDir);
				var files = info.EnumerateFiles("*.big", SearchOption.TopDirectoryOnly);

				foreach (FileInfo item in files)
				{
					listBoxData.Items.Add(item.Name);
				}
			}

			string dataUpdateDir = Properties.Settings.Default.HomeworldDir + @"\HomeworldRM\DataUpdates\";
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
				Properties.Settings.Default.HomeworldDir = folderBrowserDialog1.SelectedPath;
				txtHWDir.Text = Properties.Settings.Default.HomeworldDir;
				Properties.Settings.Default.HomeworldDir = Properties.Settings.Default.HomeworldDir;
				Properties.Settings.Default.Save();

				UpdateList();
			}
		}

		RunWindow runner;
		private void btnGo_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.Output == "")
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
				string dataDir = Properties.Settings.Default.HomeworldDir + @"\HomeworldRM\Data\";
				foreach (var item in listBoxData.CheckedItems)
				{
					sendList.Add(dataDir + item.ToString());
				}
			}
			else if (tabControl1.SelectedTab == tabUpdates)
			{
				string dataDir = Properties.Settings.Default.HomeworldDir + @"\HomeworldRM\DataUpdates\";
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
				if (chkAll.Checked)
				{
					if (!Properties.Settings.Default.English && listBoxData.Items[i].ToString().Contains("English"))
						continue;

					if (!Properties.Settings.Default.French && listBoxData.Items[i].ToString().Contains("French"))
						continue;

					if (!Properties.Settings.Default.German && listBoxData.Items[i].ToString().Contains("German"))
						continue;

					if (!Properties.Settings.Default.Italian && listBoxData.Items[i].ToString().Contains("Italian"))
						continue;

					if (!Properties.Settings.Default.Russian && listBoxData.Items[i].ToString().Contains("Russian"))
						continue;

					if (!Properties.Settings.Default.Spanish && listBoxData.Items[i].ToString().Contains("Spanish"))
						continue;
				}

				listBoxData.SetItemChecked(i, chkAll.Checked);
			}
		}

		private void btnOutput_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				Properties.Settings.Default.Output = folderBrowserDialog1.SelectedPath;
				txtOutput.Text = Properties.Settings.Default.Output;
				Properties.Settings.Default.Output = Properties.Settings.Default.Output;
				Properties.Settings.Default.Save();
			}
		}

		private void chkAllUpdate_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < listBoxUpdate.Items.Count; i++)
			{
				if (chkAllUpdate.Checked)
				{
					if (!Properties.Settings.Default.English && listBoxUpdate.Items[i].ToString().Contains("English"))
						continue;

					if (!Properties.Settings.Default.French && listBoxUpdate.Items[i].ToString().Contains("French"))
						continue;

					if (!Properties.Settings.Default.German && listBoxUpdate.Items[i].ToString().Contains("German"))
						continue;

					if (!Properties.Settings.Default.Italian && listBoxUpdate.Items[i].ToString().Contains("Italian"))
						continue;

					if (!Properties.Settings.Default.Russian && listBoxUpdate.Items[i].ToString().Contains("Russian"))
						continue;

					if (!Properties.Settings.Default.Spanish && listBoxUpdate.Items[i].ToString().Contains("Spanish"))
						continue;
				}

				listBoxUpdate.SetItemChecked(i, chkAllUpdate.Checked);
			}
		}

		bool loading = false;
		private void chkLanguage_CheckedChanged(object sender, EventArgs e)
		{
			if (!loading)
			{
				XUnpack.Properties.Settings.Default.English = chkEnglish.Checked;
				XUnpack.Properties.Settings.Default.French = chkFrench.Checked;
				XUnpack.Properties.Settings.Default.German = chkGerman.Checked;
				XUnpack.Properties.Settings.Default.Italian = chkItalian.Checked;
				XUnpack.Properties.Settings.Default.Russian = chkRussian.Checked;
				XUnpack.Properties.Settings.Default.Spanish = chkSpanish.Checked;
				XUnpack.Properties.Settings.Default.Save();
				UpdateMulti();
			}
		}

		private void UpdateMulti()
		{
			if (!updating)
			{
				bool allChecked = true;
				bool someChecked = false;

				someChecked |= XUnpack.Properties.Settings.Default.English = chkEnglish.Checked;
				someChecked |= XUnpack.Properties.Settings.Default.French = chkFrench.Checked;
				someChecked |= XUnpack.Properties.Settings.Default.German = chkGerman.Checked;
				someChecked |= XUnpack.Properties.Settings.Default.Italian = chkItalian.Checked;
				someChecked |= XUnpack.Properties.Settings.Default.Russian = chkRussian.Checked;
				someChecked |= XUnpack.Properties.Settings.Default.Spanish = chkSpanish.Checked;

				allChecked &= XUnpack.Properties.Settings.Default.English = chkEnglish.Checked;
				allChecked &= XUnpack.Properties.Settings.Default.French = chkFrench.Checked;
				allChecked &= XUnpack.Properties.Settings.Default.German = chkGerman.Checked;
				allChecked &= XUnpack.Properties.Settings.Default.Italian = chkItalian.Checked;
				allChecked &= XUnpack.Properties.Settings.Default.Russian = chkRussian.Checked;
				allChecked &= XUnpack.Properties.Settings.Default.Spanish = chkSpanish.Checked;

				updating = true;
				if (allChecked)
					chkMultiLingual.CheckState = CheckState.Checked;
				else if (someChecked)
					chkMultiLingual.CheckState = CheckState.Indeterminate;
				else
					chkMultiLingual.CheckState = CheckState.Unchecked;
				updating = false;
			}
		}

		bool updating = false;
		private void chkMultiLingual_CheckedChanged(object sender, EventArgs e)
		{
			if(!updating)
			{
				updating = true;
				chkEnglish.Checked = chkMultiLingual.Checked;
				chkFrench.Checked = chkMultiLingual.Checked;
				chkGerman.Checked = chkMultiLingual.Checked;
				chkItalian.Checked = chkMultiLingual.Checked;
				chkRussian.Checked = chkMultiLingual.Checked;
				chkSpanish.Checked = chkMultiLingual.Checked;
				updating = false;
			}
		}

		bool folderOptionsUpdating = false;
		private void rdoSeperate_CheckedChanged(object sender, EventArgs e)
		{
			if(!folderOptionsUpdating)
			{
				folderOptionsUpdating = true;

				Properties.Settings.Default.Seperate = this.rdoSeperate.Checked;
				Properties.Settings.Default.Grouped = this.rdoDataAndUpdates.Checked;
				Properties.Settings.Default.Combined = this.rdoOnlyData.Checked;
				Properties.Settings.Default.Save();

				folderOptionsUpdating = false;
			}
		}
	}
}
