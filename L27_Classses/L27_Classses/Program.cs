using System;
using L27_Classses.Math;

namespace L27_Classses
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Person shaon = new Person();
			shaon.firstName = "S M";
			shaon.lastName = "Farhad";
			shaon.Introduce();

			Calculator calculator = new Calculator();					// this class is in the same namespace

			Calculator2 calculator2 = new Calculator2();                // this class is in a different namespace

			var result = calculator2.Add(2, 3);
			Console.WriteLine(result);

		}
	}
}


// control + tab to switch between different open classes
// Notice about Console.WriteLine(). Console is a class and since we are using it to access WriteLine(), that means WriteLine() is a static
// method. This means we have just one copy of this method. This is infact true. When we write our application, we have just one console.
// We do not create an object of the Console class to access this method.





// ===============  Lecture 28: Structs  =================

/*
 There are very little differences between a struct and a class. A strcut is more like a lightweight version of a class. If you have a
 situation where you need to create a small class with very few attributes, then it is more efficient to create a struct, instead of creating
 a class and declaring hundereds/thousands of objects. An example would be the PointClass from CS323 which only had int x_Coor and
 int y_Coor. That was a very good opportunity to create and use struct. If you cannot decide which one to use, then it is 
 perfectly ok to create a class.

Structure:  public struct PointClass {
				int x_coor;
				int y_coor;
			}
 */