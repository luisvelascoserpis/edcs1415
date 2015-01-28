using System;
using System.IO;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();



		//textView.Buffer.Text = File.ReadAllText ("prueba.txt");
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnOpenActionActivated (object sender, EventArgs e)
	{
		FileChooserDialog fileChooserDialog = new FileChooserDialog (
			"Elige el archivo",
			this,
			FileChooserAction.Open,
			Stock.Cancel, ResponseType.Cancel,
			Stock.Open, ResponseType.Ok);
		//if (fileChooserDialog.Run () == (int)ResponseType.Ok)
		if ((ResponseType)fileChooserDialog.Run () == ResponseType.Ok)
			textView.Buffer.Text = File.ReadAllText (fileChooserDialog.Filename);

		fileChooserDialog.Destroy ();
	}
}
