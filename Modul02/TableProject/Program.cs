using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime = 0, familiq, godini};

		public static void Main (string[] args)
		{

			//Дефиниране на таблица 
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, (int) ti.ime] = "Martin";table[0,(int) ti.familiq] = "Simeonov";table[0, (int)ti.godini] = "31";

			//Въвеждане на втори ред
			table[1,(int) ti.ime] = "Simeon";table[1,(int) ti.familiq] = "Martinov";table[1,(int) ti.godini] = "41";


			//Pechat
			Console.Write("Koi red iskate da vidite: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine (
					(table[_index,(int)ti.ime])[0]+ ". " + 
				    table[_index,(int)ti.familiq] + ", " + 
				    table[_index,(int)ti.godini] + "g."
			);

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