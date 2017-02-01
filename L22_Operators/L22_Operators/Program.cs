using System;

namespace L22_Operators
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var a = 20;
			var b = 3;
			var c = 1;

			Console.WriteLine((float)a/b);              // you need to convert to float if you want the result of your division in real number
			Console.WriteLine(a + b * c);
			Console.WriteLine(a < b);
			Console.WriteLine(a > b && b > c);

			byte h = 255;
			h += 2;										// there will be overflow and h will be 1.
			Console.WriteLine(h);

			//  if I write h = h + 2, i have to do casting
			//	h = (byte)h + 2;
		}
	}
}



// '&&' represents 'Logical And', '||' represents 'Logical Or'. '&' represents 'Bitwise And', '|' represents 'Bitwise Or'.
// C# is a statically typed language. This means if I declare the type of a variable as int, it will remain int for its lifetime.
// I can not change the data type of a variable to another data type.