
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label labelSaludo;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label4;
	private global::Gtk.Entry entryNombre;
	private global::Gtk.Button buttonAceptar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelSaludo = new global::Gtk.Label ();
		this.labelSaludo.Name = "labelSaludo";
		this.labelSaludo.LabelProp = global::Mono.Unix.Catalog.GetString ("Hola Mundo");
		this.vbox2.Add (this.labelSaludo);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelSaludo]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Introduce tu nombre");
		this.hbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryNombre = new global::Gtk.Entry ();
		this.entryNombre.CanFocus = true;
		this.entryNombre.Name = "entryNombre";
		this.entryNombre.IsEditable = true;
		this.entryNombre.InvisibleChar = '•';
		this.hbox3.Add (this.entryNombre);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryNombre]));
		w3.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonAceptar = new global::Gtk.Button ();
		this.buttonAceptar.CanFocus = true;
		this.buttonAceptar.Name = "buttonAceptar";
		this.buttonAceptar.UseStock = true;
		this.buttonAceptar.UseUnderline = true;
		this.buttonAceptar.Label = "gtk-ok";
		this.hbox3.Add (this.buttonAceptar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonAceptar]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonAceptar.Clicked += new global::System.EventHandler (this.OnButtonAceptarClicked);
	}
}
