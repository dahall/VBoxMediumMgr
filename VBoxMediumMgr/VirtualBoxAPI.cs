using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VBoxMediumMgr;
using VirtualBox;

namespace VirtualBoxAPI
{
	public static class Client
	{
		public static VirtualBoxClient Instance { get; } = new VirtualBoxClient();
		public static IVirtualBox VBox { get; } = Instance.VirtualBox;
		public static Session Session => Instance.Session;

		internal static async Task ProcessProgress(IProgress methodHandler, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			while (methodHandler.Completed == 0)
			{
				ReportProgress((int)methodHandler.Percent, methodHandler.Description);
				if (cancellationToken.IsCancellationRequested)
				{
					if (methodHandler.Cancelable == 1) methodHandler.Cancel();
					return;
				}
				await Task.Delay(250, cancellationToken);
			}
			if (methodHandler.ErrorInfo != null)
				throw new Win32Exception(methodHandler.ErrorInfo.ResultCode, methodHandler.ErrorInfo.Text);
			ReportProgress((int)methodHandler.Percent, methodHandler.Description);

			void ReportProgress(int percent, string desc) => progress.Report(new Tuple<int, string>(percent, desc));
		}
	}

	public static class Machine
	{
		public static IMachine GetMachine(string idOrName) => Client.VBox.Machines.Cast<IMachine>().FirstOrDefault(m => m.Id == idOrName || m.Name == idOrName);

		public static async Task LaunchAsync(string idOrName, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress, int timeOut = -1)
		{
			var iprog = GetMachine(idOrName)?.LaunchVMProcess(Client.Session, "", null);
			if (iprog == null) return;
			await Client.ProcessProgress(iprog, cancellationToken, progress);
		}
	}

	public static class Medium
	{
		public static void ChangeMediumType(string src, MediumType newMediumType)
		{
			var vdi = OpenMedium(src);
			var att = Detach(vdi);
			vdi.Type = newMediumType;
			Reattach(vdi, att);
		}

		public static async Task CloneAsync(string src, string dest, HDFileType ft, bool dyn, bool split, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			if (string.IsNullOrEmpty(Path.GetDirectoryName(dest)))
				dest = Path.Combine(Path.GetDirectoryName(src), Path.GetFileName(dest));
			var vdi = OpenMedium(src, AccessMode.AccessMode_ReadOnly);
			var newVdi = Client.VBox.CreateMedium(ft.ToString(), dest, AccessMode.AccessMode_ReadWrite, DeviceType.DeviceType_HardDisk);
			var variants = new MediumVariant[32];
			var i = 0;
			if (!dyn) variants[i++] = MediumVariant.MediumVariant_Fixed;
			if (split && ft == HDFileType.VMDK) variants[i] = MediumVariant.MediumVariant_VmdkSplit2G;
			await Client.ProcessProgress(vdi.CloneToBase(newVdi, variants), cancellationToken, progress);
		}

		public static async Task CompactAsync(string loc, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			var vdi = OpenMedium(loc);
			await Client.ProcessProgress(vdi.Compact(), cancellationToken, progress);
		}

		public static async Task Create(string loc, HDFileType fileType, long size, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress, DeviceType type = DeviceType.DeviceType_HardDisk, bool dynamic = true, bool splitFile = false)
		{
			var vdi = Client.VBox.CreateMedium(fileType.ToString(), loc, AccessMode.AccessMode_ReadWrite, type);
			var variants = new MediumVariant[32];
			var i = 0;
			if (!dynamic) variants[i++] = MediumVariant.MediumVariant_Fixed;
			if (splitFile && fileType == HDFileType.VMDK) variants[i] = MediumVariant.MediumVariant_VmdkSplit2G;
			await Client.ProcessProgress(vdi.CreateBaseStorage(size, variants), cancellationToken, progress);
		}

		public static Stack<MediamReattachInfo> Detach(IMedium vdi)
		{
			var attInfo = new Stack<MediamReattachInfo>();
			foreach (var machine in Client.VBox.Machines.Cast<IMachine>().Where(m => vdi.MachineIds.Cast<string>().Any(id => string.Equals(m.Id, id, StringComparison.Ordinal))))
			{
				var medAtt = machine.MediumAttachments.Cast<IMediumAttachment>().FirstOrDefault(ma => ma.Medium?.Id == vdi.Id);
				if (medAtt == null) throw new ArgumentException(nameof(vdi));
				attInfo.Push(new MediamReattachInfo(machine, vdi, medAtt));
				using (var ml = new MachineLock(machine))
					ml.Raw.DetachDevice(medAtt.Controller, medAtt.Port, medAtt.Device);
			}
			return attInfo;
		}

		public static async Task MoveAsync(string src, string dest, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			if (string.IsNullOrEmpty(Path.GetDirectoryName(dest))) dest = Path.Combine(Path.GetDirectoryName(src), Path.GetFileName(dest));
			var vdi = OpenMedium(src, AccessMode.AccessMode_ReadOnly);
			await Client.ProcessProgress(vdi.MoveTo(dest), cancellationToken, progress);
		}

		public static IMedium OpenMedium(string loc, AccessMode mode = AccessMode.AccessMode_ReadWrite) => Client.VBox.OpenMedium(loc, DeviceType.DeviceType_HardDisk, mode, 0);

		public static void Reattach(IMedium vdi, Stack<MediamReattachInfo> att)
		{
			while (att.Count > 0)
			{
				var i = att.Pop();
				var machine = Client.VBox.FindMachine(i.MachineId);
				if (machine == null) continue;
				using (var ml = new MachineLock(machine))
					ml.Raw.AttachDevice(i.ControllerName, i.ContollerPort, i.DeviceSlot, i.DeviceType, vdi);
			}
		}

		public static void Release(string loc)
		{
			var vdi = OpenMedium(loc, AccessMode.AccessMode_ReadOnly);
			Detach(vdi);
			vdi.Close();
		}

		public static async Task RemoveAsync(string loc, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			var vdi = OpenMedium(loc, AccessMode.AccessMode_ReadOnly);
			Detach(vdi);
			await Client.ProcessProgress(vdi.DeleteStorage(), cancellationToken, progress);
		}

		public static async Task ResizeAsync(string loc, long newSize, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			var vdi = OpenMedium(loc, AccessMode.AccessMode_ReadOnly);
			await Client.ProcessProgress(vdi.Resize(newSize), cancellationToken, progress);
		}

		public class MediamReattachInfo
		{
			public MediamReattachInfo(IMachine m, IMedium med, IMediumAttachment att)
			{
				MachineId = m.Id;
				MediumId = med.Id;
				ControllerName = att.Controller;
				ContollerPort = att.Port;
				DeviceSlot = att.Device;
				DeviceType = med.DeviceType;
			}

			public int ContollerPort { get; }
			public string ControllerName { get; }
			public int DeviceSlot { get; }
			public DeviceType DeviceType { get; }
			public string MachineId { get; }
			public string MediumId { get; }
		}

		private class MachineLock : IDisposable
		{
			private readonly Session session;

			public MachineLock(IMachine machine)
			{
				session = Client.Session;
				machine.LockMachine(session, LockType.LockType_Write);
				if (session.State != SessionState.SessionState_Locked) throw new InvalidOperationException("Unable to lock session.");
				Raw = session.Machine;
			}

			public IMachine Raw { get; }

			void IDisposable.Dispose()
			{
				Raw.SaveSettings(); session.UnlockMachine();
			}
		}
	}
}