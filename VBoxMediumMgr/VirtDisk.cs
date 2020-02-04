using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// ReSharper disable InconsistentNaming ReSharper disable FieldCanBeMadeReadOnly.Global

namespace Vanara.PInvoke
{
	/// <summary>Platform invokable enumerated types, constants and functions from virtdisk.h</summary>
	public static class VirtDisk
	{
		/// <summary>The virtual storage type vendor Microsoft</summary>
		public static readonly Guid VIRTUAL_STORAGE_TYPE_VENDOR_MICROSOFT = new Guid("EC984AEC-A0F9-47e9-901F-71415A66345B");

		/// <summary>Contains virtual disk attach request flags.</summary>
		[Flags]
		public enum ATTACH_VIRTUAL_DISK_FLAG
		{
			/// <summary>No flags. Use system defaults.</summary>
			ATTACH_VIRTUAL_DISK_FLAG_NONE = 0x00000000,

			/// <summary>
			/// Attach the virtual disk as read-only.
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This flag is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			ATTACH_VIRTUAL_DISK_FLAG_READ_ONLY = 0x00000001,

			/// <summary>
			/// No drive letters are assigned to the disk's volumes.
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This flag is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			ATTACH_VIRTUAL_DISK_FLAG_NO_DRIVE_LETTER = 0x00000002,

			/// <summary>
			/// Will decouple the virtual disk lifetime from that of the VirtualDiskHandle. The virtual disk will be attached until the DetachVirtualDisk
			/// function is called, even if all open handles to the virtual disk are closed.
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This flag is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			ATTACH_VIRTUAL_DISK_FLAG_PERMANENT_LIFETIME = 0x00000004,

			/// <summary>Reserved. This flag is not supported for ISO virtual disks.</summary>
			ATTACH_VIRTUAL_DISK_FLAG_NO_LOCAL_HOST = 0x00000008
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) ATTACH_VIRTUAL_DISK_PARAMETERS structure to use in calls to VHD functions.</summary>
		public enum ATTACH_VIRTUAL_DISK_VERSION
		{
			/// <summary>Unspecified version.</summary>
			ATTACH_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary>Version 1.</summary>
			ATTACH_VIRTUAL_DISK_VERSION_1 = 1
		}

		/// <summary>Contains virtual disk compact request flags.</summary>
		public enum COMPACT_VIRTUAL_DISK_FLAG
		{
			/// <summary>No flags are specified.</summary>
			COMPACT_VIRTUAL_DISK_FLAG_NONE = 0
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) COMPACT_VIRTUAL_DISK_PARAMETERS structure to use in calls to VHD functions.</summary>
		public enum COMPACT_VIRTUAL_DISK_VERSION
		{
			/// <summary>Unspecified.</summary>
			COMPACT_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary>Version 1.</summary>
			COMPACT_VIRTUAL_DISK_VERSION_1 = 1
		}

		/// <summary>Contains virtual disk creation flags.</summary>
		public enum CREATE_VIRTUAL_DISK_FLAG
		{
			/// <summary>No special creation conditions; system defaults are used.</summary>
			CREATE_VIRTUAL_DISK_FLAG_NONE = 0x00000000,

			/// <summary>Pre-allocate all physical space necessary for the size of the virtual disk.</summary>
			CREATE_VIRTUAL_DISK_FLAG_FULL_PHYSICAL_ALLOCATION = 0x00000001
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) CREATE_VIRTUAL_DISK_PARAMETERS structure to use in calls to VHD functions.</summary>
		public enum CREATE_VIRTUAL_DISK_VERSION
		{
			/// <summary></summary>
			CREATE_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary></summary>
			CREATE_VIRTUAL_DISK_VERSION_1 = 1
		}

		/// <summary>Contains virtual disk dependency information flags.</summary>
		public enum DEPENDENT_DISK_FLAG
		{
			/// <summary>No flags specified. Use system defaults.</summary>
			DEPENDENT_DISK_FLAG_NONE = 0x00000000,

			/// <summary>Multiple files backing the virtual disk.</summary>
			DEPENDENT_DISK_FLAG_MULT_BACKING_FILES = 0x00000001,

			/// <summary>Fully allocated virtual disk.</summary>
			DEPENDENT_DISK_FLAG_FULLY_ALLOCATED = 0x00000002,

			/// <summary>Read-only virtual disk.</summary>
			DEPENDENT_DISK_FLAG_READ_ONLY = 0x00000004,

			/// <summary>The backing file of the virtual disk is not on a local physical disk.</summary>
			DEPENDENT_DISK_FLAG_REMOTE = 0x00000008,

			/// <summary>Reserved.</summary>
			DEPENDENT_DISK_FLAG_SYSTEM_VOLUME = 0x00000010,

			/// <summary>The backing file of the virtual disk is on the system volume.</summary>
			DEPENDENT_DISK_FLAG_SYSTEM_VOLUME_PARENT = 0x00000020,

			/// <summary>The backing file of the virtual disk is on a removable physical disk.</summary>
			DEPENDENT_DISK_FLAG_REMOVABLE = 0x00000040,

			/// <summary>Drive letters are not automatically assigned to the volumes on the virtual disk.</summary>
			DEPENDENT_DISK_FLAG_NO_DRIVE_LETTER = 0x00000080,

			/// <summary>The virtual disk is a parent of a differencing chain.</summary>
			DEPENDENT_DISK_FLAG_PARENT = 0x00000100,

			/// <summary>The virtual disk is not surfaced on (attached to) the local host. For example, it is attached to a guest virtual machine.</summary>
			DEPENDENT_DISK_FLAG_NO_HOST_DISK = 0x00000200,

			/// <summary>The lifetime of the virtual disk is not tied to any application or process.</summary>
			DEPENDENT_DISK_FLAG_PERMANENT_LIFETIME = 0x00000400
		}

		/// <summary>Contains virtual disk detach request flags.</summary>
		public enum DETACH_VIRTUAL_DISK_FLAG
		{
			/// <summary>No flags. Use system defaults.</summary>
			DETACH_VIRTUAL_DISK_FLAG_NONE = 0
		}

		/// <summary>Contains virtual hard disk (VHD) expand request flags.</summary>
		public enum EXPAND_VIRTUAL_DISK_FLAG
		{
			/// <summary></summary>
			EXPAND_VIRTUAL_DISK_FLAG_NONE = 0x00000000
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) EXPAND_VIRTUAL_DISK_PARAMETERS structure to use in calls to VHD functions.</summary>
		public enum EXPAND_VIRTUAL_DISK_VERSION
		{
			/// <summary></summary>
			EXPAND_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary></summary>
			EXPAND_VIRTUAL_DISK_VERSION_1 = 1
		}

		/// <summary>Contains virtual hard disk (VHD) storage dependency request flags.</summary>
		public enum GET_STORAGE_DEPENDENCY_FLAG
		{
			/// <summary>No flags specified.</summary>
			GET_STORAGE_DEPENDENCY_FLAG_NONE = 0x00000000,

			/// <summary>Return information for volumes or disks hosting the volume specified.</summary>
			GET_STORAGE_DEPENDENCY_FLAG_HOST_VOLUMES = 0x00000001,

			/// <summary>The handle provided is to a disk, not a volume or file.</summary>
			GET_STORAGE_DEPENDENCY_FLAG_DISK_HANDLE = 0x00000002
		}

		/// <summary>Contains virtual hard disk (VHD) information retrieval identifiers.</summary>
		public enum GET_VIRTUAL_DISK_INFO_VERSION
		{
			/// <summary>Unspecified.</summary>
			GET_VIRTUAL_DISK_INFO_UNSPECIFIED = 0,

			/// <summary>Size.</summary>
			GET_VIRTUAL_DISK_INFO_SIZE = 1,

			/// <summary>Unique identifier.</summary>
			GET_VIRTUAL_DISK_INFO_IDENTIFIER = 2,

			/// <summary>Location of the parent.</summary>
			GET_VIRTUAL_DISK_INFO_PARENT_LOCATION = 3,

			/// <summary>Unique identifier of the parent.</summary>
			GET_VIRTUAL_DISK_INFO_PARENT_IDENTIFIER = 4,

			/// <summary>Time stamp of the parent.</summary>
			GET_VIRTUAL_DISK_INFO_PARENT_TIMESTAMP = 5,

			/// <summary>Type.</summary>
			GET_VIRTUAL_DISK_INFO_VIRTUAL_STORAGE_TYPE = 6,

			/// <summary>Subtype.</summary>
			GET_VIRTUAL_DISK_INFO_PROVIDER_SUBTYPE = 7
		}

		/// <summary>Contains virtual hard disk (VHD) merge request flags.</summary>
		public enum MERGE_VIRTUAL_DISK_FLAG
		{
			/// <summary></summary>
			MERGE_VIRTUAL_DISK_FLAG_NONE = 0x00000000
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) MERGE_VIRTUAL_DISK_PARAMETERS structure to use in calls to VHD functions.</summary>
		public enum MERGE_VIRTUAL_DISK_VERSION
		{
			/// <summary></summary>
			MERGE_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary></summary>
			MERGE_VIRTUAL_DISK_VERSION_1 = 1
		}

		/// <summary>Contains virtual hard disk (VHD) or CD or DVD image file (ISO) open request flags.</summary>
		[Flags]
		public enum OPEN_VIRTUAL_DISK_FLAG
		{
			/// <summary>No flag specified.</summary>
			OPEN_VIRTUAL_DISK_FLAG_NONE = 0x00000000,

			/// <summary>
			/// Open the VHD file (backing store) without opening any differencing-chain parents. Used to correct broken parent links. This flag is not supported
			/// for ISO virtual disks.
			/// </summary>
			OPEN_VIRTUAL_DISK_FLAG_NO_PARENTS = 0x00000001,

			/// <summary>Reserved. This flag is not supported for ISO virtual disks.</summary>
			OPEN_VIRTUAL_DISK_FLAG_BLANK_FILE = 0x00000002,

			/// <summary>Reserved. This flag is not supported for ISO virtual disks.</summary>
			OPEN_VIRTUAL_DISK_FLAG_BOOT_DRIVE = 0x00000004,

			/// <summary>
			/// Indicates that the virtual disk should be opened in cached mode. By default the virtual disks are opened using FILE_FLAG_NO_BUFFERING and FILE_FLAG_WRITE_THROUGH.
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This value is not supported before Windows 8 and Windows Server 2012.</para>
			/// </summary>
			OPEN_VIRTUAL_DISK_FLAG_CACHED_IO = 0x00000008,

			/// <summary>
			/// Indicates the VHD file is to be opened without opening any differencing-chain parents and the parent chain is to be created manually using the
			/// AddVirtualDiskParent function.
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This value is not supported before Windows 8 and Windows Server 2012.</para>
			/// </summary>
			OPEN_VIRTUAL_DISK_FLAG_CUSTOM_DIFF_CHAIN = 0x00000010
		}

		/// <summary>Contains the version of the virtual disk OPEN_VIRTUAL_DISK_PARAMETERS structure to use in calls to virtual disk functions.</summary>
		public enum OPEN_VIRTUAL_DISK_VERSION
		{
			/// <summary>Unspecified version.</summary>
			OPEN_VIRTUAL_DISK_VERSION_UNSPECIFIED = 0,

			/// <summary>Use the Version1 member of this structure.</summary>
			OPEN_VIRTUAL_DISK_VERSION_1 = 1,

			/// <summary>Use the Version2 member of this structure.</summary>
			OPEN_VIRTUAL_DISK_VERSION_2 = 2
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) SET_VIRTUAL_DISK_INFO structure to use in calls to VHD functions.</summary>
		public enum SET_VIRTUAL_DISK_INFO_VERSION
		{
			/// <summary>Not used. Will fail the operation.</summary>
			SET_VIRTUAL_DISK_INFO_UNSPECIFIED = 0,

			/// <summary>Parent information is being set.</summary>
			SET_VIRTUAL_DISK_INFO_PARENT_PATH = 1,

			/// <summary>A unique identifier is being set.</summary>
			SET_VIRTUAL_DISK_INFO_IDENTIFIER = 2
		}

		/// <summary>Contains the version of the virtual hard disk (VHD) STORAGE_DEPENDENCY_INFO structure to use in calls to VHD functions.</summary>
		public enum STORAGE_DEPENDENCY_INFO_VERSION
		{
			/// <summary>The version is not specified.</summary>
			STORAGE_DEPENDENCY_INFO_VERSION_UNSPECIFIED = 0,

			/// <summary>Specifies STORAGE_DEPENDENCY_INFO_TYPE_1.</summary>
			STORAGE_DEPENDENCY_INFO_VERSION_1 = 1,

			/// <summary>Specifies STORAGE_DEPENDENCY_INFO_TYPE_2.</summary>
			STORAGE_DEPENDENCY_INFO_VERSION_2 = 2
		}

		/// <summary>Contains the bitmask for specifying access rights to a virtual hard disk (VHD) or CD or DVD image file (ISO).</summary>
		[Flags]
		public enum VIRTUAL_DISK_ACCESS_MASK
		{
			/// <summary>
			/// Open the virtual disk with no access. This is the only supported value when calling CreateVirtualDisk and specifying
			/// CREATE_VIRTUAL_DISK_VERSION_2 in the VirtualDiskAccessMask parameter.
			/// </summary>
			VIRTUAL_DISK_ACCESS_NONE = 0x00000000,

			/// <summary>
			/// Open the virtual disk for read-only attach access. The caller must have READ access to the virtual disk image file.
			/// <para>
			/// If used in a request to open a virtual disk that is already open, the other handles must be limited to either VIRTUAL_DISK_ACCESS_DETACH or
			/// VIRTUAL_DISK_ACCESS_GET_INFO access, otherwise the open request with this flag will fail.
			/// </para>
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This access right is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_ATTACH_RO = 0x00010000,

			/// <summary>
			/// Open the virtual disk for read/write attaching access. The caller must have (READ | WRITE) access to the virtual disk image file.
			/// <para>
			/// If used in a request to open a virtual disk that is already open, the other handles must be limited to either VIRTUAL_DISK_ACCESS_DETACH or
			/// VIRTUAL_DISK_ACCESS_GET_INFO access, otherwise the open request with this flag will fail.
			/// </para>
			/// <para>
			/// If the virtual disk is part of a differencing chain, the disk for this request cannot be less than the RWDepth specified during the prior open
			/// request for that differencing chain.
			/// </para>
			/// <para>This flag is not supported for ISO virtual disks.</para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_ATTACH_RW = 0x00020000,

			/// <summary>
			/// Open the virtual disk to allow detaching of an attached virtual disk. The caller must have (FILE_READ_ATTRIBUTES | FILE_READ_DATA) access to the
			/// virtual disk image file.
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This access right is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_DETACH = 0x00040000,

			/// <summary>
			/// Information retrieval access to the virtual disk. The caller must have READ access to the virtual disk image file.
			/// <para>
			/// <c>Windows 7 and Windows Server 2008 R2:</c> This access right is not supported for opening ISO virtual disks until Windows 8 and Windows Server 2012.
			/// </para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_GET_INFO = 0x00080000,

			/// <summary>
			/// Virtual disk creation access.
			/// <para>This flag is not supported for ISO virtual disks.</para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_CREATE = 0x00100000,

			/// <summary>
			/// Open the virtual disk to perform offline meta-operations. The caller must have (READ | WRITE) access to the virtual disk image file, up to
			/// RWDepth if working with a differencing chain.
			/// <para>If the virtual disk is part of a differencing chain, the backing store (host volume) is opened in RW exclusive mode up to RWDepth.</para>
			/// <para>This flag is not supported for ISO virtual disks.</para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_METAOPS = 0x00200000,

			/// <summary>Reserved.</summary>
			VIRTUAL_DISK_ACCESS_READ = 0x000d0000,

			/// <summary>
			/// Allows unrestricted access to the virtual disk. The caller must have unrestricted access rights to the virtual disk image file.
			/// <para>This flag is not supported for ISO virtual disks.</para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_ALL = 0x003f0000,

			/// <summary>
			/// Reserved.
			/// <para>This flag is not supported for ISO virtual disks.</para>
			/// </summary>
			VIRTUAL_DISK_ACCESS_WRITABLE = 0x00320000
		}

		/// <summary>Device type identifier.</summary>
		public enum VIRTUAL_STORAGE_TYPE_DEVICE_TYPE
		{
			/// <summary>Device type is unknown or not valid.</summary>
			VIRTUAL_STORAGE_TYPE_DEVICE_UNKNOWN = 0,

			/// <summary>
			/// CD or DVD image file device type. (.iso file)
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This value is not supported before Windows 8 and Windows Server 2012.</para>
			/// </summary>
			VIRTUAL_STORAGE_TYPE_DEVICE_ISO = 1,

			/// <summary>Virtual hard disk device type. (.vhd file)</summary>
			VIRTUAL_STORAGE_TYPE_DEVICE_VHD = 2,

			/// <summary>
			/// VHDX format virtual hard disk device type. (.vhdx file)
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This value is not supported before Windows 8 and Windows Server 2012.</para>
			/// </summary>
			VIRTUAL_STORAGE_TYPE_DEVICE_VHDX = 3
		}

		/// <summary>Attaches a virtual hard disk (VHD) or CD or DVD image file (ISO) by locating an appropriate VHD provider to accomplish the attachment.</summary>
		/// <param name="VirtualDiskHandle">A handle to an open virtual disk. For information on how to open a virtual disk, see the OpenVirtualDisk function.</param>
		/// <param name="SecurityDescriptor">
		/// An optional pointer to a SECURITY_DESCRIPTOR to apply to the attached virtual disk. If this parameter is NULL, the security descriptor of the virtual
		/// disk image file is used.
		/// <para>
		/// Ensure that the security descriptor that AttachVirtualDisk applies to the attached virtual disk grants the write attributes permission for the user,
		/// or that the security descriptor of the virtual disk image file grants the write attributes permission for the user if you specify NULL for this
		/// parameter. If the security descriptor does not grant write attributes permission for a user, Shell displays the following error when the user
		/// accesses the attached virtual disk: The Recycle Bin is corrupted. Do you want to empty the Recycle Bin for this drive?
		/// </para>
		/// </param>
		/// <param name="Flags">A valid combination of values of the ATTACH_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="ProviderSpecificFlags">Flags specific to the type of virtual disk being attached. May be zero if none are required.</param>
		/// <param name="Parameters">A pointer to a valid ATTACH_VIRTUAL_DISK_PARAMETERS structure that contains attachment parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// Status of the request.
		/// <para>If the function succeeds, the return value is ERROR_SUCCESS.</para>
		/// <para>If the function fails, the return value is an error code. For more information, see System Error Codes.</para>
		/// </returns>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int AttachVirtualDisk(SafeFileHandle VirtualDiskHandle, IntPtr SecurityDescriptor, ATTACH_VIRTUAL_DISK_FLAG Flags, uint ProviderSpecificFlags, ref ATTACH_VIRTUAL_DISK_PARAMETERS Parameters, [In] IntPtr Overlapped);

		/// <summary>Attaches a virtual hard disk (VHD) or CD or DVD image file (ISO) by locating an appropriate VHD provider to accomplish the attachment.</summary>
		/// <param name="VirtualDiskHandle">A handle to an open virtual disk. For information on how to open a virtual disk, see the OpenVirtualDisk function.</param>
		/// <param name="SecurityDescriptor">
		/// An optional pointer to a SECURITY_DESCRIPTOR to apply to the attached virtual disk. If this parameter is NULL, the security descriptor of the virtual
		/// disk image file is used.
		/// <para>
		/// Ensure that the security descriptor that AttachVirtualDisk applies to the attached virtual disk grants the write attributes permission for the user,
		/// or that the security descriptor of the virtual disk image file grants the write attributes permission for the user if you specify NULL for this
		/// parameter. If the security descriptor does not grant write attributes permission for a user, Shell displays the following error when the user
		/// accesses the attached virtual disk: The Recycle Bin is corrupted. Do you want to empty the Recycle Bin for this drive?
		/// </para>
		/// </param>
		/// <param name="Flags">A valid combination of values of the ATTACH_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="ProviderSpecificFlags">Flags specific to the type of virtual disk being attached. May be zero if none are required.</param>
		/// <param name="Parameters">A pointer to a valid ATTACH_VIRTUAL_DISK_PARAMETERS structure that contains attachment parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// Status of the request.
		/// <para>If the function succeeds, the return value is ERROR_SUCCESS.</para>
		/// <para>If the function fails, the return value is an error code. For more information, see System Error Codes.</para>
		/// </returns>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int AttachVirtualDisk(SafeFileHandle VirtualDiskHandle, IntPtr SecurityDescriptor, ATTACH_VIRTUAL_DISK_FLAG Flags, uint ProviderSpecificFlags, ref ATTACH_VIRTUAL_DISK_PARAMETERS Parameters, ref NativeOverlapped Overlapped);

		/// <summary>Reduces the size of a virtual hard disk (VHD) backing store file.</summary>
		/// <param name="VirtualDiskHandle">
		/// A handle to the open virtual disk, which must have been opened using the VIRTUAL_DISK_ACCESS_METAOPS flag in the VirtualDiskAccessMask parameter
		/// passed to OpenVirtualDisk. For information on how to open a virtual disk, see the OpenVirtualDisk function.
		/// </param>
		/// <param name="Flags">Must be the COMPACT_VIRTUAL_DISK_FLAG_NONE value (0) of the COMPACT_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="Parameters">A optional pointer to a valid COMPACT_VIRTUAL_DISK_PARAMETERS structure that contains compaction parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is an error code. For more information, see
		/// System Error Codes.
		/// </returns>
		/// <remarks>
		/// Compaction can be run only on a virtual disk that is dynamically expandable or differencing.
		/// <para>There are two different types of compaction.</para>
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// The first type, file-system-aware compaction, uses the NTFS file system to determine free space. This is done by attaching the VHD as a read-only
		/// device by including the VIRTUAL_DISK_ACCESS_METAOPS and VIRTUAL_DISK_ACCESS_ATTACH_RO flags in the VirtualDiskAccessMask parameter passed to
		/// OpenVirtualDisk, attaching the VHD by calling AttachVirtualDisk, and while the VHD is attached calling CompactVirtualDisk. Detaching the VHD before
		/// compaction is done can cause compaction to return failure before it is done (similar to cancellation of compaction).
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// The second type, file-system-agnostic compaction, does not involve the file system but only looks for VHD blocks filled entirely with zeros (0). This
		/// is done by including the VIRTUAL_DISK_ACCESS_METAOPS flag in the VirtualDiskAccessMask parameter passed to OpenVirtualDisk, and calling CompactVirtualDisk.
		/// </description>
		/// </item>
		/// </list>
		/// <para>
		/// File-system-aware compaction is the most efficient compaction type but using first the file-system-aware compaction followed by the
		/// file-system-agnostic compaction will produce the smallest VHD.
		/// </para>
		/// <para>
		/// A compaction operation on a virtual disk can be safely interrupted and re-run later. Re-opening a virtual disk file that has been interrupted may
		/// result in the reduction of a virtual disk file's size at the time of opening.
		/// </para>
		/// <para>Compaction can be CPU-intensive and/or I/O-intensive, depending on how large the virtual disk is and how many blocks require movement.</para>
		/// <para>The CompactVirtualDisk function runs on the virtual disk in the same security context as the caller.</para>
		/// </remarks>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int CompactVirtualDisk(SafeFileHandle VirtualDiskHandle, COMPACT_VIRTUAL_DISK_FLAG Flags, ref COMPACT_VIRTUAL_DISK_PARAMETERS Parameters, ref NativeOverlapped Overlapped);

		/// <summary>Reduces the size of a virtual hard disk (VHD) backing store file.</summary>
		/// <param name="VirtualDiskHandle">
		/// A handle to the open virtual disk, which must have been opened using the VIRTUAL_DISK_ACCESS_METAOPS flag in the VirtualDiskAccessMask parameter
		/// passed to OpenVirtualDisk. For information on how to open a virtual disk, see the OpenVirtualDisk function.
		/// </param>
		/// <param name="Flags">Must be the COMPACT_VIRTUAL_DISK_FLAG_NONE value (0) of the COMPACT_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="Parameters">A optional pointer to a valid COMPACT_VIRTUAL_DISK_PARAMETERS structure that contains compaction parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is an error code. For more information, see
		/// System Error Codes.
		/// </returns>
		/// <remarks>
		/// Compaction can be run only on a virtual disk that is dynamically expandable or differencing.
		/// <para>There are two different types of compaction.</para>
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// The first type, file-system-aware compaction, uses the NTFS file system to determine free space. This is done by attaching the VHD as a read-only
		/// device by including the VIRTUAL_DISK_ACCESS_METAOPS and VIRTUAL_DISK_ACCESS_ATTACH_RO flags in the VirtualDiskAccessMask parameter passed to
		/// OpenVirtualDisk, attaching the VHD by calling AttachVirtualDisk, and while the VHD is attached calling CompactVirtualDisk. Detaching the VHD before
		/// compaction is done can cause compaction to return failure before it is done (similar to cancellation of compaction).
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// The second type, file-system-agnostic compaction, does not involve the file system but only looks for VHD blocks filled entirely with zeros (0). This
		/// is done by including the VIRTUAL_DISK_ACCESS_METAOPS flag in the VirtualDiskAccessMask parameter passed to OpenVirtualDisk, and calling CompactVirtualDisk.
		/// </description>
		/// </item>
		/// </list>
		/// <para>
		/// File-system-aware compaction is the most efficient compaction type but using first the file-system-aware compaction followed by the
		/// file-system-agnostic compaction will produce the smallest VHD.
		/// </para>
		/// <para>
		/// A compaction operation on a virtual disk can be safely interrupted and re-run later. Re-opening a virtual disk file that has been interrupted may
		/// result in the reduction of a virtual disk file's size at the time of opening.
		/// </para>
		/// <para>Compaction can be CPU-intensive and/or I/O-intensive, depending on how large the virtual disk is and how many blocks require movement.</para>
		/// <para>The CompactVirtualDisk function runs on the virtual disk in the same security context as the caller.</para>
		/// </remarks>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int CompactVirtualDisk(SafeFileHandle VirtualDiskHandle, COMPACT_VIRTUAL_DISK_FLAG Flags, ref COMPACT_VIRTUAL_DISK_PARAMETERS Parameters, IntPtr Overlapped);

		/// <summary>Creates a virtual hard disk (VHD) image file, either using default parameters or using an existing VHD or physical disk.</summary>
		/// <param name="VirtualStorageType">A pointer to a VIRTUAL_STORAGE_TYPE structure that contains the desired disk type and vendor information.</param>
		/// <param name="Path">A pointer to a valid string that represents the path to the new virtual disk image file.</param>
		/// <param name="VirtualDiskAccessMask">The VIRTUAL_DISK_ACCESS_MASK value to use when opening the newly created virtual disk file.</param>
		/// <param name="SecurityDescriptor">
		/// An optional pointer to a SECURITY_DESCRIPTOR to apply to the virtual disk image file. If this parameter is NULL, the parent directory's security
		/// descriptor will be used.
		/// </param>
		/// <param name="Flags">Creation flags, which must be a valid combination of the CREATE_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="ProviderSpecificFlags">Flags specific to the type of virtual disk being created. May be zero if none are required.</param>
		/// <param name="Parameters">A pointer to a valid CREATE_VIRTUAL_DISK_PARAMETERS structure that contains creation parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <param name="Handle">A pointer to the handle object that represents the newly created virtual disk.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		public static extern int CreateVirtualDisk(ref VIRTUAL_STORAGE_TYPE VirtualStorageType, string Path, VIRTUAL_DISK_ACCESS_MASK VirtualDiskAccessMask, IntPtr SecurityDescriptor, CREATE_VIRTUAL_DISK_FLAG Flags, int ProviderSpecificFlags, ref CREATE_VIRTUAL_DISK_PARAMETERS Parameters, IntPtr Overlapped, ref SafeFileHandle Handle);

		/// <summary>Creates a virtual hard disk (VHD) image file, either using default parameters or using an existing VHD or physical disk.</summary>
		/// <param name="VirtualStorageType">A pointer to a VIRTUAL_STORAGE_TYPE structure that contains the desired disk type and vendor information.</param>
		/// <param name="Path">A pointer to a valid string that represents the path to the new virtual disk image file.</param>
		/// <param name="VirtualDiskAccessMask">The VIRTUAL_DISK_ACCESS_MASK value to use when opening the newly created virtual disk file.</param>
		/// <param name="SecurityDescriptor">
		/// An optional pointer to a SECURITY_DESCRIPTOR to apply to the virtual disk image file. If this parameter is NULL, the parent directory's security
		/// descriptor will be used.
		/// </param>
		/// <param name="Flags">Creation flags, which must be a valid combination of the CREATE_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="ProviderSpecificFlags">Flags specific to the type of virtual disk being created. May be zero if none are required.</param>
		/// <param name="Parameters">A pointer to a valid CREATE_VIRTUAL_DISK_PARAMETERS structure that contains creation parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <param name="Handle">A pointer to the handle object that represents the newly created virtual disk.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		public static extern int CreateVirtualDisk(ref VIRTUAL_STORAGE_TYPE VirtualStorageType, string Path, VIRTUAL_DISK_ACCESS_MASK VirtualDiskAccessMask, IntPtr SecurityDescriptor, CREATE_VIRTUAL_DISK_FLAG Flags, int ProviderSpecificFlags, ref CREATE_VIRTUAL_DISK_PARAMETERS Parameters, ref NativeOverlapped Overlapped, ref SafeFileHandle Handle);

		/// <summary>
		/// Detaches a virtual hard disk (VHD) or CD or DVD image file (ISO) by locating an appropriate virtual disk provider to accomplish the operation.
		/// </summary>
		/// <param name="VirtualDiskHandle">
		/// A handle to an open virtual disk, which must have been opened using the VIRTUAL_DISK_ACCESS_DETACH flag set in the VirtualDiskAccessMask parameter to
		/// the OpenVirtualDisk function. For information on how to open a virtual disk, see the OpenVirtualDisk function.
		/// </param>
		/// <param name="Flags">A valid combination of values of the DETACH_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="ProviderSpecificFlags">Flags specific to the type of virtual disk being detached. May be zero if none are required.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is an error code. For more information, see
		/// System Error Codes.
		/// </returns>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int DetachVirtualDisk(SafeFileHandle VirtualDiskHandle, DETACH_VIRTUAL_DISK_FLAG Flags, int ProviderSpecificFlags);

		/// <summary>Increases the size of a fixed or dynamic virtual hard disk (VHD).</summary>
		/// <param name="VirtualDiskHandle">A handle to the open VHD, which must have been opened using the VIRTUAL_DISK_ACCESS_METAOPS flag.</param>
		/// <param name="Flags">Must be the EXPAND_VIRTUAL_DISK_FLAG_NONE value of the EXPAND_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="Parameters">A pointer to a valid EXPAND_VIRTUAL_DISK_PARAMETERS structure that contains expansion parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", ExactSpelling = true)]
		public static extern int ExpandVirtualDisk(SafeFileHandle VirtualDiskHandle, EXPAND_VIRTUAL_DISK_FLAG Flags, ref EXPAND_VIRTUAL_DISK_PARAMETERS Parameters, IntPtr Overlapped);

		/// <summary>Returns the relationships between virtual hard disks (VHDs) or the volumes contained within those disks and their parent disk or volume.</summary>
		/// <param name="ObjectHandle">A handle to an open VHD.</param>
		/// <param name="Flags">A valid combination of GET_STORAGE_DEPENDENCY_FLAG values.</param>
		/// <param name="StorageDependencyInfoSize">
		/// Size, in bytes, of the STORAGE_DEPENDENCY_INFO structure that the StorageDependencyInfo parameter refers to.
		/// </param>
		/// <param name="StorageDependencyInfo">A pointer to a valid STORAGE_DEPENDENCY_INFO structure, which is a variable-length structure.</param>
		/// <param name="SizeUsed">An optional pointer to a ULONG that receives the size used.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", ExactSpelling = true)]
		public static extern int GetStorageDependencyInformation(SafeFileHandle ObjectHandle, GET_STORAGE_DEPENDENCY_FLAG Flags, int StorageDependencyInfoSize, IntPtr StorageDependencyInfo, ref int SizeUsed); // TODO: Convert to SafeHGlobalHandle

		/// <summary>Retrieves information about a virtual hard disk (VHD).</summary>
		/// <param name="VirtualDiskHandle">A handle to the open VHD, which must have been opened using the VIRTUAL_DISK_ACCESS_GET_INFO flag.</param>
		/// <param name="VirtualDiskInfoSize">A pointer to a ULONG that contains the size of the VirtualDiskInfo parameter.</param>
		/// <param name="VirtualDiskInfo">
		/// A pointer to a valid GET_VIRTUAL_DISK_INFO structure. The format of the data returned is dependent on the value passed in the Version member by the caller.
		/// </param>
		/// <param name="SizeUsed">A pointer to a ULONG that contains the size used.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", ExactSpelling = true)]
		public static extern int GetVirtualDiskInformation(SafeFileHandle VirtualDiskHandle, ref int VirtualDiskInfoSize, IntPtr VirtualDiskInfo, ref int SizeUsed); // TODO: Convert to SafeHGlobalHandle

		/// <summary>Checks the progress of an asynchronous virtual hard disk (VHD) operation.</summary>
		/// <param name="VirtualDiskHandle">A valid handle to a virtual disk with a pending asynchronous operation.</param>
		/// <param name="Overlapped">
		/// A pointer to a valid OVERLAPPED structure. This parameter must reference the same structure previously sent to the virtual disk operation being
		/// checked for progress.
		/// </param>
		/// <param name="Progress">A pointer to a VIRTUAL_DISK_PROGRESS structure that receives the current virtual disk operation progress.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Progress parameter will be populated with the current virtual disk operation
		/// progress. If the function fails, the return value is an error code and the value of the Progress parameter is undefined. For more information, see
		/// System Error Codes.
		/// </returns>
		[DllImport(nameof(VirtDisk), ExactSpelling = true)]
		public static extern int GetVirtualDiskOperationProgress(SafeFileHandle VirtualDiskHandle, ref NativeOverlapped Overlapped, ref VIRTUAL_DISK_PROGRESS Progress);

		/// <summary>Retrieves the path to the physical device object that contains a virtual hard disk (VHD).</summary>
		/// <param name="VirtualDiskHandle">A handle to the open VHD, which must have been opened using the VIRTUAL_DISK_ACCESS_GET_INFO flag.</param>
		/// <param name="DiskPathSizeInBytes">The size, in bytes, of the buffer pointed to by the DiskPath parameter.</param>
		/// <param name="DiskPath">A target buffer to receive the path of the physical disk device that contains the VHD.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		public static extern int GetVirtualDiskPhysicalPath(SafeFileHandle VirtualDiskHandle, ref int DiskPathSizeInBytes, StringBuilder DiskPath);

		/// <summary>Merges a child virtual hard disk (VHD) in a differencing chain with parent disks in the chain.</summary>
		/// <param name="VirtualDiskHandle">A handle to the open VHD, which must have been opened using the VIRTUAL_DISK_ACCESS_METAOPS flag.</param>
		/// <param name="Flags">Must be the MERGE_VIRTUAL_DISK_FLAG_NONE value of the MERGE_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="Parameters">A pointer to a valid MERGE_VIRTUAL_DISK_PARAMETERS structure that contains merge parameter data.</param>
		/// <param name="Overlapped">An optional pointer to a valid OVERLAPPED structure if asynchronous operation is desired.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", ExactSpelling = true)]
		public static extern int MergeVirtualDisk(SafeFileHandle VirtualDiskHandle, MERGE_VIRTUAL_DISK_FLAG Flags, ref MERGE_VIRTUAL_DISK_PARAMETERS Parameters, IntPtr Overlapped);

		/// <summary>Opens a virtual hard disk (VHD) or CD or DVD image file (ISO) for use.</summary>
		/// <param name="VirtualStorageType">A pointer to a valid VIRTUAL_STORAGE_TYPE structure.</param>
		/// <param name="Path">A pointer to a valid path to the virtual disk image to open.</param>
		/// <param name="VirtualDiskAccessMask">A valid value of the VIRTUAL_DISK_ACCESS_MASK enumeration.</param>
		/// <param name="Flags">A valid combination of values of the OPEN_VIRTUAL_DISK_FLAG enumeration.</param>
		/// <param name="Parameters">An optional pointer to a valid OPEN_VIRTUAL_DISK_PARAMETERS structure. Can be NULL.</param>
		/// <param name="Handle">A pointer to the handle object that represents the open virtual disk.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS (0) and the Handle parameter contains a valid pointer to the new virtual disk object.
		/// <para>
		/// If the function fails, the return value is an error code and the value of the Handle parameter is undefined. For more information, see System Error Codes.
		/// </para>
		/// </returns>
		[DllImport(nameof(VirtDisk), ExactSpelling = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Unicode)]
		public static extern int OpenVirtualDisk([In] ref VIRTUAL_STORAGE_TYPE VirtualStorageType, string Path, VIRTUAL_DISK_ACCESS_MASK VirtualDiskAccessMask, OPEN_VIRTUAL_DISK_FLAG Flags, [In] ref OPEN_VIRTUAL_DISK_PARAMETERS Parameters, out SafeFileHandle Handle);

		/// <summary>Sets information about a virtual hard disk (VHD).</summary>
		/// <param name="VirtualDiskHandle">A handle to the open VHD, which must have been opened using the VIRTUAL_DISK_ACCESS_METAOPS flag.</param>
		/// <param name="VirtualDiskInfo">A pointer to a valid SET_VIRTUAL_DISK_INFO structure.</param>
		/// <returns>
		/// If the function succeeds, the return value is ERROR_SUCCESS and the Handle parameter contains a valid pointer to the new virtual disk object. If the
		/// function fails, the return value is an error code and the value of the Handle parameter is undefined.
		/// </returns>
		[DllImport("virtdisk.dll", ExactSpelling = true)]
		public static extern int SetVirtualDiskInformation(SafeFileHandle VirtualDiskHandle, ref SET_VIRTUAL_DISK_INFO VirtualDiskInfo);

		/// <summary>Contains virtual hard disk (VHD) attach request parameters.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct ATTACH_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// A ATTACH_VIRTUAL_DISK_VERSION enumeration that specifies the version of the ATTACH_VIRTUAL_DISK_PARAMETERS structure being passed to or from the
			/// VHD functions.
			/// </summary>
			public ATTACH_VIRTUAL_DISK_VERSION Version;

			/// <summary>Reserved.</summary>
			public uint Reserved;

			/// <summary>Gets the default value for this structure. This is currently the only valid value for <see cref="ATTACH_VIRTUAL_DISK_PARAMETERS"/>.</summary>
			public static ATTACH_VIRTUAL_DISK_PARAMETERS Default => new ATTACH_VIRTUAL_DISK_PARAMETERS { Version = ATTACH_VIRTUAL_DISK_VERSION.ATTACH_VIRTUAL_DISK_VERSION_1 };
		}

		/// <summary>Contains virtual hard disk (VHD) compacting parameters.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct COMPACT_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// A COMPACT_VIRTUAL_DISK_VERSION enumeration that specifies the version of the COMPACT_VIRTUAL_DISK_PARAMETERS structure being passed to or from
			/// the virtual hard disk (VHD) functions.
			/// </summary>
			public COMPACT_VIRTUAL_DISK_VERSION Version;

			/// <summary>Reserved. Must be set to zero.</summary>
			public uint Reserved;

			/// <summary>Gets the default value for this structure. This is currently the only valid value for <see cref="COMPACT_VIRTUAL_DISK_PARAMETERS"/>.</summary>
			public static COMPACT_VIRTUAL_DISK_PARAMETERS Default => new COMPACT_VIRTUAL_DISK_PARAMETERS { Version = COMPACT_VIRTUAL_DISK_VERSION.COMPACT_VIRTUAL_DISK_VERSION_1 };
		}

		/// <summary>Contains virtual disk creation parameters, providing control over, and information about, the newly created virtual disk.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct CREATE_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// A CREATE_VIRTUAL_DISK_VERSION enumeration that specifies the version of the CREATE_VIRTUAL_DISK_PARAMETERS structure being passed to or from the
			/// virtual hard disk (VHD) functions.
			/// </summary>
			public CREATE_VIRTUAL_DISK_VERSION Version;

			/// <summary>A structure.</summary>
			public CREATE_VIRTUAL_DISK_PARAMETERS_Version1 Version1;
		}

		/// <summary></summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CREATE_VIRTUAL_DISK_PARAMETERS_Version1
		{
			/// <summary>Unique identifier to assign to the virtual disk object. If this member is set to zero, a unique identifier is created by the system.</summary>
			public Guid UniqueId;

			/// <summary>
			/// The maximum virtual size of the virtual disk object. Must be a multiple of 512. If a ParentPath is specified, this value must be zero. If a
			/// SourcePath is specified, this value can be zero to specify the size of the source VHD to be used, otherwise the size specified must be greater
			/// than or equal to the size of the source disk.
			/// </summary>
			public ulong MaximumSize;

			/// <summary>
			/// Internal size of the virtual disk object blocks. If value is 0, block size will be automatically matched to the parent or source disk's setting
			/// if ParentPath or SourcePath is specified (otherwise a block size of 2MB will be used).
			/// </summary>
			public uint BlockSizeInBytes;

			/// <summary>Internal size of the virtual disk object sectors. Must be set to 512.</summary>
			public uint SectorSizeInBytes;

			/// <summary>
			/// Optional path to a parent virtual disk object. Associates the new virtual disk with an existing virtual disk. If this parameter is not NULL,
			/// SourcePath must be NULL.
			/// </summary>
			public string ParentPath;

			/// <summary>
			/// Optional path to pre-populate the new virtual disk object with block data from an existing disk. This path may refer to a VHD or a physical disk.
			/// If this parameter is not NULL, ParentPath must be NULL.
			/// </summary>
			public string SourcePath;
		}

		/// <summary>Contains virtual disk expansion request parameters.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct EXPAND_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// An EXPAND_VIRTUAL_DISK_VERSION enumeration that specifies the version of the EXPAND_VIRTUAL_DISK_PARAMETERS structure being passed to or from the
			/// virtual hard disk (VHD) functions.
			/// </summary>
			public EXPAND_VIRTUAL_DISK_VERSION Version;

			/// <summary>New size, in bytes, for the expansion request.</summary>
			public ulong NewSize;
		}

		/// <summary>Contains virtual hard disk (VHD) information.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct GET_VIRTUAL_DISK_INFO
		{
			/// <summary>
			/// A GET_VIRTUAL_DISK_INFO_VERSION enumeration that specifies the version of the GET_VIRTUAL_DISK_INFO structure being passed to or from the VHD
			/// functions. This determines what parts of this structure will be used.
			/// </summary>
			public GET_VIRTUAL_DISK_INFO_VERSION Version;

			/// <summary></summary>
			public GET_VIRTUAL_DISK_INFO_Union Union;
		}

		/// <summary></summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct GET_VIRTUAL_DISK_INFO_ParentLocation
		{
			/// <summary>Parent resolution. TRUE if the parent backing store was successfully resolved, FALSE if not.</summary>
			[MarshalAsAttribute(UnmanagedType.Bool)]
			public bool ParentResolved;

			/// <summary>
			/// If the ParentResolved member is TRUE, contains the path of the parent backing store. If the ParentResolved member is FALSE, contains all of the
			/// parent paths present in the search list.
			/// </summary>
			public string ParentLocationBuffer;
		}

		/// <summary>A structure.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct GET_VIRTUAL_DISK_INFO_Size
		{
			/// <summary>Virtual size of the VHD, in bytes.</summary>
			public ulong VirtualSize;

			/// <summary>Physical size of the VHD on disk, in bytes.</summary>
			public ulong PhysicalSize;

			/// <summary>Block size of the VHD, in bytes.</summary>
			public uint BlockSize;

			/// <summary>Sector size of the VHD, in bytes.</summary>
			public uint SectorSize;
		}

		/// <summary></summary>
		[StructLayout(LayoutKind.Explicit)]
		public struct GET_VIRTUAL_DISK_INFO_Union
		{
			/// <summary></summary>
			[FieldOffset(0)]
			public GET_VIRTUAL_DISK_INFO_Size Size;

			/// <summary>Unique identifier of the VHD.</summary>
			[FieldOffset(0)]
			public Guid Identifier;

			/// <summary></summary>
			[FieldOffset(0)]
			public GET_VIRTUAL_DISK_INFO_ParentLocation ParentLocation;

			/// <summary>Unique identifier of the parent disk backing store.</summary>
			[FieldOffset(0)]
			public Guid ParentIdentifier;

			/// <summary>Internal time stamp of the parent disk backing store.</summary>
			[FieldOffset(0)]
			public uint ParentTimestamp;

			/// <summary>VIRTUAL_STORAGE_TYPE structure containing information about the type of VHD.</summary>
			[FieldOffset(0)]
			public VIRTUAL_STORAGE_TYPE VirtualStorageType;

			/// <summary>Provider-specific subtype.</summary>
			[FieldOffset(0)]
			public uint ProviderSubtype;
		}

		/// <summary>Contains virtual disk merge request parameters.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct MERGE_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// A MERGE_VIRTUAL_DISK_VERSION enumeration that specifies the version of the MERGE_VIRTUAL_DISK_PARAMETERS structure being passed to or from the
			/// VHD functions.
			/// </summary>
			public MERGE_VIRTUAL_DISK_VERSION Version;

			/// <summary>
			/// Depth of the merge request. This is the number of parent disks in the differencing chain to merge together. Note that RWDepth of the VHD must be
			/// set to equal to or greater than this value.
			/// </summary>
			public uint RWDepth;
		}

		/// <summary>Contains virtual disk open request parameters.</summary>
		[StructLayout(LayoutKind.Explicit)]
		public struct OPEN_VIRTUAL_DISK_PARAMETERS
		{
			/// <summary>
			/// An OPEN_VIRTUAL_DISK_VERSION enumeration that specifies the version of the OPEN_VIRTUAL_DISK_PARAMETERS structure being passed to or from the VHD functions.
			/// </summary>
			[FieldOffset(0)]
			public OPEN_VIRTUAL_DISK_VERSION Version;

			/// <summary>
			/// This value is used if the Version member is OPEN_VIRTUAL_DISK_VERSION_1 (1).
			/// <para>
			/// Indicates the number of stores, beginning with the child, of the backing store chain to open as read/write. The remaining stores in the
			/// differencing chain will be opened read-only. This is necessary for merge operations to succeed.
			/// </para>
			/// <list type="table">
			/// <listheader>
			/// <term>Value</term>
			/// <term>Meaning</term>
			/// </listheader>
			/// <item>
			/// <term>0</term>
			/// <term>Do not open for read/write at any depth. This value should be used for read-only operations.</term>
			/// </item>
			/// <item>
			/// <term>OPEN_VIRTUAL_DISK_RW_DEPTH_DEFAULT (1)</term>
			/// <term>Default value to use if no other value is desired.</term>
			/// </item>
			/// <item>
			/// <term>n (user-defined)</term>
			/// <term>This integer value should be the number of merge levels plus one, if a merge operation is intended.</term>
			/// </item>
			/// </list>
			/// </summary>
			[FieldOffset(4)]
			public uint RWDepth;

			/// <summary>
			/// This value is used if the Version member is OPEN_VIRTUAL_DISK_VERSION_2 (2).
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This structure is not supported until Windows 8 and Windows Server 2012.</para>
			/// <para>If TRUE, indicates the handle is only to be used to get information on the virtual disk.</para>
			/// </summary>
			[FieldOffset(4)]
			[MarshalAs(UnmanagedType.Bool)]
			public bool GetInfoOnly;

			/// <summary>
			/// This value is used if the Version member is OPEN_VIRTUAL_DISK_VERSION_2 (2).
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This structure is not supported until Windows 8 and Windows Server 2012.</para>
			/// <para>If TRUE, indicates the file backing store is to be opened as read-only.</para>
			/// </summary>
			[FieldOffset(8)]
			[MarshalAs(UnmanagedType.Bool)]
			public bool ReadOnly;

			/// <summary>
			/// This value is used if the Version member is OPEN_VIRTUAL_DISK_VERSION_2 (2).
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This structure is not supported until Windows 8 and Windows Server 2012.</para>
			/// <para>Resiliency GUID to specify when opening files.</para>
			/// </summary>
			[FieldOffset(12)]
			public Guid ResiliencyGuid;

			/// <summary>Initializes a new instance of the <see cref="OPEN_VIRTUAL_DISK_PARAMETERS"/> struct setting Version to OPEN_VIRTUAL_DISK_VERSION_1.</summary>
			/// <param name="rwDepth">
			/// <para>
			/// Indicates the number of stores, beginning with the child, of the backing store chain to open as read/write. The remaining stores in the
			/// differencing chain will be opened read-only. This is necessary for merge operations to succeed.
			/// </para>
			/// <list type="table">
			/// <listheader>
			/// <term>Value</term>
			/// <term>Meaning</term>
			/// </listheader>
			/// <item>
			/// <term>0</term>
			/// <term>Do not open for read/write at any depth. This value should be used for read-only operations.</term>
			/// </item>
			/// <item>
			/// <term>OPEN_VIRTUAL_DISK_RW_DEPTH_DEFAULT (1)</term>
			/// <term>Default value to use if no other value is desired.</term>
			/// </item>
			/// <item>
			/// <term>n (user-defined)</term>
			/// <term>This integer value should be the number of merge levels plus one, if a merge operation is intended.</term>
			/// </item>
			/// </list>
			/// </param>
			public OPEN_VIRTUAL_DISK_PARAMETERS(uint rwDepth) : this()
			{
				Version = OPEN_VIRTUAL_DISK_VERSION.OPEN_VIRTUAL_DISK_VERSION_1;
				RWDepth = rwDepth;
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="OPEN_VIRTUAL_DISK_PARAMETERS"/> struct setting Version to OPEN_VIRTUAL_DISK_VERSION_2.
			/// <para><c>Windows 7 and Windows Server 2008 R2:</c> This constructor is not supported until Windows 8 and Windows Server 2012.</para>
			/// </summary>
			/// <param name="getInfoOnly">If TRUE, indicates the handle is only to be used to get information on the virtual disk.</param>
			/// <param name="readOnly">If TRUE, indicates the file backing store is to be opened as read-only.</param>
			/// <param name="resiliencyGuid">Resiliency GUID to specify when opening files.</param>
			public OPEN_VIRTUAL_DISK_PARAMETERS(bool getInfoOnly, bool readOnly, Guid resiliencyGuid) : this()
			{
				if (Environment.OSVersion.Version < new Version(6, 2))
					throw new InvalidOperationException();
				Version = OPEN_VIRTUAL_DISK_VERSION.OPEN_VIRTUAL_DISK_VERSION_2;
				GetInfoOnly = getInfoOnly;
				ReadOnly = readOnly;
				ResiliencyGuid = resiliencyGuid;
			}
		}

		/// <summary>Contains virtual hard disk (VHD) information for set request.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SET_VIRTUAL_DISK_INFO
		{
			/// <summary>
			/// A SET_VIRTUAL_DISK_INFO_VERSION enumeration that specifies the version of the SET_VIRTUAL_DISK_INFO structure being passed to or from the VHD
			/// functions. This determines the type of information set.
			/// </summary>
			public SET_VIRTUAL_DISK_INFO_VERSION Version;

			/// <summary></summary>
			public SET_VIRTUAL_DISK_INFO_Union Union;
		}

		/// <summary></summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SET_VIRTUAL_DISK_INFO_Union
		{
			/// <summary>Path to the parent backing store.</summary>
			public string ParentFilePath;

			/// <summary>Unique identifier of the VHD.</summary>
			public Guid UniqueIdentifier;
		}

		/// <summary>Contains storage dependency information.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct STORAGE_DEPENDENCY_INFO
		{
			/// <summary>
			/// A STORAGE_DEPENDENCY_INFO_VERSION enumeration that specifies the version of the information structure being passed to or from the VHD functions.
			/// Can be STORAGE_DEPENDENCY_INFO_TYPE_1 or STORAGE_DEPENDENCY_INFO_TYPE_2.
			/// </summary>
			public STORAGE_DEPENDENCY_INFO_VERSION Version;

			/// <summary>Number of entries returned in the following unioned members.</summary>
			public int NumberEntries;

			/// <summary></summary>
			public STORAGE_DEPENDENCY_INFO_Union Union;
		}

		/// <summary>Contains storage dependency information for type 1.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct STORAGE_DEPENDENCY_INFO_TYPE_1
		{
			/// <summary>A DEPENDENT_DISK_FLAG enumeration.</summary>
			public DEPENDENT_DISK_FLAG DependencyTypeFlags;

			/// <summary>Flags specific to the VHD provider.</summary>
			public uint ProviderSpecificFlags;

			/// <summary>A VIRTUAL_STORAGE_TYPE structure.</summary>
			public VIRTUAL_STORAGE_TYPE VirtualStorageType;
		}

		/// <summary>Contains storage dependency information for type 2.</summary>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct STORAGE_DEPENDENCY_INFO_TYPE_2
		{
			/// <summary>A DEPENDENT_DISK_FLAG enumeration.</summary>
			public DEPENDENT_DISK_FLAG DependencyTypeFlags;

			/// <summary>Flags specific to the VHD provider.</summary>
			public uint ProviderSpecificFlags;

			/// <summary>A VIRTUAL_STORAGE_TYPE structure.</summary>
			public VIRTUAL_STORAGE_TYPE VirtualStorageType;

			/// <summary>The ancestor level.</summary>
			public uint AncestorLevel;

			/// <summary>The device name of the dependent device.</summary>
			public string DependencyDeviceName;

			/// <summary>The host disk volume name.</summary>
			public string HostVolumeName;

			/// <summary>The name of the dependent volume, if any.</summary>
			public string DependentVolumeName;

			/// <summary>The relative path to the dependent volume.</summary>
			public string DependentVolumeRelativePath;
		}

		/// <summary></summary>
		[StructLayout(LayoutKind.Explicit)]
		public struct STORAGE_DEPENDENCY_INFO_Union
		{
			/// <summary>Variable-length array containing STORAGE_DEPENDENCY_INFO_TYPE_1 structures.</summary>
			[FieldOffset(0)]
			public STORAGE_DEPENDENCY_INFO_TYPE_1 Version1Entries;

			/// <summary>Variable-length array containing STORAGE_DEPENDENCY_INFO_TYPE_2 structures.</summary>
			[FieldOffset(0)]
			public STORAGE_DEPENDENCY_INFO_TYPE_2 Version2Entries;
		}

		/// <summary>Contains the progress and result data for the current virtual disk operation, used by the GetVirtualDiskOperationProgress function.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct VIRTUAL_DISK_PROGRESS
		{
			/// <summary>
			/// A system error code status value, this member will be ERROR_IO_PENDING if the operation is still in progress; otherwise, the value is the result
			/// code of the completed operation.
			/// </summary>
			public uint OperationStatus;

			/// <summary>
			/// The current progress of the operation, used in conjunction with the CompletionValue member. This value is meaningful only if OperationStatus is ERROR_IO_PENDING.
			/// </summary>
			public ulong CurrentValue;

			/// <summary>
			/// The value that the CurrentValue member would be if the operation were complete. This value is meaningful only if OperationStatus is ERROR_IO_PENDING.
			/// </summary>
			public ulong CompletionValue;
		}

		/// <summary>Device type identifier.</summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct VIRTUAL_STORAGE_TYPE
		{
			/// <summary>The device identifier.</summary>
			public VIRTUAL_STORAGE_TYPE_DEVICE_TYPE DeviceId;

			/// <summary>Vendor-unique identifier.</summary>
			public Guid VendorId;

			/// <summary>Gets an instance of <see cref="VIRTUAL_STORAGE_TYPE"/> that represents a Microsoft Virtual Hard Drive or .vhd file.</summary>
			public static VIRTUAL_STORAGE_TYPE VHD => new VIRTUAL_STORAGE_TYPE { DeviceId = VIRTUAL_STORAGE_TYPE_DEVICE_TYPE.VIRTUAL_STORAGE_TYPE_DEVICE_VHD, VendorId = VIRTUAL_STORAGE_TYPE_VENDOR_MICROSOFT };
		}
	}
}