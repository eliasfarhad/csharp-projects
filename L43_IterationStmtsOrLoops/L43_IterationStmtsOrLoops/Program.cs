using System;

namespace L43_IterationStmtsOrLoops
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// For loop : display the list of even numbers

			for (var i = 1; i <= 10; i++) {
				if (i % 2 == 0)
					Console.WriteLine(i);
			}

			Console.WriteLine();

			// Foreach loop. But lets first take a look at for loop to examine how cleaner the foreach loop looks like afterwards.

			var name = "Elias Farhad";

			for (var i = 0; i < name.Length; i++) {
				Console.WriteLine(name[i]);
			}

			Console.WriteLine();

			foreach (var character in name) {
				Console.WriteLine(character);
			}

			Console.WriteLine();
			// While loop
			var word = "Farhad";

			while (true) {
				Console.Write("Please type your name: ");
				var input = Console.ReadLine();

				if (word.CompareTo(input) == 0) {				// don't use equals method in this case. Read the description of the Equals() method
					Console.WriteLine(input);
					break;
				}
			}

			Console.WriteLine();

			while (true) {
				Console.Write("Type your name: ");
				var input = Console.ReadLine();

				if (String.IsNullOrWhiteSpace(input)) {         // string or String both works
					break;										// if the user types nothing or whitespaces, then break out of the loop
				}

				Console.WriteLine("@Echo: " + input);			// otherwise print back what the user typed
			}

			Console.WriteLine();
			// another way of doing what we just did

			while (true)
			{
				Console.Write("Type your name: ");
				var input = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(input))			// notice the not sign
				{
					Console.WriteLine("@Echo: " + input);
					continue;									// continue to the next iteration as long as the input is valid
				}
				break;											// break out of the loop if the 'if' statement wasn't executed
			}

		}
	}
}


/*
  C# has four kinds of iteration statements:

		For loops
	  	Foreach loops
	  	While loops
	  	Do While loops

   Foreach is used to iterate over elements of an enumerable object. Enumerable means that anything that has some
   kind of list or array nature. Remember that a string is a secquence of characters. So a string is enumerable. It's
   an enumerable object. It's like a list. So we can iterate over it. The array type is also enumerable. 

	This is what the syntax of a foreach loop look like:
	
		foreach (var num in numbers) {
			...
		}

	Assuming that numbers is an array of integers, in every iteration num will hold the value of the current
	element in the array.

	Note: Also remember the functions of these statements.
		Break: jumps out of the loop
		Continue: jumps to the next iteration.
 */