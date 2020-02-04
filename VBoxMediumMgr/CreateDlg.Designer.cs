namespace VBoxMediumMgr
{
	partial class CreateDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDlg));
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fileSizeGroup = new System.Windows.Forms.GroupBox();
			this.diskSizer = new VBoxMediumMgr.DiskSizingCtrl();
			this.commandPanel = new System.Windows.Forms.TableLayoutPanel();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.fileTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.diskOptionsCtrl = new VBoxMediumMgr.DiskOptionsCtrl();
			this.fileSizeGroup.SuspendLayout();
			this.commandPanel.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "vdi";
			this.saveFileDialog1.Filter = resources.GetString("saveFileDialog1.Filter");
			this.saveFileDialog1.InitialDirectory = "%USERPROFILE%\\VirtualBox VMs";
			this.saveFileDialog1.Title = "Choose a location for the new virtual hard disk file";
			// 
			// fileSizeGroup
			// 
			this.fileSizeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileSizeGroup.Controls.Add(this.diskSizer);
			this.fileSizeGroup.Location = new System.Drawing.Point(11, 76);
			this.fileSizeGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.fileSizeGroup.Name = "fileSizeGroup";
			this.fileSizeGroup.Padding = new System.Windows.Forms.Padding(0);
			this.fileSizeGroup.Size = new System.Drawing.Size(429, 76);
			this.fileSizeGroup.TabIndex = 1;
			this.fileSizeGroup.TabStop = false;
			this.fileSizeGroup.Text = "File size";
			// 
			// diskSizer
			// 
			this.diskSizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.diskSizer.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.diskSizer.Location = new System.Drawing.Point(2, 20);
			this.diskSizer.Margin = new System.Windows.Forms.Padding(2);
			this.diskSizer.Name = "diskSizer";
			this.diskSizer.Size = new System.Drawing.Size(425, 49);
			this.diskSizer.TabIndex = 0;
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
			this.commandPanel.Location = new System.Drawing.Point(0, 335);
			this.commandPanel.Margin = new System.Windows.Forms.Padding(0);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.RowCount = 2;
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.commandPanel.Size = new System.Drawing.Size(451, 46);
			this.commandPanel.TabIndex = 5;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okBtn.Enabled = false;
			this.okBtn.Location = new System.Drawing.Point(283, 12);
			this.okBtn.Margin = new System.Windows.Forms.Padding(11, 11, 7, 11);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "Create";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(365, 12);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(0, 11, 11, 11);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 2;
			this.cancelBtn.Text = "&Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.commandPanel.SetColumnSpan(this.panel1, 2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(451, 1);
			this.panel1.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.diskOptionsCtrl, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.fileSizeGroup, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(11);
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 335);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.fileTextBox);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(11, 11);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(429, 55);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "&New hard disk to create";
			// 
			// fileTextBox
			// 
			this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileTextBox.Location = new System.Drawing.Point(9, 22);
			this.fileTextBox.Name = "fileTextBox";
			this.fileTextBox.Size = new System.Drawing.Size(382, 23);
			this.fileTextBox.TabIndex = 2;
			this.fileTextBox.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(397, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 23);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.fileSaveBtn_Click);
			// 
			// diskOptionsCtrl
			// 
			this.diskOptionsCtrl.Dock = System.Windows.Forms.DockStyle.Top;
			this.diskOptionsCtrl.FileType = VBoxMediumMgr.HDFileType.VDI;
			this.diskOptionsCtrl.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.diskOptionsCtrl.Location = new System.Drawing.Point(11, 162);
			this.diskOptionsCtrl.Margin = new System.Windows.Forms.Padding(0);
			this.diskOptionsCtrl.Name = "diskOptionsCtrl";
			this.diskOptionsCtrl.Size = new System.Drawing.Size(429, 163);
			this.diskOptionsCtrl.TabIndex = 3;
			// 
			// CreateDlg
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(451, 381);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.commandPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CreateDlg";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create new Virtual Hard Disk";
			this.fileSizeGroup.ResumeLayout(false);
			this.commandPanel.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.GroupBox fileSizeGroup;
		private DiskSizingCtrl diskSizer;
		private System.Windows.Forms.TableLayoutPanel commandPanel;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox fileTextBox;
		private System.Windows.Forms.Button button1;
		private DiskOptionsCtrl diskOptionsCtrl;
	}
}