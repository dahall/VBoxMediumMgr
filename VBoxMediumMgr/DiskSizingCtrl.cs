using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vanara;

namespace VBoxMediumMgr
{
	public partial class DiskSizingCtrl : UserControl
	{
		public DiskSizingCtrl()
		{
			InitializeComponent();
			sizeSlider_Scroll(sizeSlider, EventArgs.Empty);
			tableLayoutPanel1.ColumnStyles[2].Width = TextRenderer.MeasureText(" 256.00 MB ", label3.Font).Width;
		}

		[DefaultValue(4194304)]
		public ulong FileSize => 1UL << sizeSlider.Value;

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			tableLayoutPanel1.ColumnStyles[2].Width = TextRenderer.MeasureText(" 256.00 MB ", label3.Font).Width;
		}

		private void sizeSlider_Scroll(object sender, EventArgs e)
		{
			var bytes = 1UL << sizeSlider.Value;
			sizeToolTip.SetToolTip(sizeSlider, bytes.ToString("N0") + " B");
			label3.Text = string.Format(ByteSizeFormatter.Instance, "{0:B2}", bytes);
		}
	}
}