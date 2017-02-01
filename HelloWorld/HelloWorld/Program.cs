using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld {
	
	class MainClass {
		 
		public static void Main(string[] args) {
			
			Console.WriteLine("Hello World!");					// System.out.println()
			Console.WriteLine("Hello World!");
			Console.Write("Yah");								// System.out.print()
			Console.Write("oo");
			Console.Beep();										// play the beep sound
		}
	}
}


/*
   Shortcuts: Command + Enter to run the program
              Command + X to delete a single line
              Alt + Enter to delete all unnecessary Usings. But first click on those greyed items.
 
   1) 'using' is similar to import in Java. If it is bright, then you are using that library. If it is grey, 
       that library is not being used.

	2) Our project is named HelloWorld, so by default Visual Studio creates a namespace called HelloWorld. When you write code
	   in this namespace, we have access to any classes defined in this namespace. So if we want to use a class that is defined
	   in a defferent namespace, we need to import it in our code file.

	3) System is a namespace in a .Net framework and that's where we have all these basic utility classes and primitive types.
	   System.Collections.Generic is used to work with lists, collections and so on. System.Text is used to work with texts and
	   coding and stuffs like that. System.Threading is used to build multi-threaded applications.

	4) Every console application you create with Visual Studio has a class called Program. Inside Program by default we have a
	   function or method called Main which is the entry point to the application. So when you run your application, CLR executes
	   the code inside main method and that's where everything kicks off.

	5) C# is case sensitive. The Main method is capitalized. If you forget to do that, CLR will not going to find this method as
	   the entry point of the application. Also notice that the 'string' type is lower cased.

	6) We have a class called Console which is used to read data from console or write data to it. It has many methods and we can
	   access those methods using the dot notation.

 */
