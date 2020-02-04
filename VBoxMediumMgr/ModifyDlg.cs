using System;
using System.Linq;
using System.Windows.Forms;
using VirtualBox;

namespace VBoxMediumMgr
{
	public partial class ModifyDlg : Form
	{
		private const string instr = @"{\rtf1\ansi
{\pard
Please choose one of the following modes and press {\b
OK
} to proceed or {\b
Cancel
} otherwise.
\par}
}";

		private const string not = @"{{\rtf1\ansi
{{\pard
You are about to change the settings of the disk image file {{\b
{0}
}}.
\par}}
}}";

		private static readonly string[] ModeDesc =
		{
			"This type of medium is attached directly or indirectly, preserved when taking snapshots.",
			"This type of medium is attached indirectly, changes are wiped out the next time the virtual machine is started.",
			"This type of medium is attached directly, ignored when taking snapshots.",
			"This type of medium is attached directly, allowed to be used concurrently by several machines.",
			"",
			"This type of medium is attached indirectly, so that one base medium can be used for several VMs which have their own differencing medium to store their modifications."
		};

		private readonly MediumType initialType;

		public ModifyDlg(string path, MediumType[] allowedTypes, MediumType currentMediumType)
		{
			InitializeComponent();
			initialType = currentMediumType;
			notificationText.Rtf = string.Format(not, path.Replace("\\", "\\\\"));
			instrText.Rtf = instr;
			foreach (var rb in flowLayoutPanel1.Controls.OfType<RadioButton>())
			{
				var t = rb.Tag as MediumType?;
				rb.Enabled = t.HasValue && allowedTypes.Contains(t.Value);
				rb.Checked = t.GetValueOrDefault() == currentMediumType;
			}
			ModeCheckChanged(normalRadioBtn, EventArgs.Empty);
		}

		public MediumType MediumType => (MediumType)(flowLayoutPanel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag ?? MediumType.MediumType_Normal);

		private void ModeCheckChanged(object sender, EventArgs e)
		{
			if (!(sender is RadioButton rb) || !(rb.Tag is MediumType type)) return;
			modeHelpText.Text = ModeDesc[(int)type];
			okBtn.Enabled = type != initialType;
		}
	}
}