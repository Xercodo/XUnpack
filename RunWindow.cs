using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace XUnpack
{
    public partial class RunWindow : Form
    {
        List<string> runList;

        public RunWindow(List<string> profiles)
        {
            InitializeComponent();

            runList = profiles;
            this.Focus();
            this.Refresh();
        }

		public void Kill()
		{
			runner.Abort();
		}


        public void RunList()
        {
            //Thread.Sleep(100);

            int stepAmount = 100 / runList.Count;
			string path = MainForm.homeworldDir + "\\GBXTools\\WorkshopTool\\Archive.exe";
			string dir = Path.GetDirectoryName(path);

            for (int i = 0; i < runList.Count; i++)
            {
                string item = runList[i];
				string name = Path.GetFileNameWithoutExtension(item);
                this.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "Current: " + name + " (" + (i + 1) + "/" + runList.Count + ")";
                });

				string seperator = "Starting big file: " + name;
                seperator = seperator.PadRight(69, '=');
                WriteAsynch(seperator + "\r\n");

				if(item.Contains(@"HomeworldRM\DataUpdates\"))


                WriteAsynch("Starting Decryptor...\r\n");
                Process decrypt = new Process();
                decrypt.StartInfo.FileName = "bigDecrypter.exe";
                decrypt.StartInfo.Arguments = "\"" + item + "\" \"" + dir + "\\" + name + "_decrypted.big\"";
                decrypt.StartInfo.CreateNoWindow = true;
                decrypt.StartInfo.RedirectStandardError = true;
                decrypt.StartInfo.RedirectStandardOutput = true;
                decrypt.StartInfo.ErrorDialog = true;
                decrypt.StartInfo.UseShellExecute = false;

                decrypt.Start();

				bool noDecrypt = false;
				while (!decrypt.StandardOutput.EndOfStream)
				{
					string buffer = "";
					buffer = decrypt.StandardOutput.ReadToEnd();

					string normalized = Regex.Replace(buffer, @"\r\n|\n\r|\n|\r", "\r\n");
					WriteAsynch(normalized);

					if(normalized.Contains("No need to run this"))
					{
						noDecrypt = true;
					}
				}

                decrypt.WaitForExit();

                WriteAsynch(name + " is done.\r\n");

				string args = "";

				if(noDecrypt)
				{
					args = "-e \"" + MainForm.outputDir + "\\" + name + "\" -a \"" + name + ".big\"";
					string copyPath = Path.GetDirectoryName(path) + "\\" + name + ".big";
					File.Copy(item, copyPath);
				}
				else
				{
					args = "-e \"" + MainForm.outputDir + "\\" + name + "\" -a \"" + name + "_decrypted.big\"";
				}

				WriteAsynch("Starting archiver...\r\n");
				Process archive = new Process();
				archive.StartInfo.FileName = path;
				archive.StartInfo.Arguments = args;
				archive.StartInfo.Domain = dir;
				archive.StartInfo.WorkingDirectory = dir;
				archive.StartInfo.CreateNoWindow = true;
				archive.StartInfo.RedirectStandardError = true;
				archive.StartInfo.RedirectStandardOutput = true;
				archive.StartInfo.ErrorDialog = true;
				archive.StartInfo.UseShellExecute = false;

				archive.Start();

				while (!archive.StandardOutput.EndOfStream)
				{
					char[] buffer = new char[20];
					archive.StandardOutput.Read(buffer, 0, 20);

					string normalized = Regex.Replace(new string(buffer), @"\r\n|\n\r|\n|\r", "\r\n");
					WriteAsynch(normalized);

					//buffer = new char[20];
					//archive.StandardError.Read(buffer, 0, 20);

					//normalized = Regex.Replace(new string(buffer), @"\r\n|\n\r|\n|\r", "\r\n");
					//WriteAsynch(normalized);

				}

				archive.WaitForExit();

				if (noDecrypt)
				{
					File.Delete(dir + "\\" + name + ".big");
				}
				else
				{
					File.Delete(dir + "\\" + name + "_decrypted.big");
				}

                WriteAsynch("\r\n");

                this.Invoke((MethodInvoker)delegate
                {
                    SetProgressNoAnimation(toolStripProgressBar1, ((i + 1) * stepAmount));
                });
            }

            WriteAsynch("DONE!\r\n");
            this.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "Current: DONE! (" + runList.Count + "/" + runList.Count + ")";
                });
        }

        void WriteAsynch(string data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.AppendText(data);
                txtConsole.Refresh();
            });
        }

		Thread runner;
        private void RunWindow_Load(object sender, EventArgs e)
        {
            runner = new Thread(new ThreadStart(RunList));
            runner.Start();
            //RunList();
        }

        /// <summary>
        /// Used to circumvent the animations used on progress bars inWindows 7 and up.
        /// Includes a Update() call to take care of redraw.
        /// </summary>
        /// <param name="pb">The progress bar to be updated</param>
        /// <param name="value">Value from 0 to 100 for the progress bar</param>
        public static void SetProgressNoAnimation(ProgressBar pb, int value)
        {
            // To get around the progressive animation, we need to move the 
            // progress bar backwards.
            if (value == pb.Maximum)
            {
                // Special case as value can't be set greater than Maximum.
                pb.Maximum = value + 1;     // Temporarily Increase Maximum
                pb.Value = value + 1;       // Move past
                pb.Maximum = value;         // Reset maximum
            }
            else
            {
                pb.Value = value + 1;       // Move past
            }
            pb.Value = value;               // Move to correct value
            pb.Update();
        }

        public static void SetProgressNoAnimation(ToolStripProgressBar pb, int value)
        {
            // To get around the progressive animation, we need to move the 
            // progress bar backwards.
            if (value == pb.Maximum)
            {
                // Special case as value can't be set greater than Maximum.
                pb.Maximum = value + 1;     // Temporarily Increase Maximum
                pb.Value = value + 1;       // Move past
                pb.Maximum = value;         // Reset maximum
            }
            else
            {
                pb.Value = value + 1;       // Move past
            }
            pb.Value = value;               // Move to correct value
            if (pb.Owner != null)
                pb.Owner.Update();
        }

		private void RunWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			runner.Abort();
		}
    }
}
