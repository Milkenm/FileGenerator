using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ScriptsLibV2.Extensions;

namespace FileGenerator
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_generate_Click(object sender, EventArgs e)
		{
			string filePath = CreateFile();

			ToggleUI(false);
			FillFile(filePath, new Action(() =>
			{
				ToggleUI(true);

				MessageBox.Show("File created!");
				Cleanup();
			}));
		}

		private string CreateFile()
		{
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			string filePath;
			do
			{
				string fileName = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
				filePath = $@"{desktopPath}\{fileName}";
			} while (File.Exists(filePath));

			FileStream fs = File.Create(filePath);
			fs.Close();

			return filePath;
		}

		private StringBuilder DataBuilder = new StringBuilder();

		private void FillFile(string filePath, Action ac)
		{
			FileStream fs = File.OpenWrite(filePath);

			long multiplier = (long)numeric_size.Value;
			if (radioButton_bytes.Checked)
			{
				AddToBuilder(1L);
			}
			if (radioButton_kbytes.Checked)
			{
				AddToBuilder(1024L);
			}
			else if (radioButton_mbytes.Checked)
			{
				AddToBuilder(1024L * 1024L);
			}
			else if (radioButton_gbytes.Checked)
			{
				multiplier *= 1024L;
				AddToBuilder(1024L * 1024L);
			}

			progressBar_progress.Maximum = (int)multiplier;

			new Thread(() =>
			{
				for (long i = 0; i < multiplier; i++)
				{
					byte[] write = DataBuilder.ToString().ToBytes();
					fs.Write(write, 0, write.Length);

					Invoke(new Action(() =>
					{
						progressBar_progress.Value += 1;
					}));
				}
				fs.Close();

				Invoke(new Action(() =>
				{
					ac.Invoke();
				}));
			}).Start();
		}

		private void AddToBuilder(long bytes)
		{
			if (DataBuilder.Length > bytes)
			{
				DataBuilder.Clear();
			}

			bytes -= DataBuilder.Length;
			for (int i = 0; i < bytes; i++)
			{
				DataBuilder.Append("Z");
				Console.WriteLine($"{i}/{bytes}");
			}
		}

		private void Cleanup()
		{
			progressBar_progress.Value = 0;
		}

		private void ToggleUI(bool isEnabled)
		{
			numeric_size.Enabled = isEnabled;
			radioButton_bytes.Enabled = isEnabled;
			radioButton_kbytes.Enabled = isEnabled;
			radioButton_mbytes.Enabled = isEnabled;
			radioButton_gbytes.Enabled = isEnabled;
			button_generate.Enabled = isEnabled;
		}
	}
}
