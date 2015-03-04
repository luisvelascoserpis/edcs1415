using Gtk;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		List<Button> buttons = new List<Button> ();
		List<int> numeros = new List<int> ();
		Random random = new Random ();

		Table table = new Table (9, 10, true);
		table.Visible = true;

		for (uint index = 0; index < 90; index++) {
			uint fila = index / 10;
			uint columna = index % 10;
			Button button = new Button ();
			EventBox eventBox = new EventBox ();
			Label label = new Label ((index + 1).ToString ());
			label.Visible = true;
			eventBox.Add (label);
			eventBox.Visible = true;
			button.Add (eventBox);
			button.Visible = true;
			table.Attach (button, columna, columna + 1, fila, fila + 1);
			buttons.Add (button);
			numeros.Add ((int)(index + 1));
		}

		vBox.Add (table);

		goForwardAction.Activated += delegate {
			int indexAleatorio = random.Next(numeros.Count);
			int numero = numeros[indexAleatorio];
			numeros.RemoveAt(indexAleatorio);
			entryNumero.Text = numero.ToString();
			buttons[numero - 1].Child.ModifyBg(StateType.Normal, new Gdk.Color(0,255,0));

			string format = "-v es \"{0}\"";
			string espeakNumero = numero.ToString();
			if (espeakNumero.Length == 2)
				espeakNumero = espeakNumero + " " + espeakNumero[0] + " " + espeakNumero[1];
			string espeak = string.Format(format, espeakNumero);
			Process.Start("espeak", espeak);

			goForwardAction.Sensitive = numeros.Count > 0;
		};
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
