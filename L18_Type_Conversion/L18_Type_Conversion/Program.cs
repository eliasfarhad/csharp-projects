using System;

namespace L18_Type_Conversion
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Implicit type conversion. When the compiler sees the conversion, it prefixes the 1 with 0's to fill up 4 bytes(int), so there
			// is no data loss. When the compiler sees values could be converted without any data loss, it performs implicit conversion.

			byte b = 1;							// 							  00000001
			int i = b;                          // 00000000 00000000 00000000 00000001
			Console.WriteLine(i);

			int x = 2;
			float f = x;                        // another example. No data loss will happen.
			Console.WriteLine(f);

			// Explicit type conversion. When you convert a byte (1 bit) to an int (4 bytes), there is a chance of data loss.
			// So the compiler will complain. That's why you need to explicitly tell the compiler that you are aware of the situation and you still want to
			// go ahead with this. So explicitly metion the target type of the conversion. It is also known as casting.

			int j = 5;
			byte c = (byte)j;
			Console.WriteLine(c);

			float F = 2.5f;
			int k = (int)F;                     // another example
			Console.WriteLine(k);

			// Non-compatible types. Example: converting a string to an int. So accomplish this task use the Convert class or the parse() method.
			// Convert class is part of .Net framework. So it is defined in the System namespace. It has many methods to convert different types to other types.
			// Int32() is the method for converting to an integer.

			string s = "9";
			int m = Convert.ToInt32(s);			// you can use Convert class to convert non-compatible types.
			int n = int.Parse(s);
			// m = (int) s;                  	//  wiil not work. Non-compatible data types

			Console.WriteLine(m);
			Console.WriteLine(n);


			// ==============  Lecture 19: Demo - Type Conversion
			// The code you put inside the try block will be monitored and if an exception happens the catch block will be executed. This prevents your
			// application from crashing. If you put the code from the try block without try/catch mechanism, your application will crash. Because, you did not
			// handle the exception. So if you don't handle the exception, the exception will be propogated to the .Net runtime and the runtime mechanism will
			// stop your application and display the error. So by using try/catch, we can handle the exception and that will stop the exception from being propogated
			// to the runtime. Inside the catch block you can display a friendly message. The Convert class works pretty well in most of cases, but in cases when the 
			// source type cannot be converted to the target type, there is a chance for exception.

			try  									// this is a code snippet
			{
				var number = "1234";
				byte bt = Convert.ToByte(number);
				Console.WriteLine(bt);
			}
			catch (Exception)
			{
				Console.WriteLine("The number could not be converted to a byte");
			}


			string str = "false";
			bool b1 = Convert.ToBoolean(str);
			Console.WriteLine(b1);

			int t = 1;								// 1 is True, 0 is False
			bool b2 = Convert.ToBoolean(t);
			Console.WriteLine(b2);
		}
	}
}



/*
   Agenda: 1) Implicit type conversion
           2) Explicit type conversion
           3) Conversion between non-compatible types
 
  
 */