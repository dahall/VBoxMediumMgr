using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Vanara.Extensions;
using Vanara.Windows.Forms.Design;
using VBoxMediumMgr.Annotations;

namespace VBoxMediumMgr
{
	/// <summary>Interface used by <see cref="CommandBindings"/> to provide support for binding a <see cref="Command"/> to a UI element.</summary>
	/// <remarks>
	/// To add support for additional UI elements, create a class that derives from <see cref="ICommandBinder"/> and supply a default constructor with no
	/// parameters. Implementing the interface, requires that the <see cref="Type"/> of the control being supported is supplied to the output of the
	/// <see cref="SupportedType"/> property and the other methods are implemented such that a <see cref="Command"/> can add and remove a click event handler and
	/// set property values.
	/// <para>
	/// Before your UI is loaded, make sure to add an instance of your custom binder to the <see cref="CommandBindings.Commands"/> property. If overriding
	/// support for either <see cref="ButtonBase"/> or <see cref="ToolStripItem"/> derived controls, make sure to remove the default handler from that same list.
	/// </para>
	/// <para>The following example is the default binder for all <c>ToolStripItem</c> derived controls.</para>
	/// <code lang="C#">
	/// public class ToolStripItemCommandBinder : ICommandBinder
	/// {
	/// 	public Type SupportedType { get; } = typeof(ToolStripItem);
	///
	/// 	public void AddClickHandler(Component c, EventHandler h)
	/// 	{
	/// 		if (c is ToolStripItem ctrl) ctrl.Click += h;
	/// 	}
	///
	/// 	public void RemoveClickHandler(Component c, EventHandler h)
	/// 	{
	/// 		if (c is ToolStripItem ctrl) ctrl.Click -= h;
	/// 	}
	///
	/// 	public virtual void SetValue&lt;T&gt;(Component c, string propertyName, T value)
	/// 	{
	/// 		var pi = c.GetType().GetProperty(propertyName, typeof(T), Type.EmptyTypes);
	/// 		if (pi == null) return;
	/// 		pi.SetValue(c, value);
	/// 	}
	/// }
	/// </code>
	/// </remarks>
	public interface ICommandBinder
	{
		/// <summary>Gets the type of the UI element(s) supported by this object.</summary>
		/// <value>The type of the supported UI element which much be derived from <see cref="Component"/>.</value>
		Type SupportedType { get; }

		/// <summary>Adds an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be called when the <see cref="Command.Click"/> event is fired.</param>
		void AddClickHandler(Component component, EventHandler handler);

		/// <summary>Removes an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be removed.</param>
		void RemoveClickHandler(Component component, EventHandler handler);

		/// <summary>Sets the value of a named property of type <typeparamref name="T"/>.</summary>
		/// <typeparam name="T">The type of the property.</typeparam>
		/// <param name="component">The <see cref="Component"/> on which to see the property.</param>
		/// <param name="propertyName">
		/// The name of the property. If the implemented class cannot support a property of this name, it should return without throwing an exception.
		/// </param>
		/// <param name="value">The value to assign to the named property.</param>
		void SetValue<T>(Component component, string propertyName, T value);
	}

	/// <summary>Represents a generic UI command which can be applied to UI elements like buttons, menus and toolbars.</summary>
	[DesignTimeVisible(false), DefaultEvent(nameof(Click)), DefaultProperty(nameof(Text))]
	[ToolboxItem(false)]
	public class Command : Component, INotifyPropertyChanged
	{
		internal CommandBindings parent;
		private bool useIntegerImageIndex = true;

		/// <summary>Occurs when a bound UI element is clicked.</summary>
		public event EventHandler Click;

		/// <summary>Occurs when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>Gets or sets a value indicating whether supporting UI elements are checked.</summary>
		/// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
		[DefaultValue(false)]
		[Description(""), Category("Behavior")]
		public virtual bool Checked
		{
			get => GetProperty(false);
			set => SetProperty(value);
		}

		/// <summary>Gets or sets a value indicating whether supporting UI elements are enabled.</summary>
		/// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
		[DefaultValue(true)]
		[Description(""), Category("Behavior")]
		public virtual bool Enabled
		{
			get => GetProperty(true);
			set => SetProperty(value);
		}

		/// <summary>Gets or sets text used for grouping commands. This text value is case and culture sensitive.</summary>
		/// <value>The group label.</value>
		[Localizable(true), DefaultValue(null)]
		[Description(""), Category("Appearance")]
		public virtual string Group
		{
			get => GetProperty<string>();
			set => SetProperty(value);
		}

		/// <summary>Gets or sets the image to display on supporting UI elements.</summary>
		/// <value>The image.</value>
		[Localizable(true)]
		[Description(""), Category("Appearance")]
		public virtual Image Image
		{
			get
			{
				var img = image;
				if (img == null && parent?.ImageList != null)
				{
					var actualIndex = ActualIndex;
					if (actualIndex >= parent.ImageList.Images.Count)
						actualIndex = parent.ImageList.Images.Count - 1;
					if (actualIndex >= 0)
						return parent.ImageList?.Images[actualIndex];
				}
				return img;
			}
			set
			{
				if (Image != value)
				{
					image = value;
					if (value != null)
						ImageIndex = -1;
				}
			}
		}

		[TypeConverter(typeof(ImageIndexConverter))]
		[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		[RelatedImageList("ImageList")]
		[DefaultValue(-1), Localizable(true), RefreshProperties(RefreshProperties.Repaint)]
		[Description(""), Category("Appearance")]
		public virtual int ImageIndex
		{
			get
			{
				var iIdx = imageIndex;
				if (iIdx != -1 && parent?.ImageList != null && iIdx >= parent.ImageList.Images.Count)
					return parent.ImageList.Images.Count - 1;
				return iIdx;
			}
			set
			{
				if (value < -1)
					throw new ArgumentOutOfRangeException(nameof(ImageIndex));
				if (imageIndex != value)
				{
					if (value != -1)
						SetProperty<Image>(null, "Image");
					imageKey = String.Empty;
					imageIndex = value;
					useIntegerImageIndex = true;
				}
			}
		}

		[TypeConverterAttribute(typeof(ImageKeyConverter))]
		[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		[RelatedImageList("ImageList")]
		[DefaultValue(""), Localizable(true), RefreshProperties(RefreshProperties.Repaint)]
		[Description(""), Category("Appearance")]
		public virtual string ImageKey
		{
			get => imageKey;
			set
			{
				if (imageKey != value)
				{
					if (value != null)
						SetProperty<Image>(null, "Image");
					SetProperty(-1, "ImageIndex");
					imageKey = value ?? String.Empty;
					useIntegerImageIndex = false;
				}
			}
		}

		[Browsable(false)]
		public ImageList ImageList => parent?.ImageList;

		/// <summary>Gets or sets the text to display on supporting UI elements.</summary>
		/// <value>The text.</value>
		[Localizable(true), DefaultValue(null)]
		[Description(""), Category("Appearance")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual string Text
		{
			get => GetProperty<string>();
			set => SetProperty(value);
		}

		/// <summary>Gets or sets the tool tip text to display on supporting UI elements.</summary>
		/// <value>The tool tip text.</value>
		[Localizable(true), DefaultValue(null)]
		[Description(""), Category("Appearance")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual string ToolTipText
		{
			get => GetProperty<string>();
			set => SetProperty(value);
		}

		/// <summary>Gets or sets a value indicating whether supporting UI elements are visible.</summary>
		/// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
		[DefaultValue(true)]
		[Description(""), Category("Behavior")]
		public virtual bool Visible
		{
			get => GetProperty(true);
			set => SetProperty(value);
		}

		internal int ActualIndex
		{
			get
			{
				if (useIntegerImageIndex)
					return imageIndex;
				else if (parent?.ImageList != null)
					return parent.ImageList.Images.IndexOfKey(imageKey);
				return -1;
			}
		}

		/// <summary>Gets the properties.</summary>
		/// <value>The properties.</value>
		internal IDictionary<string, object> Properties { get; } = new ConcurrentDictionary<string, object>();

		private Image image
		{
			get => GetProperty<Image>(null, "Image");
			set => SetProperty(value, "Image");
		}

		private int imageIndex
		{
			get => GetProperty(-1, "ImageIndex");
			set => SetProperty(value, "ImageIndex");
		}

		private string imageKey
		{
			get => GetProperty(string.Empty, "ImageKey");
			set => SetProperty(value, "ImageKey");
		}

		/// <summary>Calls the <see cref="Click"/> event.</summary>
		/// <param name="sender">The sender of the event. This is typically the UI element.</param>
		public virtual void OnClick(object sender)
		{
			Click?.Invoke(sender, EventArgs.Empty);
		}

		/// <summary>Gets the value of a property for this Command.</summary>
		/// <typeparam name="T">The type of the property value.</typeparam>
		/// <param name="defaultValue">The default value for the property if it is not found.</param>
		/// <param name="propertyName">The name of the property to get. This value is auto-populated with the calling property name.</param>
		/// <returns>The value of the property, if found, or <paramref name="defaultValue"/> if not.</returns>
		protected T GetProperty<T>(T defaultValue = default(T), [CallerMemberName] string propertyName = null)
		{
			return Properties.TryGetValue(propertyName, out object oldVal) && oldVal is T ? (T)oldVal : defaultValue;
		}

		/// <summary>Calls the <see cref="PropertyChanged"/> event.</summary>
		/// <param name="propertyName">Name of the property that has changed.</param>
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>Sets a property value.</summary>
		/// <typeparam name="T">The type of the property value.</typeparam>
		/// <param name="value">The value to set.</param>
		/// <param name="propertyName">The name of the property to set. This value is auto-populated with the calling property name.</param>
		protected void SetProperty<T>(T value, [CallerMemberName] string propertyName = null)
		{
			if (Properties.TryGetValue(propertyName, out object oldVal) && Equals(oldVal, value)) return;
			Properties[propertyName] = value;
			OnPropertyChanged(propertyName);
		}

		private void ResetImage()
		{
			Image = null;
		}

		private bool ShouldSerializeImage() => image != null;
	}

	/// <summary>
	/// Component that provides a command centralization for UI elements. Acting on a single <see cref="Command"/> will modify the properties of all bound UI
	/// elements. Clicking on any bound UI element will fire the corresponding <see cref="Command.Click"/> event.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Adding this to a form will extend all controls supported by built-in or supplied <see cref="ICommandBinder"/> derived binders and provide a
	/// <c>Command</c> property. Currently, all <see cref="ButtonBase"/> and <see cref="ToolStripItem"/> derived UI elements are supported. See the Remarks for
	/// <see cref="ICommandBinder"/> for information on adding additional binders.
	/// </para>
	/// <para>
	/// Developers can use the <see cref="CommandBindings.Commands"/> property to add and configure commands for different UI activities. Each command, must, at
	/// a minimum, have the <see cref="Command.Click"/> event assigned to a handler. When using the Collection Editor to add new <see cref="Command"/> instances,
	/// the developer will need to then exit the Collection Editor and select the <see cref="Command"/> reference in order to edit the <c>Click</c> event.
	/// </para>
	/// <para>Once all <see cref="Command"/> instances have been created, there are two means of assigning those commands to UI elements.</para>
	/// <list type="number">
	/// <item>
	/// <description>
	/// Create each UI element separately and assign the <c>Command</c> property for that element to the associated <c>Command</c> instance created earlier.
	/// </description>
	/// </item>
	/// <item>
	/// <description>
	/// Use the <see cref="LoadToolStripFromCommands"/> and <see cref="LoadMenuFromCommands"/> methods to automatically generate menu items and toolbar buttons
	/// from the full list of Commands. This options requires that the <see cref="Command.Text"/> and/or the <see cref="Command.Image"/> properties are set.
	/// </description>
	/// </item>
	/// </list>
	/// <para>
	/// Now, to affect the behavior of the UI elements, simply set the values of the properties on the <see cref="Command"/> and all bound UI elements will be
	/// changed. If, for example, you sent the <see cref="Command.Enabled"/> property to <c>false</c>, then all bound controls will have their <c>Enabled</c>
	/// property set to <c>false</c> as well. Whenever the user clicks one of the controls bound to a <c>Command</c>, that <c>Command</c>'s
	/// <see cref="Command.Click"/> event will be raised.
	/// </para>
	/// <para>
	/// For example, you may have a menu item, a toolbar button and a context menu that all save an edited file. You can create a single <see cref="Command"/>
	/// called <c>saveCmd</c>. You would then assign the <see cref="Command.Click"/> event a handler that saves the file. You would then assign the
	/// <c>Command</c> property for each of those UI elements to the <c>saveCmd</c><see cref="Command"/>. Then, whenever one of those UI elements is clicked, the
	/// <c>saveCmd</c>'s <c>Click</c> event is called.
	/// </para>
	/// </remarks>
	[Designer(typeof(CommandBindingsDesigner))]
	[ProvideProperty("Command", typeof(Component))]
	[DefaultProperty("Commands")]
	public partial class CommandBindings : Component, IExtenderProvider
	{
		private static List<ICommandBinder> binders;
		private readonly Dictionary<Component, Command> bindings = new Dictionary<Component, Command>();

		/// <summary>Initializes a new instance of the <see cref="CommandBindings"/> class.</summary>
		public CommandBindings() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CommandBindings"/> class.</summary>
		/// <param name="container">The container.</param>
		public CommandBindings(IContainer container)
		{
			container?.Add(this);
			InitializeComponent();
			Commands.CollectionChanged += OnCmdCollectionChanged;
		}

		/// <summary>Gets the binders.</summary>
		/// <value>The binders.</value>
		// TODO: At some point, it would be cool to auto-discover all binders if possible. AppDomain.CurrentDomain.GetAssemblies().SelectMany(a =>
		// a.GetTypes()).Where(ti => ti.IsClass && !ti.IsAbstract && typeof(ICommandBinder).IsAssignableFrom(ti)).Select(ti => (ICommandBinder)Activator.CreateInstance(ti)).ToArray());
		public static ICollection<ICommandBinder> Binders => binders ?? (binders = new List<ICommandBinder> { new ButtonCommandBinder(), new ToolStripItemCommandBinder() });

		/// <summary>Gets the list of <see cref="Command"/> instances supported by this component.</summary>
		/// <value>The list of <see cref="Command"/> instances.</value>
		[Category("Data"), Description("Collection of commands.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CommandList Commands { get; } = new CommandList();

		/// <summary>Gets or sets the image list used by the commands.</summary>
		/// <value>The image list.</value>
		[DefaultValue(null), Category("Appearance")]
		public ImageList ImageList { get; set; }

		/// <summary>Binds a <see cref="Command"/> to this component.</summary>
		/// <param name="component">The component.</param>
		/// <param name="cmd">The command.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public void BindCommand([NotNull] Component component, [NotNull] Command cmd)
		{
			if (component == null || cmd == null) throw new ArgumentNullException();
			if (!Commands.Contains(cmd)) Commands.Add(cmd);
			bindings[component] = cmd;
			GetBinder(component)?.AddClickHandler(component, OnCommandClick);
		}

		/// <summary>Gets the <see cref="Command"/> instances associated with a given <see cref="Component"/>.</summary>
		/// <param name="component">The component.</param>
		/// <returns>The associated <see cref="Command"/> instance or <c>null</c> if there is no binding.</returns>
		[DefaultValue(null), Category("Binding")]
		public Command GetBoundCommand([NotNull] Component component) => bindings.TryGetValue(component, out Command cmd) ? cmd : null;

		/// <summary>
		/// Appends a list of <see cref="ToolStripMenuItem"/> instances to the provided <paramref name="menu"/> based on the <see cref="Command"/> instances
		/// managed by this component.
		/// </summary>
		/// <param name="menu">The menu to which to append the items.</param>
		/// <remarks>
		/// For best results, ensure the <c>Text</c> and/or <c>Image</c> property are set on every <see cref="Command"/> instance. A best practice would be to
		/// call this one before the <see cref="Form"/> is loaded and after all <see cref="Command"/> instances have been added to the <see cref="Commands"/> property.
		/// </remarks>
		public void LoadMenuFromCommands([NotNull] ToolStripItemCollection menu)
		{
			var cmps = new ToolStripItem[Commands.Count];
			for (var i = 0; i < Commands.Count; i++)
			{
				var c = Commands[i];
				cmps[i] = new ToolStripMenuItem(c.Text, c.Image) { ToolTipText = c.ToolTipText, ImageScaling = ToolStripItemImageScaling.SizeToFit };
				BindCommand(cmps[i], c);
			}
			menu.AddRange(cmps);
		}

		/// <summary>
		/// Appends a list of <see cref="ToolStripButton"/> instances to the provided <paramref name="tools"/> based on the <see cref="Command"/> instances
		/// managed by this component.
		/// </summary>
		/// <param name="tools">The <see cref="ToolStrip"/> to which to append the items.</param>
		/// <param name="tiRel">The <see cref="TextImageRelation"/> value applied to each <see cref="ToolStripButton"/> instance created.</param>
		/// <remarks>
		/// For best results, ensure the <c>Text</c> and/or <c>Image</c> property are set on every <see cref="Command"/> instance. A best practice would be to
		/// call this one before the <see cref="Form"/> is loaded and after all <see cref="Command"/> instances have been added to the <see cref="Commands"/> property.
		/// </remarks>
		public void LoadToolStripFromCommands([NotNull] ToolStripItemCollection tools, TextImageRelation tiRel = TextImageRelation.ImageBeforeText)
		{
			var cmps = new ToolStripItem[Commands.Count];
			for (var i = 0; i < Commands.Count; i++)
			{
				var c = Commands[i];
				cmps[i] = new ToolStripButton(c.Text, c.Image) { TextImageRelation = tiRel, ToolTipText = c.ToolTipText };
				BindCommand(cmps[i], c);
			}
			tools.AddRange(cmps);
		}

		/// <summary>Specifies whether this object can provide its extender properties to the specified object.</summary>
		/// <param name="extendee">The <see cref="T:System.Object"/> to receive the extender properties.</param>
		/// <returns>true if this object can provide extender properties to the specified object; otherwise, false.</returns>
		bool IExtenderProvider.CanExtend(object extendee)
		{
			return !(extendee is CommandBindings) && Binders.Any(b => b.SupportedType.IsInstanceOfType(extendee));
		}

		[CanBeNull]
		private static ICommandBinder GetBinder([NotNull] Component c) => Binders.FirstOrDefault(b => b.SupportedType.IsInstanceOfType(c));

		/// <summary>Called when [command collection changed].</summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="NotifyCollectionChangedEventArgs"/> instance containing the event data.</param>
		private void OnCmdCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Replace)
			{
				foreach (var c in e.NewItems.OfType<Command>())
					c.parent = this;
			}
			if (e.Action == NotifyCollectionChangedAction.Replace || e.Action == NotifyCollectionChangedAction.Remove)
			{
				foreach (var c in e.OldItems.OfType<Command>())
				{
					c.parent = null;
					foreach (var k in bindings.Where(kv => ReferenceEquals(kv.Value, c)).Select(kv => kv.Key).Distinct().ToArray())
						bindings.Remove(k);
				}
			}
		}

		private void OnCommandClick(object sender, EventArgs e)
		{
			if (sender is Component c && bindings.TryGetValue(c, out Command cmd))
				cmd?.OnClick(sender);
		}

		private void OnCommandPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			foreach (var kv in bindings.Where(p => ReferenceEquals(p.Value, sender)))
			{
				GetBinder(kv.Key)?.SetValue(kv.Key, e.PropertyName, kv.Value.Properties[e.PropertyName]);
			}
		}

		/// <summary>A list of <see cref="Command"/> instances.</summary>
		/// <seealso cref="System.Collections.ObjectModel.ObservableCollection{Command}"/>
		[Editor(typeof(CollectionEditor), typeof(UITypeEditor)), ListBindable(false)]
		public class CommandList : ObservableCollection<Command> { }
	}

	/// <summary>An abstract binder for any <see cref="Control"/> type.</summary>
	/// <seealso cref="ICommandBinder"/>
	public abstract class ControlBinder : ICommandBinder
	{
		/// <summary>Gets the type of the UI element(s) supported by this object.</summary>
		/// <value>The type of the supported UI element which much be derived from <see cref="Component"/>.</value>
		public abstract Type SupportedType { get; }

		/// <summary>Adds an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be called when the <see cref="Command.Click"/> event is fired.</param>
		public virtual void AddClickHandler(Component component, EventHandler handler)
		{
			if (component is Control ctrl) ctrl.Click += handler;
		}

		/// <summary>Removes an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be removed.</param>
		public virtual void RemoveClickHandler(Component component, EventHandler handler)
		{
			if (component is Control ctrl) ctrl.Click -= handler;
		}

		/// <summary>Sets the value of a named property of type <typeparamref name="T"/>.</summary>
		/// <typeparam name="T">The type of the property.</typeparam>
		/// <param name="component">The <see cref="Component"/> on which to see the property.</param>
		/// <param name="propertyName">
		/// The name of the property. If the implemented class cannot support a property of this name, it should return without throwing an exception.
		/// </param>
		/// <param name="value">The value to assign to the named property.</param>
		public virtual void SetValue<T>(Component component, string propertyName, T value)
		{
			var pi = component.GetType().GetProperty(propertyName, typeof(T), Type.EmptyTypes);
			if (pi == null) return;
			pi.SetValue(component, value);
		}
	}

	/// <summary>A binder for all controls derived from <see cref="ButtonBase"/>.</summary>
	/// <seealso cref="ControlBinder"/>
	public class ButtonCommandBinder : ControlBinder
	{
		/// <summary>Gets the type of the supported.</summary>
		/// <value>The type of the supported.</value>
		public override Type SupportedType { get; } = typeof(ButtonBase);

		/// <summary>Sets the value of a named property of type <typeparamref name="T"/>.</summary>
		/// <typeparam name="T">The type of the property.</typeparam>
		/// <param name="component">The <see cref="Component"/> on which to see the property.</param>
		/// <param name="propertyName">
		/// The name of the property. If the implemented class cannot support a property of this name, it should return without throwing an exception.
		/// </param>
		/// <param name="value">The value to assign to the named property.</param>
		public override void SetValue<T>(Component component, string propertyName, T value)
		{
			if (propertyName == "ToolTipText") return;
			base.SetValue(component, propertyName, value);
		}
	}

	/// <summary>A binder for all components derived from <see cref="ToolStripItem"/>.</summary>
	/// <seealso cref="ICommandBinder"/>
	public class ToolStripItemCommandBinder : ICommandBinder
	{
		/// <summary>Gets the type of the supported.</summary>
		/// <value>The type of the supported.</value>
		public Type SupportedType { get; } = typeof(ToolStripItem);

		/// <summary>Adds an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be called when the <see cref="Command.Click"/> event is fired.</param>
		public virtual void AddClickHandler(Component component, EventHandler handler)
		{
			if (component is ToolStripItem ctrl) ctrl.Click += handler;
		}

		/// <summary>Removes an event handler for the <see cref="Command.Click"/> event to the UI element.</summary>
		/// <param name="component">The <see cref="Component"/>.</param>
		/// <param name="handler">The event handler to be removed.</param>
		public virtual void RemoveClickHandler(Component component, EventHandler handler)
		{
			if (component is ToolStripItem ctrl) ctrl.Click -= handler;
		}

		/// <summary>Sets the value of a named property of type <typeparamref name="T"/>.</summary>
		/// <typeparam name="T">The type of the property.</typeparam>
		/// <param name="component">The <see cref="Component"/> on which to see the property.</param>
		/// <param name="propertyName">
		/// The name of the property. If the implemented class cannot support a property of this name, it should return without throwing an exception.
		/// </param>
		/// <param name="value">The value to assign to the named property.</param>
		public virtual void SetValue<T>(Component component, string propertyName, T value)
		{
			var pi = component.GetType().GetProperty(propertyName, value?.GetType() ?? typeof(T), Type.EmptyTypes);
			if (pi == null) return;
			pi.SetValue(component, value);
		}
	}

	internal class CommandBindingsDesigner : AttributedComponentDesignerEx<CommandBindings>
	{
		private BinderActions actions;

		protected override AttributedDesignerActionList Actions => actions ?? (actions = new BinderActions(this, Component));

		internal class BinderActions : AttributedDesignerActionList
		{
			public BinderActions(CommandBindingsDesigner designer, CommandBindings component) : base(designer, component) { }

			[DesignerActionMethod("Edit commands...")]
			public void InvokeCommandsDialog()
			{
				ParentDesigner.EditValue("Commands", ParentDesigner.Component);
			}
		}
	}
}