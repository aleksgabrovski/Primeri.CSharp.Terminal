using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Definirane na promenlivi
			int a = 10, b = 0;

			//Vuvejdane na vhodni parametri
			Console.Write( "Molq vuvedete a: " );
			b = Convert.ToInt32 (Console.ReadLine() );

			// Pechat na rezlultat
			Console.WriteLine (a + b);
        }
	}
}
