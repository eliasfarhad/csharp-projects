using System;

namespace L41_Conditionals
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int hour = 10;

			if (hour > 0 && hour < 12) {
				Console.WriteLine("It's morning.");
			}
			else if (hour >= 12 && hour < 6) {
				Console.WriteLine("It's afternoon.");
			}
			else {
				Console.WriteLine("It's evening.");
			}

			// ========== another example ===========

			bool isGoldCustomer = true;
			float price;

			if (isGoldCustomer) {
				price = 19.95f;
			}
			else {
				price = 29.95f;
			}

			Console.WriteLine(price);

			// a different way of writing if/else:

			float price2 = (isGoldCustomer) ? 24.95f : 34.95f;

			Console.WriteLine(price2);

			// ========= switch statement ================

			var season = Season.Autumn;

			switch (season) {
				case Season.Autumn:
					Console.WriteLine("It's autumn and beautiful to be outside");
					break;
				case Season.Summer:
					Console.WriteLine("It's perfect to go to the beach");
					break;
				default:
					Console.WriteLine("I didn't understand the season");
					break;
			}
		}
	}
}
