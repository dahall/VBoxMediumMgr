using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VBoxMediumMgr
{
	public partial class CreateDlg : Form
	{
		public CreateDlg() => InitializeComponent();

		[DefaultValue(0)]
		public HDFileType FileType
		{
			get => diskOptionsCtrl.FileType;
			set => diskOptionsCtrl.FileType = value;
		}

		[DefaultValue("")]
		public string Path
		{
			get => fileTextBox.Text;
			set => fileTextBox.Text = value;
		}

		[DefaultValue(true)]
		public bool Dynamic => diskOptionsCtrl.Dynamic;

		[DefaultValue(4194304)]
		public ulong FileSize => diskSizer.FileSize;

		[DefaultValue(false)]
		public bool SplitFile => diskOptionsCtrl.SplitFile;

		private void fileSaveBtn_Click(object sender, EventArgs e)
		{
			if (fileTextBox.TextLength > 0) saveFileDialog1.FileName = fileTextBox.Text;
			if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
				fileTextBox.Text = saveFileDialog1.FileName;
		}

		private void fileTextBox_TextChanged(object sender, EventArgs e) => okBtn.Enabled = fileTextBox.TextLength > 0;

		private void okBtn_Click(object sender, EventArgs e) => Close();
	}
}