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
			Console.WriteLine ( "Резултата а + б е " + ( a + b ).ToString() + "\n\n\n" );
		}
	}
}
