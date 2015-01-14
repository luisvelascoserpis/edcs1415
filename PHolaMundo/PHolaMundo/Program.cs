using System;

namespace PHolaMundo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Dime tu nombre: ");
			string nombre = Console.ReadLine ();
			Console.WriteLine ("Hola " + nombre);
		}
	}
}
