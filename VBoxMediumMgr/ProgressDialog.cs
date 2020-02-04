using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VBoxMediumMgr
{
	/// <summary>
	/// Multi-level, auto-sizing, progress dialog. The <see cref="MacroPercentComplete"/> and <see cref="MacroStatusText"/> properties, if set, will reveal a
	/// progress bar and status above the standard progress bar and status that can be used for high-level (macro) progress. For example, if you were copying
	/// many large files from one directory to another, the macro items would track the progress of all files (1 of X files) and the standard items would track
	/// the progress of copying a single file.
	/// </summary>
	public partial class ProgressDialog : Form
	{
		/// <summary>Initializes a new instance of the <see cref="ProgressDialog"/> class.</summary>
		public ProgressDialog()
		{
			InitializeComponent();
			MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			bodyPanel.SizeChanged += BodyPanel_SizeChanged;
		}

		/// <summary>Occurs when the Cancel button is pressed.</summary>
		public event CancelEventHandler Cancelled;

		/// <summary>
		/// Gets or sets the value of the macro progress bar. Valid values are 0 to 100. If this value is 0 and <see cref="MacroStatusText"/> is null or empty,
		/// the macro items will be hidden.
		/// </summary>
		/// <value>The macro percent complete.</value>
		[DefaultValue(0)]
		public int MacroPercentComplete
		{
			get => macroProgressBar.Value;
			set { macroProgressBar.Value = value; MacroItemsVisible = macroProgressBar.Value != 0 && !string.IsNullOrEmpty(macroStatusLabel.Text); }
		}

		/// <summary>
		/// Gets or sets the status text displayed above the macro progress bar. If this value is null or empty and <see cref="MacroPercentComplete"/> is 0, the
		/// macro items will be hidden.
		/// </summary>
		/// <value>The macro status text.</value>
		[DefaultValue("")]
		public string MacroStatusText
		{
			get => macroStatusLabel.Text;
			set { macroStatusLabel.Text = value; MacroItemsVisible = macroProgressBar.Value != 0 && !string.IsNullOrEmpty(macroStatusLabel.Text); }
		}

		/// <summary>Gets or sets the value of the standard progress bar. Valid values are 0 to 100.</summary>
		/// <value>The percent complete.</value>
		[DefaultValue(0)]
		public int PercentComplete
		{
			get => progressBar.Value;
			set => progressBar.Value = value;
		}

		/// <summary>Gets or sets the status text displayed above the standard progress bar.</summary>
		/// <value>The status text.</value>
		[DefaultValue("")]
		public string StatusText
		{
			get => statusLabel.Text;
			set => statusLabel.Text = value;
		}

		/// <summary>Gets or sets a value indicating whether [task visible].</summary>
		/// <value><c>true</c> if [task visible]; otherwise, <c>false</c>.</value>
		private bool MacroItemsVisible
		{
			get => macroProgressBar.Visible;
			set => macroProgressBar.Visible = macroStatusLabel.Visible = value;
		}

		/// <summary>Raises the <see cref="E:Cancelled"/> event.</summary>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		protected virtual void OnCancelled(CancelEventArgs e)
		{
			Cancelled?.Invoke(this, e);
		}

		/// <summary>Raises the <see cref="E:System.Windows.Forms.Form.FormClosed"/> event.</summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.FormClosedEventArgs"/> that contains the event data.</param>
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
			MacroItemsVisible = false;
		}

		/// <summary>Handles the SizeChanged event of the bodyPanel control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void BodyPanel_SizeChanged(object sender, EventArgs eventArgs)
		{
			Size = new System.Drawing.Size(Width, bodyPanel.Height + Height - ClientSize.Height);
		}

		/// <summary>Handles the Click event of the cancelBtn control.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			OnCancelled(new CancelEventArgs(true));
		}
	}
}