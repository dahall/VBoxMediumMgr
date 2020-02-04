using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBox;
using VirtualBoxAPI;
using static Vanara.PInvoke.ShlwApi;

// ReSharper disable InconsistentNaming

namespace VBoxMediumMgr
{
	public enum HDFileType
	{
		VDI,
		VHD,
		VMDK,
		HDD,
		QCOW,
		QED
	}

	public partial class Main : Form
	{
		private static readonly List<DiskInfo> disks = new List<DiskInfo>();
		private readonly ManualResetEvent appClosing = new ManualResetEvent(false);
		private readonly ProgressDialog progressDlg = new ProgressDialog();
		private CancellationTokenSource cancelToken;
		private int sortColumn = -1;

		public Main()
		{
			InitializeComponent();

			// Generate menus and toolbars from commands
			commandBindings1.LoadMenuFromCommands(diskToolStripMenuItem.DropDownItems);
			commandBindings1.LoadMenuFromCommands(contextMenuStrip1.Items);
			commandBindings1.LoadToolStripFromCommands(toolStrip1.Items, TextImageRelation.ImageAboveText);

			progressDlg.Cancelled += ProgressDlg_Cancelled;
			diskListView.ColumnClick += DiskListViewOnColumnClick;
		}

		internal static IList<DiskInfo> Disks => disks;
		internal DiskInfo CurSel { get; set; }

		internal static HDFileType FileTypeFromPath(string path) => path != null && Enum.TryParse(Path.GetExtension(path).TrimStart('.'), true, out HDFileType res) ? res : HDFileType.VDI;

		internal static string GetDisplayString(MediumState st) => st.ToString().Replace("MediumState_", "");

		internal static string GetDisplayString(MediumType t) => t.ToString().Replace("MediumType_", "");

		internal static string SizeStr(long sz) => string.Format(ByteSizeFormatter.Instance, "{0:B2}", sz);

		internal void UpdateAction(string name, int progress, string status)
		{
			SetActionVisible(true);
			actionLabel.Text = name;
			actionProgress.Value = progress;
			actionStatusLabel.Text = status;
			if (progress == 100) SetActionVisible(false);
		}

		internal void UpdateProgress(string name, int progress, string status)
		{
			if (progress == 100)
			{
				SetProgressVisible(false);
			}
			else
			{
				SetProgressVisible(true);
				progressDlg.Text = name;
				progressDlg.PercentComplete = progress;
				progressDlg.StatusText = status;
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			appClosing.Set();
			base.OnClosing(e);
		}

		protected override void OnLoad(EventArgs e)
		{
			refreshCmd_Click(this, EventArgs.Empty);
			base.OnLoad(e);
		}

		private void actionCancelBtn_ButtonClick(object sender, EventArgs e) => cancelToken?.Cancel();

		private async void addCmd_Click(object sender, EventArgs e)
		{
			if (openFileDlg.ShowDialog(this) != DialogResult.OK) return;
			var m = Medium.OpenMedium(openFileDlg.FileName);
			m.Close();
			await RefreshList();
		}

		private async void cloneCmd_Click(object sender, EventArgs e)
		{
			if (CurSel == null) return;

			var newfn = Path.GetFileNameWithoutExtension(CurSel.Location) + "_Copy" + Path.GetExtension(CurSel.Location);
			var dlg = new CloneDlg(CurSel.UUID) { DestPath = newfn };
			if (dlg.ShowDialog(this) != DialogResult.OK) return;

			await RunAsync("Cloning", async (t, p) => await Medium.CloneAsync(CurSel.Location, dlg.DestPath, dlg.FileType, dlg.Dynamic, dlg.SplitFile, t, p));
			await RefreshList();
		}

		private async void compactCmd_Click(object sender, EventArgs e)
		{
			await RunMultiple(async di =>
			{
				if (di.Format == "VDI")
					await RunAsync("Compacting", async (t, p) => await Medium.CompactAsync(di.Location, t, p), di.UUID);
				else if (di.Format == "VHD")
					await RunAsync("Compacting", async (t, p) => await MSVirtualDisk.CompactVHD(di.Location, t, p), di.UUID);
				else
					MessageBox.Show(this, $"Unable to compact disks of type {di.Format}.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
			});
		}

		private void copyMenuItem_Click(object sender, EventArgs e)
		{
			var txt = (((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl as TextBox)?.Text;
			if (txt != null)
				Clipboard.SetText(txt);
		}

		private async void createCmd_Click(object sender, EventArgs e)
		{
			var dlg = new CreateDlg();
			if (dlg.ShowDialog(this) == DialogResult.Cancel) return;

			await RunAsyncAction("Creating", async (t, p) => await Medium.Create(dlg.Path, dlg.FileType, (long)dlg.FileSize, t, p, DeviceType.DeviceType_HardDisk, dlg.Dynamic, dlg.SplitFile));
			await RefreshList();
		}

		private void diskListView_ClientSizeChanged(object sender, EventArgs e) => SetColWidths();

		private void diskListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			var dil = diskListView.SelectedItems.Cast<ListViewItem>().Where(i => i.Tag is DiskInfo).Select(i => i.Tag as DiskInfo).ToList();
			var cnt = dil.Count;
			CurSel = null;

			// Set values for disk details based on selection
			if (cnt != 1)
			{
				diskDetailTextBox.Text =
					diskEncrTextBox.Text =
						diskFmtTextBox.Text =
							diskHostTextBox.Text =
								diskLocTextBox.Text = diskTypeTextBox.Text = diskUuidTextBox.Text = null;
			}
			else
			{
				CurSel = dil[0];
				diskDetailTextBox.Text = CurSel.Variant.ToString().Replace("MediumVariant_", "");
				diskEncrTextBox.Text = CurSel.EncryptionKey ?? "Not encrypted";
				//diskDetailTextBox.Font.Italic = di.EncryptionKey == null;
				diskFmtTextBox.Text = CurSel.Format;
				diskHostTextBox.Text = CurSel.AttachedTo;
				var sb = new StringBuilder(CurSel.Location);
				PathCompactPath(CreateGraphics().GetHdc(), sb, (uint)diskLocTextBox.Width);
				diskLocTextBox.Text = sb.ToString();
				diskTypeTextBox.Text = CurSel.MediumType.ToString().Remove(0, 11);
				diskUuidTextBox.Text = CurSel.UUID;
			}

			// Setup all of the commands based on conditions
			if (cnt == 0)
			{
				foreach (var c in commandBindings1.Commands)
					c.Enabled = false;
			}
			else
			{
				cloneCmd.Enabled = cnt == 1 && (CurSel.State == MediumState.MediumState_Created || CurSel.State == MediumState.MediumState_NotCreated);
				compactCmd.Enabled = dil.All(di => di.Format == "VDI" || di.Format == "VHD");
				removeCmd.Enabled = cnt == 1 && CurSel.State == MediumState.MediumState_Created && !CurSel.HasChildren;
				resizeCmd.Enabled = cnt == 1;
				moveCmd.Enabled = cnt == 1;
				releaseCmd.Enabled = cnt == 1 && !string.IsNullOrEmpty(CurSel.AttachedTo) && CurSel.AttachedToIds.All(s => !MachineRunning(s));
				modifyCmd.Enabled = cnt == 1 && !CurSel.Differencing;

				bool MachineRunning(string id)
				{
					var st = MachineState.MachineState_Null;
					try { st = Client.VBox.FindMachine(id).State; } catch { }
					if (st == MachineState.MachineState_Null) throw new InvalidOperationException();
					return st >= MachineState.MachineState_FirstOnline && st <= MachineState.MachineState_LastOnline;
				}
			}
			addCmd.Enabled = createCmd.Enabled = refreshCmd.Enabled = true;
		}

		private void DiskListViewOnColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column != sortColumn)
			{
				sortColumn = e.Column;
				diskListView.Sorting = SortOrder.Ascending;
			}
			else
			{
				diskListView.Sorting = diskListView.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			}
			switch (e.Column)
			{
				case 0:
				case 1:
					diskListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
					break;

				case 2:
					diskListView.ListViewItemSorter = new ListViewItemComparer(e.Column, i => ((DiskInfo)i.Tag).VirtualSize, Comparer<long>.Default);
					break;

				case 3:
					diskListView.ListViewItemSorter = new ListViewItemComparer(e.Column, i => ((DiskInfo)i.Tag).Size, Comparer<long>.Default);
					break;
			}
			diskListView.Sort();
		}

		private void GetDiskInfo()
		{
			disks.Clear();
			foreach (IMedium d in Client.VBox.HardDisks)
				disks.Add(new DiskInfo(d));
			disks.Sort((d1, d2) => string.Compare(d1.Name, d2.Name, StringComparison.InvariantCulture));
		}

		private string[] GetListItemData(DiskInfo i) => new[] { i.Name, GetDisplayString(i.State), SizeStr(i.VirtualSize), SizeStr(i.Size) };

		private void LoadDiskList(string uuid)
		{
			diskListView.BeginUpdate();
			diskListView.Items.Clear();
			foreach (var i in disks)
				diskListView.Items.Add(new ListViewItem(GetListItemData(i)) { Tag = i });

			if (diskListView.Items.Count > 0)
			{
				if (uuid != null)
				{
					var i = diskListView.Items.Cast<ListViewItem>().FirstOrDefault(d => (d.Tag as DiskInfo)?.UUID == uuid);
					if (i != null) { diskListView.SelectedItems.Clear(); i.Selected = true; }
				}
				else
					diskListView.Items[0].Selected = true;
			}
			diskListView.EndUpdate();
			SetColWidths();
		}

		private async void modifyCmd_Click(object sender, EventArgs e)
		{
			if (CurSel?.Location == null)
			{
				MessageBox.Show(this, "Error getting disk information", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var options = new List<MediumType> { MediumType.MediumType_Normal, MediumType.MediumType_Immutable, MediumType.MediumType_Shareable, MediumType.MediumType_MultiAttach };
			if (!CurSel.HasChildren) options.Add(MediumType.MediumType_Writethrough);

			var dlg = new ModifyDlg(CurSel.Location, options.ToArray(), CurSel.MediumType);
			if (dlg.ShowDialog(this) == DialogResult.Cancel) return;

			await RunAsyncAction("Changing", async (t, p) => await Task.Run(() => { Medium.ChangeMediumType(CurSel.Location, dlg.MediumType); }, t), CurSel.UUID);
		}

		private async void moveCmd_Click(object sender, EventArgs e)
		{
			if (CurSel == null) return;

			var dlg = new MoveDlg(CurSel.UUID);
			if (dlg.ShowDialog(this) != DialogResult.OK) return;

			await RunAsync("Moving", async (t, p) =>
			{
				await Medium.MoveAsync(CurSel.Location, dlg.DestPath, t, p);
				CurSel.Location = dlg.DestPath;
			}, CurSel.UUID);
		}

		private void openFldrMenuItem_Click(object sender, EventArgs e)
		{
			string txt = null;
			if (sender is ToolStripMenuItem mi)
				txt = ((mi.Owner as ContextMenuStrip)?.SourceControl as TextBox)?.Text;
			else
				txt = CurSel?.Location;
			if (txt == null) return;
			System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{txt}\"");
		}

		private void ProgressDlg_Cancelled(object sender, CancelEventArgs e) => cancelToken?.Cancel();

		private async Task RefreshAsync(CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress, string uuid = null)
		{
			await Task.Run(() =>
			{
				for (var i = 0; i < disks.Count; i++)
				{
					var disk = disks[i];
					if (uuid != null && string.CompareOrdinal(uuid, disk.UUID) != 0) continue;
					progress.Report(new Tuple<int, string>(i * 100 / disks.Count, disk.Name));
					if (cancellationToken.IsCancellationRequested)
						break;
					try
					{
						var vdi = Medium.OpenMedium(disk.Location, AccessMode.AccessMode_ReadOnly);
						vdi.RefreshState();
						disk.Update(vdi);
					}
					catch { }
					Invoke(new Action<Guid>(UpdateItem), disk.Key);
				}
				progress.Report(new Tuple<int, string>(100, ""));
			}, cancellationToken);
		}

		private async void refreshCmd_Click(object sender, EventArgs e) => await RefreshList();

		private async Task RefreshList()
		{
			var uuid = CurSel?.UUID;
			GetDiskInfo();
			LoadDiskList(uuid);
			await RunAsyncAction("Refreshing", null);
		}

		private async void releaseCmd_Click(object sender, EventArgs e)
		{
			var approveText = "";
			if (CurSel != null)
			{
				approveText = $"Are you sure you want to release the disk image file:\n\r{CurSel.Location}?";
				if (!string.IsNullOrEmpty(CurSel.AttachedTo))
					approveText += $"\n\r\n\rThis will detach it from the following virtual machines:\n\r{CurSel.AttachedTo}";
			}
			else
				approveText = "Are you sure you want to release the selected disk image files?\n\r\n\rThis will detach them from any virtual machines.";
			if (MessageBox.Show(this, approveText, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

			await RunMultiple(async di =>
			{
				if (di?.Location == null)
					MessageBox.Show(this, "Error getting disk information", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					await RunAsyncAction("Releasing", async (t, p) => await Task.Run(() => { Medium.Release(di.Location); }, t), di.UUID);
			});
		}

		private async void removeCmd_Click(object sender, EventArgs e)
		{
			if (CurSel?.Location == null)
			{
				MessageBox.Show(this, "Error getting disk information", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var approveText = $"Are you sure you want to remove the disk image file:\n\r{CurSel.Location}?";
			if (!string.IsNullOrEmpty(CurSel.AttachedTo))
				approveText += $"\n\r\n\rThis will detach it from the following virtual machines:\n\r{CurSel.AttachedTo}";
			if (MessageBox.Show(this, approveText, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

			await RunAsyncAction("Removing", async (t, p) => await Medium.RemoveAsync(CurSel.Location, t, p));
			await RefreshList();
		}

		private async void resizeCmd_Click(object sender, EventArgs e)
		{
			if (CurSel == null) return;

			var dlg = new ResizeDlg(CurSel.UUID);
			if (dlg.ShowDialog(this) != DialogResult.OK) return;

			await RunAsync("Resizing", async (t, p) => await Medium.ResizeAsync(CurSel.Location, dlg.NewDiskSize, t, p), CurSel.UUID);
		}

		private async Task RunAsync(string progressTitle, Func<CancellationToken, IProgress<Tuple<int, string>>, Task> action, string refreshDiskId = null) =>
			await RunAsyncMethod(progressTitle, action, refreshDiskId, UpdateProgress, SetProgressVisible);

		private async Task RunAsyncAction(string progressTitle, Func<CancellationToken, IProgress<Tuple<int, string>>, Task> action, string refreshDiskId = null) =>
			await RunAsyncMethod(progressTitle, action, refreshDiskId, UpdateAction, SetActionVisible);

		private async Task RunAsyncMethod(string progressTitle, Func<CancellationToken, IProgress<Tuple<int, string>>, Task> action, string refreshDiskId, Action<string, int, string> progressDisplay, Action<bool> showProgress)
		{
			var pr = new Progress<Tuple<int, string>>(t => progressDisplay(progressTitle, t.Item1, t.Item2));
			cancelToken = new CancellationTokenSource();
			try
			{
				if (action != null) await action(cancelToken.Token, pr);
				await RefreshAsync(cancelToken.Token, pr, refreshDiskId);
				showProgress.Invoke(false);
			}
			catch (Exception ex)
			{
				showProgress.Invoke(false);
				MessageBox.Show(this, ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cancelToken = null;
			}
		}

		private async Task RunMultiple(Func<DiskInfo, Task> call)
		{
			if (diskListView.SelectedItems.Count == 0) return;
			var showTask = diskListView.SelectedItems.Count > 1;
			if (!showTask) progressDlg.MacroStatusText = null;
			var tp = 0;
			foreach (ListViewItem item in diskListView.SelectedItems)
			{
				if (!(item.Tag is DiskInfo di) || di.Location == null) continue;
				if (showTask) { progressDlg.MacroStatusText = di.Name; progressDlg.MacroPercentComplete = tp++ * 100 / diskListView.SelectedItems.Count; }
				await call(di);
			}
			if (showTask) { progressDlg.MacroStatusText = "Complete"; progressDlg.MacroPercentComplete = 100; }
		}

		private void SetActionVisible(bool value) => actionLabel.Visible = actionProgress.Visible = actionStatusLabel.Visible = actionCancelBtn.Visible = value;

		private void SetColWidths()
		{
			for (var i = 1; i <= 3; i++)
			{
				diskListView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.None);
				diskListView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			nameCol.Width = diskListView.ClientSize.Width - stateCol.Width - asizeCol.Width - vsizeCol.Width;
		}

		private void SetProgressVisible(bool value)
		{
			if (value && !progressDlg.Visible) progressDlg.ShowDialog(this);
			else if (!value && progressDlg.Visible) progressDlg.Close();
		}

		private async void startMenuItem_Click(object sender, EventArgs e)
		{
			var txt = (((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl as TextBox)?.Text;
			if (txt == null) return;
			var mnames = txt.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
			if (mnames.Length == 0) return;
			await RunAsyncAction("Starting", async (t, p) => await Machine.LaunchAsync(mnames[0], t, p, 60000));
		}

		private void statusTextBox_Enter(object sender, EventArgs e) => (sender as TextBox)?.SelectAll();

		private void UpdateItem(Guid key)
		{
			var item = diskListView.Items.Cast<ListViewItem>().FirstOrDefault(i => key.Equals(((DiskInfo)i.Tag)?.Key));
			if (item == null) return;
			var newItems = GetListItemData((DiskInfo)item.Tag);
			for (var i = 0; i < item.SubItems.Count; i++)
				item.SubItems[i].Text = newItems[i];
			if (item.Selected)
				diskListView_SelectedIndexChanged(diskListView, EventArgs.Empty);
			SetColWidths();
		}

		private class ListViewItemComparer : IComparer
		{
			private readonly IComparer comparer;
			private readonly Func<ListViewItem, object> getter;

			public ListViewItemComparer(int column = 0, Func<ListViewItem, object> getter = null, IComparer comparer = null)
			{
				this.comparer = comparer ?? StringComparer.CurrentCulture;
				this.getter = getter ?? (o => o.SubItems[column].Text);
			}

			public int Compare(object x, object y)
			{
				var order = (x as ListViewItem)?.ListView.Sorting ?? SortOrder.Ascending;
				var mult = order == SortOrder.Descending ? -1 : 1;
				return comparer.Compare(getter((ListViewItem)x), getter((ListViewItem)y)) * mult;
			}
		}
	}
}