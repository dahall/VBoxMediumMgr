using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VirtualBox;
using VirtualBoxAPI;

namespace VBoxMediumMgr
{
	internal class DiskInfo
	{
		internal DiskInfo(IMedium med)
		{
			UUID = med.Id;
			Update(med);
		}

		//public MediumType[] AllowedTypes { get; internal set; }

		public string AttachedTo { get; internal set; }

		public string[] AttachedToIds { get; internal set; }

		public string Description { get; internal set; }

		public DeviceType DeviceType { get; internal set; }

		public bool Differencing { get; internal set; }

		public string EncryptionKey { get; internal set; }

		public string Format { get; set; }

		public bool HasChildren { get; internal set; }

		public string Location { get; internal set; }

		public MediumType MediumType { get; internal set; }

		public string Name { get; internal set; }

		public Dictionary<string, string> Properties { get; } = new Dictionary<string, string>();

		public bool ReadOnly { get; internal set; }

		public long Size { get; internal set; }

		public MediumState State { get; internal set; }

		public string UUID { get; }

		public MediumVariant Variant { get; internal set; }

		public long VirtualSize { get; internal set; }

		internal Guid Key => UUID == null ? Guid.Empty : new Guid(UUID);

		public override string ToString() => $"{Path.GetFileName(Location)} ({Main.GetDisplayString(MediumType)}, {Main.SizeStr(VirtualSize)})";

		internal void Update(IMedium med)
		{
			if (med.Id != UUID) return;
			//AllowedTypes = med.AllowedTypes.Cast<MediumType>().ToArray();
			Description = med.Description;
			DeviceType = med.DeviceType;
			Differencing = med.Parent != null;
			HasChildren = med.Children != null && med.Children.Length > 0;
			Format = med.Format;
			Location = med.Location;
			Variant = med.Variant.Cast<MediumVariant>().Aggregate((cur, next) => cur | next);
			VirtualSize = med.LogicalSize;
			Name = med.Name;
			ReadOnly = med.ReadOnly != 0;
			Size = med.Size;
			State = med.State;
			MediumType = med.Type;
			string cypher = null;
			try { med.GetEncryptionSettings(out cypher); } catch { }
			EncryptionKey = cypher;
			AttachedToIds = med.MachineIds.Cast<string>().ToArray();
			AttachedTo = string.Join(", ", Client.VBox.Machines.Cast<IMachine>().Where(m => AttachedToIds.Any(id => string.Equals(m.Id, id, StringComparison.Ordinal))).Select(m => m.Name));
			//med.MediumFormat.DescribeProperties(out Array pNames, out Array pDesc, out Array pTypes, out Array pFlags, out Array pDef);
			var props = med.GetProperties(null, out Array retNames);
			Properties.Clear();
			for (var i = 0; i < retNames.Length; i++)
				Properties.Add(retNames.GetValue(i)?.ToString(), props.GetValue(i)?.ToString());
		}
	}
}