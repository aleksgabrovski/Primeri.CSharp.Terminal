using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на таблица 
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, 0] = "Martin";table[0, 1] = "Simeonov";table[0, 2] = "31";

			//Въвеждане на втори ред
			table[1, 0] = "Simeon";table[1, 1] = "Martinov";table[1, 2] = "41";


			//Pechat
			Console.Write("Koi red iskate da vidite: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table[_index,0])[0]+ ". " + table[_index,1] + ", " + table[_index,2] + "g.");

		}
	}
}




//          string[] row = new string[3];
//
//			row[0]="Ред 1";
//			row[1]="Ред 2";
//			row[2]="Ред 3";
//
//			Console.WriteLine ("Masiv row: " + row[0] + "," + row[1] + "," + row[2] + "\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//				Console.WriteLine("Broqt na masiva:\n" + "1,2,3,4,5,6,7,8,9\n\ne: " + parse.Length);
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Noviqt string e:\n" + list1 + "\n\n");