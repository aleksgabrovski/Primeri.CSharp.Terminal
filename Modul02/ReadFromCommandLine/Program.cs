using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Definirane na promenlivi
			int a = 5, b = 0;


			// Vuvejdane na vhodni parametri
			Console.Write( " Моля въведете а: " );
			b = Convert.ToInt32 ( Console.ReadLine() );

			//Pechat na rezultata
			Console.WriteLine ( "Резултата а + б е " + ( a + b ).ToString() + "\n" );

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Subirane s += :" + test + "\n");

			test = test.Replace (", ", ";");
			Console.WriteLine ("Rabota s Replace: " + test + "\n");

			Console.WriteLine ("3ti znak :" + test.Split (';')[2] );
		}
	}
}
