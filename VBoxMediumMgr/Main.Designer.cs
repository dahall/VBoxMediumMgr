namespace VBoxMediumMgr
{
	partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.diskListView = new System.Windows.Forms.ListView();
			this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.stateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.vsizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.asizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.diskTypeTextBox = new System.Windows.Forms.TextBox();
			this.copyMenuItem2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.diskLocTextBox = new System.Windows.Forms.TextBox();
			this.locationContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFldrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.diskFmtTextBox = new System.Windows.Forms.TextBox();
			this.diskDetailTextBox = new System.Windows.Forms.TextBox();
			this.diskHostTextBox = new System.Windows.Forms.TextBox();
			this.attachContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.diskEncrTextBox = new System.Windows.Forms.TextBox();
			this.diskUuidTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.diskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.actionProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.actionCancelBtn = new System.Windows.Forms.ToolStripStatusLabel();
			this.actionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.compactCmd = new VBoxMediumMgr.Command();
			this.cloneCmd = new VBoxMediumMgr.Command();
			this.createCmd = new VBoxMediumMgr.Command();
			this.modifyCmd = new VBoxMediumMgr.Command();
			this.moveCmd = new VBoxMediumMgr.Command();
			this.removeCmd = new VBoxMediumMgr.Command();
			this.releaseCmd = new VBoxMediumMgr.Command();
			this.refreshCmd = new VBoxMediumMgr.Command();
			this.resizeCmd = new VBoxMediumMgr.Command();
			this.commandBindings1 = new VBoxMediumMgr.CommandBindings(this.components);
			this.addCmd = new VBoxMediumMgr.Command();
			this.cmdImageList = new System.Windows.Forms.ImageList(this.components);
			this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.copyMenuItem2.SuspendLayout();
			this.locationContextMenu.SuspendLayout();
			this.attachContextMenu.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel2);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(687, 397);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(687, 472);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(687, 22);
			this.statusStrip1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.diskListView, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8);
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(687, 397);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// diskListView
			// 
			this.diskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.nameCol,
			this.stateCol,
			this.vsizeCol,
			this.asizeCol});
			this.diskListView.ContextMenuStrip = this.contextMenuStrip1;
			this.diskListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.diskListView.FullRowSelect = true;
			this.diskListView.HideSelection = false;
			this.diskListView.Location = new System.Drawing.Point(11, 12);
			this.diskListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.diskListView.Name = "diskListView";
			this.diskListView.Size = new System.Drawing.Size(665, 211);
			this.diskListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.diskListView.TabIndex = 0;
			this.diskListView.UseCompatibleStateImageBehavior = false;
			this.diskListView.View = System.Windows.Forms.View.Details;
			this.diskListView.SelectedIndexChanged += new System.EventHandler(this.diskListView_SelectedIndexChanged);
			this.diskListView.ClientSizeChanged += new System.EventHandler(this.diskListView_ClientSizeChanged);
			// 
			// nameCol
			// 
			this.nameCol.Text = "Name";
			this.nameCol.Width = 451;
			// 
			// stateCol
			// 
			this.stateCol.Text = "State";
			// 
			// vsizeCol
			// 
			this.vsizeCol.Text = "Virtual Size";
			this.vsizeCol.Width = 70;
			// 
			// asizeCol
			// 
			this.asizeCol.Text = "Actual Size";
			this.asizeCol.Width = 76;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.diskTypeTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.diskLocTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.diskFmtTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.diskDetailTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.diskHostTextBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.diskEncrTextBox, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.diskUuidTextBox, 1, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 227);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 162);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// diskTypeTextBox
			// 
			this.diskTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskTypeTextBox.ContextMenuStrip = this.copyMenuItem2;
			this.diskTypeTextBox.Location = new System.Drawing.Point(143, 9);
			this.diskTypeTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskTypeTextBox.Name = "diskTypeTextBox";
			this.diskTypeTextBox.ReadOnly = true;
			this.diskTypeTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskTypeTextBox.TabIndex = 0;
			this.diskTypeTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// copyMenuItem2
			// 
			this.copyMenuItem2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.copyMenuItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyToolStripMenuItem});
			this.copyMenuItem2.Name = "copyContextMenu";
			this.copyMenuItem2.Size = new System.Drawing.Size(164, 28);
			this.copyMenuItem2.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Location:";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 53);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Format:";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 75);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Storage details:";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(0, 97);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Attached to:";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(0, 119);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Encrypted with key:";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 141);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "UUID:";
			// 
			// diskLocTextBox
			// 
			this.diskLocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskLocTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskLocTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskLocTextBox.ContextMenuStrip = this.locationContextMenu;
			this.diskLocTextBox.Location = new System.Drawing.Point(143, 31);
			this.diskLocTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskLocTextBox.Name = "diskLocTextBox";
			this.diskLocTextBox.ReadOnly = true;
			this.diskLocTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskLocTextBox.TabIndex = 1;
			this.diskLocTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// locationContextMenu
			// 
			this.locationContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.locationContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyMenuItem,
			this.openFldrMenuItem});
			this.locationContextMenu.Name = "copyContextMenu";
			this.locationContextMenu.Size = new System.Drawing.Size(198, 52);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Name = "copyMenuItem";
			this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyMenuItem.Size = new System.Drawing.Size(197, 24);
			this.copyMenuItem.Text = "&Copy";
			this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// openFldrMenuItem
			// 
			this.openFldrMenuItem.Name = "openFldrMenuItem";
			this.openFldrMenuItem.Size = new System.Drawing.Size(197, 24);
			this.openFldrMenuItem.Text = "&Open file location";
			this.openFldrMenuItem.Click += new System.EventHandler(this.openFldrMenuItem_Click);
			// 
			// diskFmtTextBox
			// 
			this.diskFmtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskFmtTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskFmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskFmtTextBox.ContextMenuStrip = this.copyMenuItem2;
			this.diskFmtTextBox.Location = new System.Drawing.Point(143, 53);
			this.diskFmtTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskFmtTextBox.Name = "diskFmtTextBox";
			this.diskFmtTextBox.ReadOnly = true;
			this.diskFmtTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskFmtTextBox.TabIndex = 2;
			this.diskFmtTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// diskDetailTextBox
			// 
			this.diskDetailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskDetailTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskDetailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskDetailTextBox.ContextMenuStrip = this.copyMenuItem2;
			this.diskDetailTextBox.Location = new System.Drawing.Point(143, 75);
			this.diskDetailTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskDetailTextBox.Name = "diskDetailTextBox";
			this.diskDetailTextBox.ReadOnly = true;
			this.diskDetailTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskDetailTextBox.TabIndex = 3;
			this.diskDetailTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// diskHostTextBox
			// 
			this.diskHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskHostTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskHostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskHostTextBox.ContextMenuStrip = this.attachContextMenu;
			this.diskHostTextBox.Location = new System.Drawing.Point(143, 97);
			this.diskHostTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskHostTextBox.Name = "diskHostTextBox";
			this.diskHostTextBox.ReadOnly = true;
			this.diskHostTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskHostTextBox.TabIndex = 4;
			this.diskHostTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// attachContextMenu
			// 
			this.attachContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.attachContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyMenuItem1,
			this.startMenuItem});
			this.attachContextMenu.Name = "copyContextMenu";
			this.attachContextMenu.Size = new System.Drawing.Size(164, 52);
			// 
			// copyMenuItem1
			// 
			this.copyMenuItem1.Name = "copyMenuItem1";
			this.copyMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyMenuItem1.Size = new System.Drawing.Size(163, 24);
			this.copyMenuItem1.Text = "&Copy";
			this.copyMenuItem1.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// startMenuItem
			// 
			this.startMenuItem.Name = "startMenuItem";
			this.startMenuItem.Size = new System.Drawing.Size(163, 24);
			this.startMenuItem.Text = "&Start";
			this.startMenuItem.Click += new System.EventHandler(this.startMenuItem_Click);
			// 
			// diskEncrTextBox
			// 
			this.diskEncrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskEncrTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskEncrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskEncrTextBox.ContextMenuStrip = this.copyMenuItem2;
			this.diskEncrTextBox.Location = new System.Drawing.Point(143, 119);
			this.diskEncrTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskEncrTextBox.Name = "diskEncrTextBox";
			this.diskEncrTextBox.ReadOnly = true;
			this.diskEncrTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskEncrTextBox.TabIndex = 5;
			this.diskEncrTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// diskUuidTextBox
			// 
			this.diskUuidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.diskUuidTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.diskUuidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskUuidTextBox.ContextMenuStrip = this.copyMenuItem2;
			this.diskUuidTextBox.Location = new System.Drawing.Point(143, 141);
			this.diskUuidTextBox.Margin = new System.Windows.Forms.Padding(7, 1, 0, 1);
			this.diskUuidTextBox.Name = "diskUuidTextBox";
			this.diskUuidTextBox.ReadOnly = true;
			this.diskUuidTextBox.Size = new System.Drawing.Size(528, 20);
			this.diskUuidTextBox.TabIndex = 6;
			this.diskUuidTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.diskToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(687, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// diskToolStripMenuItem
			// 
			this.diskToolStripMenuItem.Name = "diskToolStripMenuItem";
			this.diskToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.diskToolStripMenuItem.Text = "Disk";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(3, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(111, 25);
			this.toolStrip1.TabIndex = 1;
			// 
			// actionLabel
			// 
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(48, 17);
			this.actionLabel.Text = "[action]";
			this.actionLabel.Visible = false;
			// 
			// actionProgress
			// 
			this.actionProgress.Name = "actionProgress";
			this.actionProgress.Size = new System.Drawing.Size(100, 16);
			this.actionProgress.Visible = false;
			// 
			// actionCancelBtn
			// 
			this.actionCancelBtn.IsLink = true;
			this.actionCancelBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.actionCancelBtn.Name = "actionCancelBtn";
			this.actionCancelBtn.Size = new System.Drawing.Size(43, 17);
			this.actionCancelBtn.Text = "Cancel";
			this.actionCancelBtn.Visible = false;
			this.actionCancelBtn.Click += new System.EventHandler(this.actionCancelBtn_ButtonClick);
			// 
			// actionStatusLabel
			// 
			this.actionStatusLabel.Name = "actionStatusLabel";
			this.actionStatusLabel.Size = new System.Drawing.Size(46, 17);
			this.actionStatusLabel.Text = "[status]";
			this.actionStatusLabel.Visible = false;
			// 
			// compactCmd
			// 
			this.compactCmd.ImageIndex = 1;
			this.compactCmd.Text = "Compact";
			this.compactCmd.ToolTipText = "Compact the physical space required by the virtual disk";
			this.compactCmd.Click += new System.EventHandler(this.compactCmd_Click);
			// 
			// cloneCmd
			// 
			this.cloneCmd.ImageIndex = 2;
			this.cloneCmd.Text = "Clone";
			this.cloneCmd.ToolTipText = "Clone this virtual disk and optionally change its format";
			this.cloneCmd.Click += new System.EventHandler(this.cloneCmd_Click);
			// 
			// createCmd
			// 
			this.createCmd.ImageIndex = 3;
			this.createCmd.Text = "Create";
			this.createCmd.ToolTipText = "Create a new virtual disk";
			this.createCmd.Click += new System.EventHandler(this.createCmd_Click);
			// 
			// modifyCmd
			// 
			this.modifyCmd.ImageIndex = 4;
			this.modifyCmd.Text = "Modify";
			this.modifyCmd.ToolTipText = "Modify the capabilities of an existing virtual disk";
			this.modifyCmd.Click += new System.EventHandler(this.modifyCmd_Click);
			// 
			// moveCmd
			// 
			this.moveCmd.ImageIndex = 5;
			this.moveCmd.Text = "Move";
			this.moveCmd.ToolTipText = "Relocate the virtual disk to another folder";
			this.moveCmd.Click += new System.EventHandler(this.moveCmd_Click);
			// 
			// removeCmd
			// 
			this.removeCmd.ImageIndex = 8;
			this.removeCmd.Text = "Remove";
			this.removeCmd.ToolTipText = "Disconnect the disk and delete it permanently";
			this.removeCmd.Click += new System.EventHandler(this.removeCmd_Click);
			// 
			// releaseCmd
			// 
			this.releaseCmd.ImageIndex = 7;
			this.releaseCmd.Text = "Release";
			this.releaseCmd.ToolTipText = "Disconnect this disk from all attached machines";
			this.releaseCmd.Click += new System.EventHandler(this.releaseCmd_Click);
			// 
			// refreshCmd
			// 
			this.refreshCmd.ImageIndex = 6;
			this.refreshCmd.Text = "Refresh";
			this.refreshCmd.ToolTipText = "Refresh the listing of virtual disks under management";
			this.refreshCmd.Click += new System.EventHandler(this.refreshCmd_Click);
			// 
			// resizeCmd
			// 
			this.resizeCmd.ImageIndex = 9;
			this.resizeCmd.Text = "Resize";
			this.resizeCmd.ToolTipText = "Resize the virtual space available for this virtual disk";
			this.resizeCmd.Click += new System.EventHandler(this.resizeCmd_Click);
			// 
			// commandBindings1
			// 
			this.commandBindings1.Commands.Add(this.addCmd);
			this.commandBindings1.Commands.Add(this.compactCmd);
			this.commandBindings1.Commands.Add(this.cloneCmd);
			this.commandBindings1.Commands.Add(this.createCmd);
			this.commandBindings1.Commands.Add(this.modifyCmd);
			this.commandBindings1.Commands.Add(this.moveCmd);
			this.commandBindings1.Commands.Add(this.removeCmd);
			this.commandBindings1.Commands.Add(this.releaseCmd);
			this.commandBindings1.Commands.Add(this.refreshCmd);
			this.commandBindings1.Commands.Add(this.resizeCmd);
			this.commandBindings1.ImageList = this.cmdImageList;
			// 
			// addCmd
			// 
			this.addCmd.ImageIndex = 0;
			this.addCmd.Text = "Add";
			this.addCmd.ToolTipText = "Add an existing virtual disk";
			this.addCmd.Click += new System.EventHandler(this.addCmd_Click);
			// 
			// cmdImageList
			// 
			this.cmdImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cmdImageList.ImageStream")));
			this.cmdImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.cmdImageList.Images.SetKeyName(0, "add.ico");
			this.cmdImageList.Images.SetKeyName(1, "compress.ico");
			this.cmdImageList.Images.SetKeyName(2, "copy.ico");
			this.cmdImageList.Images.SetKeyName(3, "create.ico");
			this.cmdImageList.Images.SetKeyName(4, "modify.ico");
			this.cmdImageList.Images.SetKeyName(5, "move.ico");
			this.cmdImageList.Images.SetKeyName(6, "refresh.ico");
			this.cmdImageList.Images.SetKeyName(7, "release.ico");
			this.cmdImageList.Images.SetKeyName(8, "remove.ico");
			this.cmdImageList.Images.SetKeyName(9, "resize.ico");
			// 
			// openFileDlg
			// 
			this.openFileDlg.Filter = "Virtual disks|*.vdi;*.vhd;*.vmdk;*.hdd;*.qcow;*.qed|All files|*.*";
			this.openFileDlg.Title = "Add virtual media";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 472);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Main";
			this.Text = "Virtual Media Manager";
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.copyMenuItem2.ResumeLayout(false);
			this.locationContextMenu.ResumeLayout(false);
			this.attachContextMenu.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ListView diskListView;
		private System.Windows.Forms.ColumnHeader nameCol;
		private System.Windows.Forms.ColumnHeader vsizeCol;
		private System.Windows.Forms.ColumnHeader asizeCol;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox diskTypeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox diskLocTextBox;
		private System.Windows.Forms.TextBox diskFmtTextBox;
		private System.Windows.Forms.TextBox diskDetailTextBox;
		private System.Windows.Forms.TextBox diskHostTextBox;
		private System.Windows.Forms.TextBox diskEncrTextBox;
		private System.Windows.Forms.TextBox diskUuidTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripStatusLabel actionLabel;
		private System.Windows.Forms.ToolStripProgressBar actionProgress;
		private System.Windows.Forms.ToolStripStatusLabel actionStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel actionCancelBtn;
		private System.Windows.Forms.ColumnHeader stateCol;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip copyMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private CommandBindings commandBindings1;
		private Command compactCmd;
		private Command cloneCmd;
		private Command createCmd;
		private Command modifyCmd;
		private Command moveCmd;
		private Command removeCmd;
		private Command releaseCmd;
		private Command refreshCmd;
		private Command resizeCmd;
		private System.Windows.Forms.ToolStripMenuItem diskToolStripMenuItem;
		private Command addCmd;
		private System.Windows.Forms.ContextMenuStrip attachContextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem startMenuItem;
		private System.Windows.Forms.ImageList cmdImageList;
		private System.Windows.Forms.ContextMenuStrip locationContextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFldrMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
	}
}