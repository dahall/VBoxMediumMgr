namespace VBoxMediumMgr
{
	partial class DiskSizingCtrl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sizeSlider = new Vanara.Windows.Forms.TrackBarEx();
			this.sizeToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "2.00 TB";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.label3.Location = new System.Drawing.Point(307, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "256.00 MB";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "4.00 MB";
			// 
			// sizeSlider
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.sizeSlider, 2);
			this.sizeSlider.Dock = System.Windows.Forms.DockStyle.Top;
			this.sizeSlider.LargeChange = 1;
			this.sizeSlider.Location = new System.Drawing.Point(0, 0);
			this.sizeSlider.Margin = new System.Windows.Forms.Padding(0);
			this.sizeSlider.Maximum = 41;
			this.sizeSlider.Minimum = 22;
			this.sizeSlider.Name = "sizeSlider";
			this.sizeSlider.Size = new System.Drawing.Size(307, 35);
			this.sizeSlider.TabIndex = 0;
			this.sizeSlider.Value = 22;
			this.sizeSlider.Scroll += new System.EventHandler(this.sizeSlider_Scroll);
			// 
			// sizeToolTip
			// 
			this.sizeToolTip.AutoPopDelay = 5000;
			this.sizeToolTip.InitialDelay = 1000;
			this.sizeToolTip.ReshowDelay = 500;
			this.sizeToolTip.ShowAlways = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.sizeSlider, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 50);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// DiskSizingCtrl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "DiskSizingCtrl";
			this.Size = new System.Drawing.Size(387, 53);
			((System.ComponentModel.ISupportInitialize)(this.sizeSlider)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Vanara.Windows.Forms.TrackBarEx sizeSlider;
		private System.Windows.Forms.ToolTip sizeToolTip;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
