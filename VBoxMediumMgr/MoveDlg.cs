using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VirtualBox;

namespace VBoxMediumMgr
{
	public partial class MoveDlg : Form
	{
		private string srcId;

		public MoveDlg(string mediumId = null)
		{
			InitializeComponent();
			RefreshMediums(mediumId);
		}

		[DefaultValue("")]
		public string DestPath
		{
			get => fileTextBox.Text;
			set => fileTextBox.Text = value;
		}

		[DefaultValue(null)]
		public string SourceUuid
		{
			get => srcId;
			set
			{
				srcId = value;
				var idx = -1;
				if (value != null)
					idx = diskComboBox.Items.Cast<DiskInfo>().ToList().FindIndex(d => d.UUID == value);
				if (idx == -1 && diskComboBox.Items.Count > 0) idx = 0;
				diskComboBox.SelectedIndex = idx;
			}
		}

		private void diskOpenBtn_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = DestPath;
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
				DestPath = openFileDialog1.FileName;
		}

		private void fileSaveBtn_Click(object sender, EventArgs e)
		{
			if (fileTextBox.TextLength > 0) saveFileDialog1.FileName = fileTextBox.Text;
			if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
				fileTextBox.Text = saveFileDialog1.FileName;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void RefreshMediums(string mediumId)
		{
			diskComboBox.Items.Clear();
			diskComboBox.Items.AddRange(Main.Disks.Cast<object>().ToArray());
			SourceUuid = mediumId;
		}

		private void fileTextBox_TextChanged(object sender, EventArgs e)
		{
			okBtn.Enabled = fileTextBox.TextLength > 0;
		}

		private void diskComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//DestPath = System.IO.Path.GetFileNameWithoutExtension() + "." + FileType.ToString().ToLower();
		}
	}
}