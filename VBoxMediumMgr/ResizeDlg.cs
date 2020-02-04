using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Vanara;

namespace VBoxMediumMgr
{
	public partial class ResizeDlg : Form
	{
		private bool initializing, sliderMove;
		private string srcId;
		private long startSize;

		public ResizeDlg(string mediumId = null)
		{
			InitializeComponent();
			RefreshMediums(mediumId);
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

		public long NewDiskSize => diskResizerCtrl1.NewDiskSize;

		private void diskComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			initializing = true;
			diskResizerCtrl1.CurrentDiskSize = (diskComboBox.SelectedItem as DiskInfo)?.VirtualSize ?? 4194304L;
			curSize.Text = string.Format(ByteSizeFormatter.Instance, "Current Size: {0:B2}", diskResizerCtrl1.CurrentDiskSize);
			diskResizerCtrl1.CurrentDiskUsed = (diskComboBox.SelectedItem as DiskInfo)?.Size ?? 4194304L;
			minSize.Text = string.Format(ByteSizeFormatter.Instance, "Min Size: {0:B2}", diskResizerCtrl1.CurrentDiskUsed);
			diskResizerCtrl1.SetSelectionRange(diskResizerCtrl1.SelectionStart, diskResizerCtrl1.SelectionEnd);
			startSize = diskResizerCtrl1.CurrentDiskSize;
			initializing = false;
		}

		private void diskResizerCtrl1_ValueChanged(object sender, EventArgs e)
		{
			sliderMove = true;
			okBtn.Enabled = startSize != diskResizerCtrl1.NewDiskSize;
			newSize.Text = string.Format(ByteSizeFormatter.Instance, "{0:B2}", diskResizerCtrl1.NewDiskSize);
			sliderMove = false;
		}

		private void newSize_TextChanged(object sender, EventArgs e)
		{
			if (!initializing && !sliderMove && ByteSizeFormatter.TryParse(newSize.Text, out var sz))
				diskResizerCtrl1.NewDiskSize = sz;
		}

		private void okBtn_Click(object sender, EventArgs e) => Close();

		private void RefreshMediums(string mediumId)
		{
			diskComboBox.Items.Clear();
			diskComboBox.Items.AddRange(Main.Disks.Cast<object>().ToArray());
			SourceUuid = mediumId;
		}
	}
}