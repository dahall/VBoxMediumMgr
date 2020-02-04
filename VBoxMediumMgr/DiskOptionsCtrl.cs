using System;
using System.Linq;
using System.Windows.Forms;

namespace VBoxMediumMgr
{
	public partial class DiskOptionsCtrl : UserControl
	{
		public DiskOptionsCtrl()
		{
			InitializeComponent();
			var i = 0;
			foreach (var r in flowLayoutPanel1.Controls.OfType<RadioButton>().OrderBy(r => r.TabIndex))
				r.Tag = (HDFileType)i++;
		}

		public event EventHandler FileTypeChanged;

		public bool Dynamic => dynamicRadioBtn.Checked;

		public HDFileType FileType
		{
			get => (HDFileType)(flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag ?? HDFileType.VDI);
			set { foreach (var r in flowLayoutPanel1.Controls.OfType<RadioButton>()) r.Checked = (HDFileType)r.Tag == value; }
		}

		public bool SplitFile => splitCheckBox.Checked;

		private void FileTypeCheckedChanged(object sender, EventArgs e)
		{
			if (!(sender is RadioButton rb) || rb.Checked) return;
			switch (rb.Name)
			{
				case nameof(vdiRadioBtn):
					SetStorageOptions(true, false);
					break;

				case nameof(vhdRadioBtn):
					SetStorageOptions(true, false);
					break;

				case nameof(vmdkRadioBtn):
					SetStorageOptions(true, true);
					break;

				case nameof(hddRadioBtn):
					SetStorageOptions(false, false);
					break;

				case nameof(qcowRadioBtn):
					SetStorageOptions(false, false);
					break;

				case nameof(qedRadioBtn):
					SetStorageOptions(false, false);
					break;
			}
			FileTypeChanged?.Invoke(rb, EventArgs.Empty);
		}

		private void SetStorageOptions(bool fixedSize, bool split)
		{
			fixedRadioBtn.Enabled = fixedSize;
			if (!fixedSize) dynamicRadioBtn.Checked = true;
			splitCheckBox.Enabled = split;
			if (!split) splitCheckBox.Checked = false;
		}
	}
}