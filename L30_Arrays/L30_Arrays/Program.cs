using System;

namespace L30_Arrays
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] numbers = new int[3];				// integer array is initialized to zero
			// var numbers = new int[3];
			numbers[0] = 2;

			Console.WriteLine(numbers[0]);			// 2 will be printed
			Console.WriteLine(numbers[1]);			// 0 will be printed
			Console.WriteLine(numbers[2]);          // 0 will be printed

			var flags = new bool[3];				// boolean array is initialized to false
			flags[0] = true;

			Console.WriteLine(flags[0]);
			Console.WriteLine(flags[1]);
			Console.WriteLine(flags[2]);

			// string[] names = { "Jack", "John", "Marry" };	// it's good. compiler is aware of the data type.
			// var names = { "Jack", "John", "Marry" };         // will not work, because compiler doesn't know what type it is

			var names = new string[3] { "Jack", "John", "Marry" };
			Console.WriteLine(names[2]);
		}
	}
}
