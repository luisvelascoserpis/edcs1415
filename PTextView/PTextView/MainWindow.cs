using System;
using System.IO;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private string filename;

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
		if ((ResponseType)fileChooserDialog.Run () == ResponseType.Ok) {
			filename = fileChooserDialog.Filename;
			textView.Buffer.Text = File.ReadAllText (filename);
		}

		fileChooserDialog.Destroy ();
	}

	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
		if (filename != null)
			File.WriteAllText (filename, textView.Buffer.Text);
		else
			saveAs ();

	}

	private void saveAs() {
		FileChooserDialog fileChooserDialog = new FileChooserDialog (
			"Guardar como...",
			this,
			FileChooserAction.Save,
			Stock.Cancel, ResponseType.Cancel,
			Stock.Save, ResponseType.Ok);
		if ((ResponseType)fileChooserDialog.Run () == ResponseType.Ok) {
			filename = fileChooserDialog.Filename;
			File.WriteAllText (filename, textView.Buffer.Text);
		}

		fileChooserDialog.Destroy ();
	}
}
