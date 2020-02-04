using VirtualBox;

namespace VBoxMediumMgr
{
	partial class ModifyDlg
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.instrText = new System.Windows.Forms.RichTextBox();
			this.notificationText = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.normalRadioBtn = new System.Windows.Forms.RadioButton();
			this.immutableRadioBtn = new System.Windows.Forms.RadioButton();
			this.writethroughRadioBtn = new System.Windows.Forms.RadioButton();
			this.shareableRadioBtn = new System.Windows.Forms.RadioButton();
			this.multiRadioBtn = new System.Windows.Forms.RadioButton();
			this.modeHelpText = new System.Windows.Forms.TextBox();
			this.commandPanel = new System.Windows.Forms.TableLayoutPanel();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.commandPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.instrText, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.notificationText, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(11);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 274);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// instrText
			// 
			this.instrText.BackColor = System.Drawing.SystemColors.Window;
			this.instrText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.instrText.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.instrText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.instrText.Location = new System.Drawing.Point(11, 68);
			this.instrText.Margin = new System.Windows.Forms.Padding(0);
			this.instrText.Name = "instrText";
			this.instrText.ReadOnly = true;
			this.instrText.Size = new System.Drawing.Size(404, 41);
			this.instrText.TabIndex = 1;
			this.instrText.Text = "Please choose one of the following modes and press OK to proceed or Cancel otherw" +
    "ise.";
			// 
			// notificationText
			// 
			this.notificationText.BackColor = System.Drawing.SystemColors.Window;
			this.notificationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.notificationText.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.notificationText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notificationText.Location = new System.Drawing.Point(11, 11);
			this.notificationText.Margin = new System.Windows.Forms.Padding(0);
			this.notificationText.Name = "notificationText";
			this.notificationText.ReadOnly = true;
			this.notificationText.Size = new System.Drawing.Size(404, 57);
			this.notificationText.TabIndex = 0;
			this.notificationText.Text = "You are about to change the settings of the disk image file {0}.\nX\nX";
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(11, 109);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 3, 9, 9);
			this.groupBox1.Size = new System.Drawing.Size(404, 154);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose mode:";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.modeHelpText, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 19);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 124);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.normalRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.immutableRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.writethroughRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.shareableRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.multiRadioBtn);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 125);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// normalRadioBtn
			// 
			this.normalRadioBtn.AutoSize = true;
			this.normalRadioBtn.Checked = true;
			this.normalRadioBtn.Location = new System.Drawing.Point(3, 3);
			this.normalRadioBtn.Name = "normalRadioBtn";
			this.normalRadioBtn.Size = new System.Drawing.Size(65, 19);
			this.normalRadioBtn.TabIndex = 1;
			this.normalRadioBtn.TabStop = true;
			this.normalRadioBtn.Tag = VirtualBox.MediumType.MediumType_Normal;
			this.normalRadioBtn.Text = "Normal";
			this.normalRadioBtn.UseVisualStyleBackColor = true;
			this.normalRadioBtn.CheckedChanged += new System.EventHandler(this.ModeCheckChanged);
			// 
			// immutableRadioBtn
			// 
			this.immutableRadioBtn.AutoSize = true;
			this.immutableRadioBtn.Location = new System.Drawing.Point(3, 28);
			this.immutableRadioBtn.Name = "immutableRadioBtn";
			this.immutableRadioBtn.Size = new System.Drawing.Size(83, 19);
			this.immutableRadioBtn.TabIndex = 2;
			this.immutableRadioBtn.TabStop = true;
			this.immutableRadioBtn.Tag = VirtualBox.MediumType.MediumType_Immutable;
			this.immutableRadioBtn.Text = "Immutable";
			this.immutableRadioBtn.UseVisualStyleBackColor = true;
			this.immutableRadioBtn.CheckedChanged += new System.EventHandler(this.ModeCheckChanged);
			// 
			// writethroughRadioBtn
			// 
			this.writethroughRadioBtn.AutoSize = true;
			this.writethroughRadioBtn.Location = new System.Drawing.Point(3, 53);
			this.writethroughRadioBtn.Name = "writethroughRadioBtn";
			this.writethroughRadioBtn.Size = new System.Drawing.Size(96, 19);
			this.writethroughRadioBtn.TabIndex = 2;
			this.writethroughRadioBtn.TabStop = true;
			this.writethroughRadioBtn.Tag = VirtualBox.MediumType.MediumType_Writethrough;
			this.writethroughRadioBtn.Text = "Writethrough";
			this.writethroughRadioBtn.UseVisualStyleBackColor = true;
			this.writethroughRadioBtn.CheckedChanged += new System.EventHandler(this.ModeCheckChanged);
			// 
			// shareableRadioBtn
			// 
			this.shareableRadioBtn.AutoSize = true;
			this.shareableRadioBtn.Location = new System.Drawing.Point(3, 78);
			this.shareableRadioBtn.Name = "shareableRadioBtn";
			this.shareableRadioBtn.Size = new System.Drawing.Size(76, 19);
			this.shareableRadioBtn.TabIndex = 2;
			this.shareableRadioBtn.TabStop = true;
			this.shareableRadioBtn.Tag = VirtualBox.MediumType.MediumType_Shareable;
			this.shareableRadioBtn.Text = "Shareable";
			this.shareableRadioBtn.UseVisualStyleBackColor = true;
			this.shareableRadioBtn.CheckedChanged += new System.EventHandler(this.ModeCheckChanged);
			// 
			// multiRadioBtn
			// 
			this.multiRadioBtn.AutoSize = true;
			this.multiRadioBtn.Location = new System.Drawing.Point(3, 103);
			this.multiRadioBtn.Name = "multiRadioBtn";
			this.multiRadioBtn.Size = new System.Drawing.Size(91, 19);
			this.multiRadioBtn.TabIndex = 2;
			this.multiRadioBtn.TabStop = true;
			this.multiRadioBtn.Tag = VirtualBox.MediumType.MediumType_MultiAttach;
			this.multiRadioBtn.Text = "Multi-attach";
			this.multiRadioBtn.UseVisualStyleBackColor = true;
			this.multiRadioBtn.CheckedChanged += new System.EventHandler(this.ModeCheckChanged);
			// 
			// modeHelpText
			// 
			this.modeHelpText.BackColor = System.Drawing.SystemColors.Window;
			this.modeHelpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.modeHelpText.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.modeHelpText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modeHelpText.Location = new System.Drawing.Point(112, 3);
			this.modeHelpText.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
			this.modeHelpText.Multiline = true;
			this.modeHelpText.Name = "modeHelpText";
			this.modeHelpText.ReadOnly = true;
			this.modeHelpText.Size = new System.Drawing.Size(276, 119);
			this.modeHelpText.TabIndex = 0;
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
			this.commandPanel.Location = new System.Drawing.Point(0, 274);
			this.commandPanel.Margin = new System.Windows.Forms.Padding(0);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.RowCount = 2;
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.commandPanel.Size = new System.Drawing.Size(426, 46);
			this.commandPanel.TabIndex = 5;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okBtn.Enabled = false;
			this.okBtn.Location = new System.Drawing.Point(258, 12);
			this.okBtn.Margin = new System.Windows.Forms.Padding(11, 11, 7, 11);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(340, 12);
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
			this.panel1.Size = new System.Drawing.Size(426, 1);
			this.panel1.TabIndex = 3;
			// 
			// ModifyDlg
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(426, 320);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.commandPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ModifyDlg";
			this.Text = "Modify medium attributes";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.commandPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RichTextBox instrText;
		private System.Windows.Forms.RichTextBox notificationText;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton multiRadioBtn;
		private System.Windows.Forms.RadioButton shareableRadioBtn;
		private System.Windows.Forms.RadioButton writethroughRadioBtn;
		private System.Windows.Forms.RadioButton immutableRadioBtn;
		private System.Windows.Forms.RadioButton normalRadioBtn;
		private System.Windows.Forms.TextBox modeHelpText;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel commandPanel;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Panel panel1;
	}
}