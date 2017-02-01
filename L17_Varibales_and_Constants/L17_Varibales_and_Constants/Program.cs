using System;

namespace L17_Varibales_and_Constants {
	
	class MainClass {
		
		public static void Main(string[] args) {

			byte number = 2;
			int count = 10;
			float totalPrice = 20.95f;
			char character = 'A';
			string firstName = " Farhad";
			bool isWorking = false;

			firstName = firstName.Trim();
			firstName = firstName.Substring(0, 4);

			Console.WriteLine(number);
			Console.WriteLine(count);                   // type cw and press tab twice to autocomplete
			Console.WriteLine(totalPrice);
			Console.WriteLine(character);
			Console.WriteLine(firstName);
			Console.WriteLine(isWorking);
			Console.WriteLine();

			//   example of 'var'. The C# compiler decides the data type from the assigned value. Hover over var to see the data type
			var number1 = 2;
			var count1 = 10;
			var totalPrice1 = 20.95f;
			var character1 = 'A';
			var firstName1 = "Farhad";
			var isWorking1 = false;

			Console.WriteLine(number1);
			Console.WriteLine(count1);                   // type cw and press tab twice to autocomplete
			Console.WriteLine(totalPrice1);
			Console.WriteLine(character1);
			Console.WriteLine(firstName1);
			Console.WriteLine(isWorking1);

			Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);				// string formatting
			Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

			const float Pi = 3.14f;						// declaring a constant varibale

		}
	}
}



/*
  

 */