using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Vanara.Extensions;
using Vanara.Windows.Forms;

namespace VBoxMediumMgr
{
	public class DiskResizerCtrl : TrackBarEx
	{
		private const int basePow = 22;
		private const int maxPow = 41;
		private const int step = 8;
		private static readonly Color borderClr = Color.FromArgb(214,214,214);
		private static readonly Color curClr = Color.FromArgb(231,234,234);
		private static readonly Color usedClr = Color.Gray;
		private static readonly Color usedBrdClr = Color.Gray;

		private long diskSize;
		private long diskUsed;
		private static Bitmap thumbBmp;

		public DiskResizerCtrl()
		{
			SelectionEnd = Maximum = (maxPow - basePow) * step;
			SelectionStart = Minimum = 0;
			LargeChange = step;
			LimitThumbToSelection = true;
			OwnerDraw = true;
			TickFrequency = step;
			TickStyle = TickStyle.Both;
			DrawChannel += OnDrawChannel;
			DrawThumb += OnDrawThumb;
		}

		[DefaultValue(0), Category("Data")]
		public long CurrentDiskSize
		{
			get => diskSize;
			set => NewDiskSize = diskSize = value;
		}

		[DefaultValue(0), Category("Data")]
		public long CurrentDiskUsed
		{
			get => diskUsed;
			set { diskUsed = value; SelectionStart = ClosestVal(value); }
		}

		[DefaultValue(4194304), Browsable(false)]
		public long NewDiskSize
		{
			get => ValToSize(Value);
			set
			{
				var newVal = ClosestVal(value);
				if (newVal < SelectionStart) newVal = SelectionStart;
				if (newVal > SelectionEnd) newVal = SelectionEnd;
				Value = newVal;
			}
		}

		private Bitmap ThumbBmp => thumbBmp ?? (thumbBmp = Properties.Resources.grip);

		private static int ClosestVal(long bytes)
		{
			var approx = Math.Log(bytes >> 22, 2) * step;
			var floor = (int) Math.Floor(approx);
			if (ValToSize(floor) == bytes) return floor;
			return (int)Math.Ceiling(approx);
		}

		private static long ValToSize(int val) => (long)Math.Round(Math.Pow(2, Math.Floor(val / (float)step) + basePow) * (1 + ((val % step) / (float)step)));

		private void OnDrawChannel(object sender, PaintEventArgs pe)
		{
			Debug.WriteLine($"DrawChannel: val:{Value}, selSt:{SelectionStart}");
			pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (BackColor != Color.Transparent)
				using (var b = new SolidBrush(BackColor))
					pe.Graphics.FillRectangle(b, pe.ClipRectangle);
			RectangleF r = pe.ClipRectangle;
			r.Width *= (Value - Minimum) / (float)(Maximum - Minimum);
			r.Height -= 1;
			var p = new GraphicsPath();
			p.AddRectangle(r);
			using (var b = new SolidBrush(curClr))
				pe.Graphics.FillPath(b, p);
			using (var pen = new Pen(borderClr))
				pe.Graphics.DrawPath(pen, p);
			r.Width = pe.ClipRectangle.Width * (SelectionStart - Minimum) / (float)(Maximum - Minimum);
			r.Inflate(-1, -2);
			p = new GraphicsPath();
			p.AddRoundedRectangle(r, new Size(4, 4), Corners.TopRight | Corners.BottomRight);
			using (var b = new SolidBrush(usedClr))
				pe.Graphics.FillPath(b, p);
			using (var pen = new Pen(usedBrdClr))
				pe.Graphics.DrawPath(pen, p);
		}

		private void OnDrawThumb(object sender, PaintEventArgs pe)
		{
			var mouseOver = pe.ClipRectangle.Contains(PointToClient(MousePosition));
			var bs = Enabled ? (mouseOver ? (MouseButtons == MouseButtons.Left ? PushButtonState.Pressed : PushButtonState.Hot) : PushButtonState.Normal) : PushButtonState.Disabled;
			ButtonRenderer.DrawButton(pe.Graphics, pe.ClipRectangle, false, bs);

			//var bmpRect = Rectangle.Inflate(pe.ClipRectangle, -1, -1);
			//bmpRect.Height = (int)Math.Round(bmpRect.Width * (double) ThumbBmp.Height / ThumbBmp.Width);
			//bmpRect.Offset((pe.ClipRectangle.Width - bmpRect.Width) / 2, (pe.ClipRectangle.Height - bmpRect.Height) / 2);
			var bmpRect = new Rectangle((pe.ClipRectangle.Width - ThumbBmp.Width) / 2 + pe.ClipRectangle.X, (pe.ClipRectangle.Height - ThumbBmp.Height) / 2 + pe.ClipRectangle.Y, ThumbBmp.Width, ThumbBmp.Height);
			pe.Graphics.DrawImage(ThumbBmp, bmpRect);

			Debug.WriteLine($"DrawThumb: bmpR:{bmpRect}");
			Invalidate(Rectangle.Inflate(ChannelBounds, 0, 1));
		}
	}
}