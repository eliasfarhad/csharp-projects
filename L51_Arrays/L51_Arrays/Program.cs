using System;

namespace L51_Arrays
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var numbers = new[] { 3, 7, 9, 2, 9, 6 };                  // same thing as saying new int[]

			// Length
			Console.WriteLine("Length: " + numbers.Length);

			// IndexOf(): returns the position of an element in the array
			var index = Array.IndexOf(numbers, 9);
			Console.WriteLine("Index of 9: " + index);

			// Clear(): clear the elements
			Console.WriteLine(numbers[0]);
			Array.Clear(numbers, 0, 2);

			Console.WriteLine("Effects of Clear():");
			foreach(var n in numbers) {
				Console.WriteLine(n);
			}

			// Copy()
			int[] another = new int[3];
			Array.Copy(numbers, another, 3);			

			Console.WriteLine("Effects of Copy():");
			foreach(var n in another) {
				Console.WriteLine(n);
			}

			// Sort()



		}
	}
}



/*
  In C# we have two types of multi dimension Array. Rectangular and Jagged array.
  
  The syntax of the declaration of a rectangular array looks like:
  
  var matrix = new int[3, 5];				or
  
  var matrix = new int[3, 5]
  {
   	{1, 2, 3, 4},
   	{6, 7, 8, 9},
   	{8, 3, 0, 1}
  };

If you want to access an element in this array just like before, we use the square brackets.

	var element = matrix[2, 3];

If you want to declare a three dimensional array, we extend the previous example while declaring the array.

	var colors = new int[3, 5, 4];
=======================================================

Now lets take a look at the Jagged array. You can consider it as an array of arrays (each element of the array holds
a single dimensional array)

	var array = new int[3][];				here 3 is the number of rows

	array[0] = new int[4];					initiating every row with a specific number of columns
	array[1] = new int[5];
	array[2] = new int[3];

	array[0][0] = 1;						access the array element and assign a number to it.

So the difference between Jagged array and Rectangular array is that in Jagged array we have two square brackets and in
Rectangular array we have one square bracket but here we separate the dimensions using a comma.

	Rectangular: 	var matrix = new int[3, 5];
	Jagged: 		var array = new int[3][];

In C# all arrays map to the Array type that is defined in the System namespace of .Net framework. So the Array type is a
class that has properties and some methods.

 */
