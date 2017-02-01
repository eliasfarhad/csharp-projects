using System;

namespace L32_strings
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num;
			string firstName = "S M";
			string lastName = "Farhad";

			var fullName = firstName + " " + lastName;
			Console.WriteLine(fullName);
			var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
			Console.WriteLine(myFullName);

			var names = new string[3] { "Shuhan", "Niloy", "Noyon" };
			var formattedNames = string.Join(",", names);				// the first argument is a comma (could be anything) which is a separator
			Console.WriteLine(formattedNames);

			Console.WriteLine();

			var text1 = "Hi Farhad\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
			Console.WriteLine(text1);

			Console.WriteLine();

			// Verbatim string: You put an @ sign at the front of the string and remove all the \n and extra backslashes

			var text2 = @"Hi Farhad
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
			Console.WriteLine(text2);







			// .Net
			Int32 number = 5;								// must import System namespace
			String word = "S M";							// must import System namespace

		}
	}
}


// All primitive types are structures. All primitive types in C# maps to a class in the .Net framework. So string in C# is String in .Net framework. But for the
// second one, you need to import the System namespace. String is a class in the System namepsace. This class has many static methods which you can use. There is
// absolutely no deifference at all between string and String. You can use either of them.