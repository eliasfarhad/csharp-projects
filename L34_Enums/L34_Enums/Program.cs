using System;

namespace L34_Enums
{
	// since enum is a new type we need to declare it in the namespace level.
	public enum ShippingMethod
	{
		RegularMail = 1,								// if you don't set a value to the members of an enum, the first default value is automatically going to be zero.
		RegisteredMail = 2,								// the value of the next members would be incremented by 1. But for best programming practice, assign a value
		Express	= 3										// to your enum. Because you most likely have these delivery methods with their values saved in databases.
														// So later on, if you add a new shipping method, all the values following that shipping method will automatically
														// change. This will cause significant problem in the database.
	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			//============  Converting an enum To/From an integer  ===================

			var method = ShippingMethod.Express;
			Console.WriteLine(method);
			Console.WriteLine((int)method);             // As we told before, an enum is internally an integer. So we can cast method to get the numeric value of that enum.

			// Now there could be situations when you receive the numeric shipping ID and you want to convert it to a shipping method. In that case you can convert using
			// casting.
			var methodID = 2;							// let's say I received this value from the database
			Console.WriteLine((ShippingMethod)methodID);
		
			//============  Converting an enum To/From a string  ======================
			// Every object in C# has a method called toString(). So technically you can convert anything to a string without doing any extra work.
		
			Console.WriteLine(method.ToString());       // Now as a tip, Console.WriteLine() by default always calls the toString() method on any value you pass to it.
			Console.WriteLine(method);                  // So it will still work without the toString() method. But in case you are not using Console.WriteLine(), you
														// need to explicitly call the toString() method.

			string methodName = "RegularMail";          // Let's say I received this string from the database and I want to convert it to an enum
			var shipMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
			Console.WriteLine(shipMethod);

			// (above) As a practical approach whenever you see the Type object, you can use the typeof keyword. ShippingMethod (inside typeof) is the target type and
			// methodName is the string that we are converting from. The Enum class is part of System namespace, so make sure you have that imported. Enum class has many
			// static methods and Parse() is one of them. I am parsing from a string to another type. This method still returns an object. So I have to cast it to 
			// ShippingMethod. Now I can save this to a varibale. If you hover over the variable, it will show you what kind of varibale it is.
		}
	}
}




/*
  Imagine you are building an application for a shipping company and you want to support few different shipping methods. So one way is
  to declare few constants, each declaring a shipping method. And in your application based on the shipping method you can calculate costs,
  number of days to deliver an item etc.
  
  					const int RegularMail = 1;
  					const int RegisteredMail = 2;
  					const int Express = 3;
  
Although the above method works, that looks a little bit messy. It is better to declare a new type where we can represent different shipping methods.
So that's why we use enum. In simple words, use enum when you have a number of related constants. Instead of declaring multiple constants, declare an enum.
This will be a new type in your application just like we have classes or structs. 

					public enum ShippingMethod {
						RegularMail = 1;
						RegisteredMail = 2;
						Express = 3;
					}

Now that we have an enum, we can use it with a '.' notation.

					var method = ShippingMethod.Express;

Enum is internally an integer. If you have a reason to change it and use byte instead, may be for database purposes, then you can specify byte during declaration
of your enum.
					public enum ShippingMethod : byte {
						RegularMail = 1;
						RegisteredMail = 2;
						Express = 3;
					}

 */