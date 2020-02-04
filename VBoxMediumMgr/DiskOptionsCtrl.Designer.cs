namespace VBoxMediumMgr
{
	partial class DiskOptionsCtrl
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.dynamicRadioBtn = new System.Windows.Forms.RadioButton();
			this.fixedRadioBtn = new System.Windows.Forms.RadioButton();
			this.splitCheckBox = new System.Windows.Forms.CheckBox();
			this.fileTypeGroup = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.vdiRadioBtn = new System.Windows.Forms.RadioButton();
			this.vhdRadioBtn = new System.Windows.Forms.RadioButton();
			this.vmdkRadioBtn = new System.Windows.Forms.RadioButton();
			this.hddRadioBtn = new System.Windows.Forms.RadioButton();
			this.qcowRadioBtn = new System.Windows.Forms.RadioButton();
			this.qedRadioBtn = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.fileTypeGroup.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.AutoSize = true;
			this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox4.Controls.Add(this.flowLayoutPanel2);
			this.groupBox4.Location = new System.Drawing.Point(234, 0);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(7, 3, 7, 7);
			this.groupBox4.Size = new System.Drawing.Size(202, 93);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "&Storage on physical hard disk";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.dynamicRadioBtn);
			this.flowLayoutPanel2.Controls.Add(this.fixedRadioBtn);
			this.flowLayoutPanel2.Controls.Add(this.splitCheckBox);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 19);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(188, 67);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// dynamicRadioBtn
			// 
			this.dynamicRadioBtn.AutoSize = true;
			this.dynamicRadioBtn.Checked = true;
			this.dynamicRadioBtn.Location = new System.Drawing.Point(2, 2);
			this.dynamicRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.dynamicRadioBtn.Name = "dynamicRadioBtn";
			this.dynamicRadioBtn.Size = new System.Drawing.Size(141, 19);
			this.dynamicRadioBtn.TabIndex = 0;
			this.dynamicRadioBtn.TabStop = true;
			this.dynamicRadioBtn.Text = "Dynamically &allocated";
			this.dynamicRadioBtn.UseVisualStyleBackColor = true;
			// 
			// fixedRadioBtn
			// 
			this.fixedRadioBtn.AutoSize = true;
			this.fixedRadioBtn.Location = new System.Drawing.Point(2, 25);
			this.fixedRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.fixedRadioBtn.Name = "fixedRadioBtn";
			this.fixedRadioBtn.Size = new System.Drawing.Size(74, 19);
			this.fixedRadioBtn.TabIndex = 1;
			this.fixedRadioBtn.Text = "&Fixed size";
			this.fixedRadioBtn.UseVisualStyleBackColor = true;
			// 
			// splitCheckBox
			// 
			this.splitCheckBox.AutoSize = true;
			this.splitCheckBox.Enabled = false;
			this.splitCheckBox.Location = new System.Drawing.Point(2, 48);
			this.splitCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this.splitCheckBox.Name = "splitCheckBox";
			this.splitCheckBox.Size = new System.Drawing.Size(184, 19);
			this.splitCheckBox.TabIndex = 2;
			this.splitCheckBox.Text = "S&plit into files of less than 2GB";
			this.splitCheckBox.UseVisualStyleBackColor = true;
			// 
			// fileTypeGroup
			// 
			this.fileTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileTypeGroup.AutoSize = true;
			this.fileTypeGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fileTypeGroup.Controls.Add(this.flowLayoutPanel1);
			this.fileTypeGroup.Location = new System.Drawing.Point(0, 0);
			this.fileTypeGroup.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.fileTypeGroup.Name = "fileTypeGroup";
			this.fileTypeGroup.Padding = new System.Windows.Forms.Padding(7, 3, 7, 7);
			this.fileTypeGroup.Size = new System.Drawing.Size(224, 162);
			this.fileTypeGroup.TabIndex = 0;
			this.fileTypeGroup.TabStop = false;
			this.fileTypeGroup.Text = "Hard disk &file type";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.vdiRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.vhdRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.vmdkRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.hddRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.qcowRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.qedRadioBtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 19);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 136);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// vdiRadioBtn
			// 
			this.vdiRadioBtn.AutoSize = true;
			this.vdiRadioBtn.Checked = true;
			this.vdiRadioBtn.Location = new System.Drawing.Point(2, 2);
			this.vdiRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.vdiRadioBtn.Name = "vdiRadioBtn";
			this.vdiRadioBtn.Size = new System.Drawing.Size(168, 19);
			this.vdiRadioBtn.TabIndex = 0;
			this.vdiRadioBtn.TabStop = true;
			this.vdiRadioBtn.Text = "&VDI (VirtualBox Disk Image)";
			this.vdiRadioBtn.UseVisualStyleBackColor = true;
			this.vdiRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// vhdRadioBtn
			// 
			this.vhdRadioBtn.AutoSize = true;
			this.vhdRadioBtn.Location = new System.Drawing.Point(2, 25);
			this.vhdRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.vhdRadioBtn.Name = "vhdRadioBtn";
			this.vhdRadioBtn.Size = new System.Drawing.Size(148, 19);
			this.vhdRadioBtn.TabIndex = 1;
			this.vhdRadioBtn.Text = "VH&D (Virtual Hard Disk)";
			this.vhdRadioBtn.UseVisualStyleBackColor = true;
			this.vhdRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// vmdkRadioBtn
			// 
			this.vmdkRadioBtn.AutoSize = true;
			this.vmdkRadioBtn.Location = new System.Drawing.Point(2, 48);
			this.vmdkRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.vmdkRadioBtn.Name = "vmdkRadioBtn";
			this.vmdkRadioBtn.Size = new System.Drawing.Size(177, 19);
			this.vmdkRadioBtn.TabIndex = 2;
			this.vmdkRadioBtn.Text = "V&MDK (Virtual Machine Disk)";
			this.vmdkRadioBtn.UseVisualStyleBackColor = true;
			this.vmdkRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// hddRadioBtn
			// 
			this.hddRadioBtn.AutoSize = true;
			this.hddRadioBtn.Location = new System.Drawing.Point(2, 71);
			this.hddRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.hddRadioBtn.Name = "hddRadioBtn";
			this.hddRadioBtn.Size = new System.Drawing.Size(158, 19);
			this.hddRadioBtn.TabIndex = 3;
			this.hddRadioBtn.Text = "HDD (&Parallels Hard Disk)";
			this.hddRadioBtn.UseVisualStyleBackColor = true;
			this.hddRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// qcowRadioBtn
			// 
			this.qcowRadioBtn.AutoSize = true;
			this.qcowRadioBtn.Location = new System.Drawing.Point(2, 94);
			this.qcowRadioBtn.Margin = new System.Windows.Forms.Padding(2);
			this.qcowRadioBtn.Name = "qcowRadioBtn";
			this.qcowRadioBtn.Size = new System.Drawing.Size(192, 19);
			this.qcowRadioBtn.TabIndex = 4;
			this.qcowRadioBtn.Text = "&QCOW (QEMU Copy-On-Write)";
			this.qcowRadioBtn.UseVisualStyleBackColor = true;
			this.qcowRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// qedRadioBtn
			// 
			this.qedRadioBtn.AutoSize = true;
			this.qedRadioBtn.Location = new System.Drawing.Point(2, 117);
			this.qedRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this.qedRadioBtn.Name = "qedRadioBtn";
			this.qedRadioBtn.Size = new System.Drawing.Size(173, 19);
			this.qedRadioBtn.TabIndex = 5;
			this.qedRadioBtn.Text = "Q&ED (QEMU Enhanced Disk)";
			this.qedRadioBtn.UseVisualStyleBackColor = true;
			this.qedRadioBtn.CheckedChanged += new System.EventHandler(this.FileTypeCheckedChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.fileTypeGroup, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 167);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// DiskOptionsCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Name = "DiskOptionsCtrl";
			this.Size = new System.Drawing.Size(436, 167);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.fileTypeGroup.ResumeLayout(false);
			this.fileTypeGroup.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox splitCheckBox;
		private System.Windows.Forms.RadioButton fixedRadioBtn;
		private System.Windows.Forms.RadioButton dynamicRadioBtn;
		private System.Windows.Forms.GroupBox fileTypeGroup;
		private System.Windows.Forms.RadioButton qedRadioBtn;
		private System.Windows.Forms.RadioButton qcowRadioBtn;
		private System.Windows.Forms.RadioButton hddRadioBtn;
		private System.Windows.Forms.RadioButton vmdkRadioBtn;
		private System.Windows.Forms.RadioButton vhdRadioBtn;
		private System.Windows.Forms.RadioButton vdiRadioBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
