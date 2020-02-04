namespace VBoxMediumMgr
{
	partial class ResizeDlg
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeDlg));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.diskOpenBtn = new System.Windows.Forms.Button();
			this.diskComboBox = new System.Windows.Forms.ComboBox();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.commandPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.diskResizerCtrl1 = new VBoxMediumMgr.DiskResizerCtrl();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.minSize = new System.Windows.Forms.Label();
			this.curSize = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.newSize = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.commandPanel.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.diskResizerCtrl1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.diskOpenBtn);
			this.groupBox1.Controls.Add(this.diskComboBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(11, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(445, 55);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&Hard disk to resize";
			// 
			// diskOpenBtn
			// 
			this.diskOpenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.diskOpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("diskOpenBtn.Image")));
			this.diskOpenBtn.Location = new System.Drawing.Point(413, 22);
			this.diskOpenBtn.Name = "diskOpenBtn";
			this.diskOpenBtn.Size = new System.Drawing.Size(23, 23);
			this.diskOpenBtn.TabIndex = 1;
			this.diskOpenBtn.UseVisualStyleBackColor = true;
			// 
			// diskComboBox
			// 
			this.diskComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.diskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.diskComboBox.FormattingEnabled = true;
			this.diskComboBox.Location = new System.Drawing.Point(9, 22);
			this.diskComboBox.Name = "diskComboBox";
			this.diskComboBox.Size = new System.Drawing.Size(398, 23);
			this.diskComboBox.TabIndex = 0;
			this.diskComboBox.SelectedIndexChanged += new System.EventHandler(this.diskComboBox_SelectedIndexChanged);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(381, 12);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(0, 11, 11, 11);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 2;
			this.cancelBtn.Text = "&Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okBtn.Enabled = false;
			this.okBtn.Location = new System.Drawing.Point(299, 12);
			this.okBtn.Margin = new System.Windows.Forms.Padding(11, 11, 7, 11);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "Resize";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
			this.openFileDialog1.Title = "Open virtual hard disk file";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "vdi";
			this.saveFileDialog1.Filter = resources.GetString("saveFileDialog1.Filter");
			this.saveFileDialog1.InitialDirectory = "%USERPROFILE%\\VirtualBox VMs";
			this.saveFileDialog1.Title = "Choose a location for the new virtual hard disk file";
			// 
			// commandPanel
			// 
			this.commandPanel.AutoSize = true;
			this.commandPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.commandPanel.BackColor = System.Drawing.SystemColors.Control;
			this.commandPanel.ColumnCount = 2;
			this.commandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.commandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.commandPanel.Controls.Add(this.okBtn, 0, 1);
			this.commandPanel.Controls.Add(this.cancelBtn, 1, 1);
			this.commandPanel.Controls.Add(this.panel1, 0, 0);
			this.commandPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.commandPanel.Location = new System.Drawing.Point(0, 161);
			this.commandPanel.Margin = new System.Windows.Forms.Padding(0);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.RowCount = 2;
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.commandPanel.Size = new System.Drawing.Size(467, 46);
			this.commandPanel.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.commandPanel.SetColumnSpan(this.panel1, 2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 1);
			this.panel1.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.diskResizerCtrl1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(11);
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 161);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// diskResizerCtrl1
			// 
			this.diskResizerCtrl1.CurrentDiskSize = ((long)(536870912));
			this.diskResizerCtrl1.CurrentDiskUsed = ((long)(268435456));
			this.diskResizerCtrl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.diskResizerCtrl1.LargeChange = 8;
			this.diskResizerCtrl1.LimitThumbToSelection = true;
			this.diskResizerCtrl1.Location = new System.Drawing.Point(11, 76);
			this.diskResizerCtrl1.Margin = new System.Windows.Forms.Padding(0);
			this.diskResizerCtrl1.Maximum = 152;
			this.diskResizerCtrl1.Name = "diskResizerCtrl1";
			this.diskResizerCtrl1.NewDiskSize = ((long)(536870912));
			this.diskResizerCtrl1.OwnerDraw = true;
			this.diskResizerCtrl1.SelectionEnd = 152;
			this.diskResizerCtrl1.SelectionStart = 48;
			this.diskResizerCtrl1.ShowSelection = true;
			this.diskResizerCtrl1.Size = new System.Drawing.Size(445, 46);
			this.diskResizerCtrl1.TabIndex = 1;
			this.diskResizerCtrl1.TickFrequency = 8;
			this.diskResizerCtrl1.TickPositions = new int[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15,
        16,
        17,
        18};
			this.diskResizerCtrl1.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.diskResizerCtrl1.Value = 56;
			this.diskResizerCtrl1.ValueChanged += new System.EventHandler(this.diskResizerCtrl1_ValueChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
			this.tableLayoutPanel1.Controls.Add(this.minSize, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.curSize, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.newSize, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 122);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 23);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// minSize
			// 
			this.minSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.minSize.AutoSize = true;
			this.minSize.Location = new System.Drawing.Point(0, 0);
			this.minSize.Margin = new System.Windows.Forms.Padding(0);
			this.minSize.Name = "minSize";
			this.minSize.Size = new System.Drawing.Size(71, 23);
			this.minSize.TabIndex = 0;
			this.minSize.Text = "Min Size: {0}";
			this.minSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// curSize
			// 
			this.curSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.curSize.AutoSize = true;
			this.curSize.Location = new System.Drawing.Point(122, 0);
			this.curSize.Margin = new System.Windows.Forms.Padding(0);
			this.curSize.Name = "curSize";
			this.curSize.Size = new System.Drawing.Size(90, 23);
			this.curSize.TabIndex = 1;
			this.curSize.Text = "Current Size: {0}";
			this.curSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(244, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "New Size:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// newSize
			// 
			this.newSize.Dock = System.Windows.Forms.DockStyle.Top;
			this.newSize.Location = new System.Drawing.Point(308, 0);
			this.newSize.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.newSize.Name = "newSize";
			this.newSize.Size = new System.Drawing.Size(137, 23);
			this.newSize.TabIndex = 3;
			this.newSize.TextChanged += new System.EventHandler(this.newSize_TextChanged);
			// 
			// ResizeDlg
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(467, 207);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.commandPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ResizeDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Resize Virtual Hard Disk";
			this.groupBox1.ResumeLayout(false);
			this.commandPanel.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.diskResizerCtrl1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button diskOpenBtn;
		private System.Windows.Forms.ComboBox diskComboBox;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TableLayoutPanel commandPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private DiskResizerCtrl diskResizerCtrl1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label minSize;
		private System.Windows.Forms.Label curSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox newSize;
	}
}