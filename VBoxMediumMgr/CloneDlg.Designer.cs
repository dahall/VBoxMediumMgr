namespace VBoxMediumMgr
{
	partial class CloneDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloneDlg));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.diskOpenBtn = new System.Windows.Forms.Button();
			this.diskComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fileTextBox = new System.Windows.Forms.TextBox();
			this.fileSaveBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.diskOptionsCtrl = new VBoxMediumMgr.DiskOptionsCtrl();
			this.commandPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.commandPanel.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.groupBox1.Text = "&Hard disk to clone";
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
			this.diskOpenBtn.Click += new System.EventHandler(this.diskOpenBtn_Click);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.fileTextBox);
			this.groupBox2.Controls.Add(this.fileSaveBtn);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(11, 76);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(445, 55);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "&New hard disk to create";
			// 
			// fileTextBox
			// 
			this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileTextBox.Location = new System.Drawing.Point(9, 22);
			this.fileTextBox.Name = "fileTextBox";
			this.fileTextBox.Size = new System.Drawing.Size(398, 23);
			this.fileTextBox.TabIndex = 2;
			this.fileTextBox.TextChanged += new System.EventHandler(this.fileTextBox_TextChanged);
			// 
			// fileSaveBtn
			// 
			this.fileSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fileSaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("fileSaveBtn.Image")));
			this.fileSaveBtn.Location = new System.Drawing.Point(413, 22);
			this.fileSaveBtn.Name = "fileSaveBtn";
			this.fileSaveBtn.Size = new System.Drawing.Size(23, 23);
			this.fileSaveBtn.TabIndex = 1;
			this.fileSaveBtn.UseVisualStyleBackColor = true;
			this.fileSaveBtn.Click += new System.EventHandler(this.fileSaveBtn_Click);
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
			this.okBtn.Text = "Clone";
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
			// diskOptionsCtrl
			// 
			this.diskOptionsCtrl.Dock = System.Windows.Forms.DockStyle.Top;
			this.diskOptionsCtrl.FileType = VBoxMediumMgr.HDFileType.VDI;
			this.diskOptionsCtrl.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.diskOptionsCtrl.Location = new System.Drawing.Point(11, 141);
			this.diskOptionsCtrl.Margin = new System.Windows.Forms.Padding(0);
			this.diskOptionsCtrl.Name = "diskOptionsCtrl";
			this.diskOptionsCtrl.Size = new System.Drawing.Size(445, 163);
			this.diskOptionsCtrl.TabIndex = 3;
			this.diskOptionsCtrl.FileTypeChanged += new System.EventHandler(this.diskOptionsCtrl_FileTypeChanged);
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
			this.commandPanel.Location = new System.Drawing.Point(0, 315);
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
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.diskOptionsCtrl, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(11);
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 315);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// CloneDlg
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(467, 361);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.commandPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CloneDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Clone Virtual Hard Disk";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.commandPanel.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button diskOpenBtn;
		private System.Windows.Forms.ComboBox diskComboBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button fileSaveBtn;
		private System.Windows.Forms.TextBox fileTextBox;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private DiskOptionsCtrl diskOptionsCtrl;
		private System.Windows.Forms.TableLayoutPanel commandPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}