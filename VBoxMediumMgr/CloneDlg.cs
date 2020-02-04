using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VBoxMediumMgr
{
	public partial class CloneDlg : Form
	{
		private string srcId;

		public CloneDlg(string mediumId = null)
		{
			InitializeComponent();
			diskOptionsCtrl.FileTypeChanged += diskOptionsCtrl_FileTypeChanged;
			RefreshMediums(mediumId);
		}

		public event EventHandler FileTypeChanged;

		[DefaultValue("")]
		public string DestPath
		{
			get => fileTextBox.Text;
			set => fileTextBox.Text = value;
		}

		[DefaultValue(0)]
		public HDFileType FileType
		{
			get => diskOptionsCtrl.FileType;
			set => diskOptionsCtrl.FileType = value;
		}

		[DefaultValue(null)]
		public string SourceUuid
		{
			get => srcId;
			set
			{
				srcId = value;
				var idx = value != null ? diskComboBox.Items.Cast<DiskInfo>().ToList().FindIndex(d => d.UUID == value) : -1;
				if (idx == -1 && diskComboBox.Items.Count > 0) idx = 0;
				diskComboBox.SelectedIndex = idx;
			}
		}

		[DefaultValue(true)]
		public bool Dynamic => diskOptionsCtrl.Dynamic;

		[DefaultValue(false)]
		public bool SplitFile => diskOptionsCtrl.SplitFile;

		private void diskComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (diskComboBox.SelectedItem is DiskInfo di)
			{
				FileType = (HDFileType)Enum.Parse(typeof(HDFileType), di.Format, true);
				var fi = new FileInfo(di.Location);
				DestPath = Path.Combine(fi.DirectoryName, Path.GetFileNameWithoutExtension(fi.Name) + "_Copy." + FileType.ToString().ToLowerInvariant());
			}
			else
			{
				FileType = HDFileType.VDI;
				DestPath = string.Empty;
			}
		}

		private void diskOpenBtn_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "VirtualBox VMs");
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
				DestPath = openFileDialog1.FileName;
		}

		private void diskOptionsCtrl_FileTypeChanged(object sender, EventArgs args)
		{
			FileTypeChanged?.Invoke(sender, args);
			if (DestPath.Contains("."))
				DestPath = Path.ChangeExtension(DestPath, FileType.ToString().ToLowerInvariant());
		}

		private void fileSaveBtn_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = DestPath;
			saveFileDialog1.SetFilterIndexFromFileName();
			if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
				fileTextBox.Text = saveFileDialog1.FileName;
		}

		private void fileTextBox_TextChanged(object sender, EventArgs e)
		{
			okBtn.Enabled = fileTextBox.TextLength > 0;
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
	}

	internal static class DlgExt
	{
		public static int SetFilterIndexFromFileName(this FileDialog dlg)
		{
			var ext = Path.GetExtension(dlg.FileName);
			if (string.IsNullOrEmpty(ext)) return -1;
			ext = "*" + ext;
			var filters = dlg.Filter.Split('|');
			var idx = Array.FindIndex(filters, f => string.Equals(ext, f, StringComparison.OrdinalIgnoreCase));
			if (idx == -1) return -1;
			return dlg.FilterIndex = (idx + 1) / 2;
		}
	}
}