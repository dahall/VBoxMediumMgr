using System;
using System.Threading;
using System.Threading.Tasks;
using Vanara.PInvoke;
using static Vanara.PInvoke.AdvApi32;
using static Vanara.PInvoke.VirtDisk;

namespace VBoxMediumMgr
{
	public static class MSVirtualDisk
	{
		public static async Task CompactVHD(string loc, CancellationToken cancellationToken, IProgress<Tuple<int, string>> progress)
		{
			var vhdCompactOverlapEvent = new ManualResetEvent(false);
			var vhdCompactOverlap = new NativeOverlapped { EventHandle = vhdCompactOverlapEvent.SafeWaitHandle.DangerousGetHandle() };

			// Perform file-system-aware compaction
			var stType = VIRTUAL_STORAGE_TYPE.VHD;
			var param = OPEN_VIRTUAL_DISK_PARAMETERS.DefaultV2;
			var err = OpenVirtualDisk(stType, loc, VIRTUAL_DISK_ACCESS_MASK.VIRTUAL_DISK_ACCESS_NONE, OPEN_VIRTUAL_DISK_FLAG.OPEN_VIRTUAL_DISK_FLAG_NONE, param, out var hVhd);
			err.ThrowIfFailed();
			if (!ConvertStringSecurityDescriptorToSecurityDescriptor("O:BAG:BAD:(A;;GA;;;WD)", SDDL_REVISION.SDDL_REVISION_1, out var sd, out var hLen))
				Win32Error.ThrowLastError();
			var aParam = ATTACH_VIRTUAL_DISK_PARAMETERS.Default;
			err = AttachVirtualDisk(hVhd, (IntPtr)sd, ATTACH_VIRTUAL_DISK_FLAG.ATTACH_VIRTUAL_DISK_FLAG_PERMANENT_LIFETIME | ATTACH_VIRTUAL_DISK_FLAG.ATTACH_VIRTUAL_DISK_FLAG_READ_ONLY, 0, aParam, IntPtr.Zero);
			err.ThrowIfFailed();

			var cParam = COMPACT_VIRTUAL_DISK_PARAMETERS.Default;
			err = CompactVirtualDisk(hVhd, COMPACT_VIRTUAL_DISK_FLAG.COMPACT_VIRTUAL_DISK_FLAG_NONE, cParam, ref vhdCompactOverlap);
			if (err != Win32Error.ERROR_IO_PENDING) err.ThrowIfFailed();

			// Loop getting status
			var taskComplete = await GetProgress(hVhd, 1);

			// Cleanup first op
			err = DetachVirtualDisk(hVhd, DETACH_VIRTUAL_DISK_FLAG.DETACH_VIRTUAL_DISK_FLAG_NONE, 0);
			err.ThrowIfFailed();
			hVhd.Dispose();

			// If first op fails, don't bother with the second
			if (!taskComplete) return;

			// Perform file-system-agnostic compaction
			vhdCompactOverlapEvent.Reset();
			err = OpenVirtualDisk(stType, loc, VIRTUAL_DISK_ACCESS_MASK.VIRTUAL_DISK_ACCESS_NONE, OPEN_VIRTUAL_DISK_FLAG.OPEN_VIRTUAL_DISK_FLAG_NONE, param, out hVhd);
			err.ThrowIfFailed();
			err = CompactVirtualDisk(hVhd, COMPACT_VIRTUAL_DISK_FLAG.COMPACT_VIRTUAL_DISK_FLAG_NONE, cParam, ref vhdCompactOverlap);
			if (err != Win32Error.ERROR_IO_PENDING) err.ThrowIfFailed();

			// Loop getting status
			await GetProgress(hVhd, 2);

			hVhd.Dispose();

			async Task<bool> GetProgress(SafeVIRTUAL_DISK_HANDLE phVhd, int step)
			{
				var prog = new VIRTUAL_DISK_PROGRESS();
				var start = step == 1 ? 0 : 50;
				var end = step == 1 ? 50 : 100;
				ReportProgress(start);
				while (true)
				{
					var perr = GetVirtualDiskOperationProgress(phVhd, ref vhdCompactOverlap, out prog);
					perr.ThrowIfFailed();
					if (cancellationToken.IsCancellationRequested) return false;
					switch (prog.OperationStatus)
					{
						case 0:
							ReportProgress(end);
							return true;

						case Win32Error.ERROR_IO_PENDING:
							ReportProgress(start + (int)(prog.CurrentValue * 50 / prog.CompletionValue));
							break;

						default:
							throw new Win32Error((int)prog.OperationStatus).GetException();
					}
					if (prog.CurrentValue == prog.CompletionValue) return true;
					await Task.Delay(250, cancellationToken);
				}
			}

			void ReportProgress(int percent) => progress.Report(new Tuple<int, string>(percent, $"Compacting VHD volume \"{loc}\""));

			/*var prog = new Progress<int>(i => progress.Report(new Tuple<int, string>(i / 2, loc)));
			var taskComplete = false;
			try
			{
				var param = new OPEN_VIRTUAL_DISK_PARAMETERS(0);
				using (new PrivilegedCodeBlock(SystemPrivilege.ManageVolume))
				using (var vhd = VirtualDisk.Open(loc, OPEN_VIRTUAL_DISK_FLAG.OPEN_VIRTUAL_DISK_FLAG_NONE, param, VIRTUAL_DISK_ACCESS_MASK.VIRTUAL_DISK_ACCESS_ATTACH_RO | VIRTUAL_DISK_ACCESS_MASK.VIRTUAL_DISK_ACCESS_METAOPS))
				{
					var flags = ATTACH_VIRTUAL_DISK_FLAG.ATTACH_VIRTUAL_DISK_FLAG_READ_ONLY;
					var aparam = ATTACH_VIRTUAL_DISK_PARAMETERS.Default;
					if (!ConvertStringSecurityDescriptorToSecurityDescriptor("O:BAG:BAD:(A;;GA;;;WD)", SDDL_REVISION.SDDL_REVISION_1, out Vanara.InteropServices.SafeHGlobalHandle sd, out uint hLen))
						Vanara.PInvoke.Win32Error.ThrowLastError();
					vhd.Attach(flags, ref aparam, (IntPtr)sd);
					taskComplete = await vhd.Compact(cancellationToken, prog);
					vhd.Detach();
				}
			}
			catch
			{
				taskComplete = true;
				throw;
			}

			// If first op fails, don't bother with the second
			if (!taskComplete) return;

			prog = new Progress<int>(i => progress.Report(new Tuple<int, string>(50 + i / 2, loc)));
			// Perform file-system-agnostic compaction
			using (var vd = VirtualDisk.Open(loc))
			{
				await vd.Compact(cancellationToken, prog);
			}*/
		}
	}
}