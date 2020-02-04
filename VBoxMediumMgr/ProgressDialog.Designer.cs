namespace VBoxMediumMgr
{
	partial class ProgressDialog
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.statusLabel = new System.Windows.Forms.Label();
			this.commandPanel = new System.Windows.Forms.TableLayoutPanel();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.dividerPanel = new System.Windows.Forms.Panel();
			this.contentPanel = new System.Windows.Forms.TableLayoutPanel();
			this.macroStatusLabel = new System.Windows.Forms.Label();
			this.macroProgressBar = new System.Windows.Forms.ProgressBar();
			this.bodyPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.commandPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.bodyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBar.Location = new System.Drawing.Point(11, 75);
			this.progressBar.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(358, 9);
			this.progressBar.TabIndex = 0;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.statusLabel.Location = new System.Drawing.Point(11, 53);
			this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(358, 15);
			this.statusLabel.TabIndex = 1;
			this.statusLabel.Text = "[Status]";
			// 
			// commandPanel
			// 
			this.commandPanel.AutoSize = true;
			this.commandPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.commandPanel.BackColor = System.Drawing.SystemColors.Control;
			this.commandPanel.ColumnCount = 2;
			this.commandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.commandPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.commandPanel.Controls.Add(this.cancelBtn, 1, 1);
			this.commandPanel.Controls.Add(this.dividerPanel, 0, 0);
			this.commandPanel.Location = new System.Drawing.Point(0, 95);
			this.commandPanel.Margin = new System.Windows.Forms.Padding(0);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.RowCount = 2;
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
			this.commandPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.commandPanel.Size = new System.Drawing.Size(380, 46);
			this.commandPanel.TabIndex = 6;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(294, 12);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(0, 11, 11, 11);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 2;
			this.cancelBtn.Text = "&Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// dividerPanel
			// 
			this.dividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.commandPanel.SetColumnSpan(this.dividerPanel, 2);
			this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dividerPanel.Location = new System.Drawing.Point(0, 0);
			this.dividerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.dividerPanel.Name = "dividerPanel";
			this.dividerPanel.Size = new System.Drawing.Size(380, 1);
			this.dividerPanel.TabIndex = 3;
			// 
			// contentPanel
			// 
			this.contentPanel.AutoSize = true;
			this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.contentPanel.ColumnCount = 1;
			this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.contentPanel.Controls.Add(this.macroStatusLabel, 0, 0);
			this.contentPanel.Controls.Add(this.macroProgressBar, 0, 1);
			this.contentPanel.Controls.Add(this.statusLabel, 0, 2);
			this.contentPanel.Controls.Add(this.progressBar, 0, 3);
			this.contentPanel.Location = new System.Drawing.Point(0, 0);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Padding = new System.Windows.Forms.Padding(11);
			this.contentPanel.RowCount = 4;
			this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.contentPanel.Size = new System.Drawing.Size(380, 95);
			this.contentPanel.TabIndex = 7;
			// 
			// macroStatusLabel
			// 
			this.macroStatusLabel.AutoSize = true;
			this.macroStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.macroStatusLabel.Location = new System.Drawing.Point(11, 11);
			this.macroStatusLabel.Margin = new System.Windows.Forms.Padding(0);
			this.macroStatusLabel.Name = "macroStatusLabel";
			this.macroStatusLabel.Size = new System.Drawing.Size(358, 15);
			this.macroStatusLabel.TabIndex = 3;
			this.macroStatusLabel.Text = "[Status]";
			this.macroStatusLabel.Visible = false;
			// 
			// macroProgressBar
			// 
			this.macroProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.macroProgressBar.Location = new System.Drawing.Point(11, 33);
			this.macroProgressBar.Margin = new System.Windows.Forms.Padding(0, 7, 0, 11);
			this.macroProgressBar.Name = "macroProgressBar";
			this.macroProgressBar.Size = new System.Drawing.Size(358, 9);
			this.macroProgressBar.TabIndex = 2;
			this.macroProgressBar.Visible = false;
			// 
			// bodyPanel
			// 
			this.bodyPanel.AutoSize = true;
			this.bodyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bodyPanel.Controls.Add(this.contentPanel);
			this.bodyPanel.Controls.Add(this.commandPanel);
			this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.bodyPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.bodyPanel.Location = new System.Drawing.Point(0, 0);
			this.bodyPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bodyPanel.Name = "bodyPanel";
			this.bodyPanel.Size = new System.Drawing.Size(380, 141);
			this.bodyPanel.TabIndex = 8;
			this.bodyPanel.WrapContents = false;
			// 
			// ProgressDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(380, 191);
			this.ControlBox = false;
			this.Controls.Add(this.bodyPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProgressDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ProgressDialog";
			this.commandPanel.ResumeLayout(false);
			this.contentPanel.ResumeLayout(false);
			this.contentPanel.PerformLayout();
			this.bodyPanel.ResumeLayout(false);
			this.bodyPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.TableLayoutPanel commandPanel;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Panel dividerPanel;
		private System.Windows.Forms.TableLayoutPanel contentPanel;
		private System.Windows.Forms.Label macroStatusLabel;
		private System.Windows.Forms.ProgressBar macroProgressBar;
		private System.Windows.Forms.FlowLayoutPanel bodyPanel;
	}
}