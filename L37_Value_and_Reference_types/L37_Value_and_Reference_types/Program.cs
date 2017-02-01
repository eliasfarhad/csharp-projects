using System;

namespace L37_Value_and_Reference_types
{
	class Person
	{
		public int Age;
	}

	class MainClass
	{
		public static void Main(string[] args)
		{


			// ============ L 36 ============

			var a = 10;
			var b = a;
			b++;
			Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

			var array1 = new int[3] { 1, 2, 3};
			var array2 = array1;
			array2[0] = 4;
			Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

			var number = 2;
			Increment(2);
			Console.WriteLine(number);

			var person = new Person() {Age = 20};
			MakeOld(person);
			Console.WriteLine(person.Age);

			string word1 = "Potato";
			string word2 = word1;
			word2 = "Mango";
			Console.WriteLine(word1);
		}


		public static void Increment(int number)
		{
			number += 10;
		}

		public static void MakeOld(Person person) 
		{
			person.Age += 25;
		}

	}
}


/*
 If this is confusing, avoid this reading. skip to ##########
 
 All types are either Structures (value types) or Classes (reference types). All the primitive types are structures.

Structures: 1) Primitive types
			2) Custom structures

Classes:    1) Arrays
			2) Strings
			3) Custom classes

############

 When you create a variable that is value type, a part of memory called stack is allocated for that variable. This memory allocation is done automatically
 and when the variable goes out of scope, it will immediately get removed from stack by CLR.

 With reference types however, the programmer needs to allocate memory. When call the new operator, you are creating a reference type objec and we tell the 
 runtime to allocate memory to this object. This memory is allocated in a different part of the memory called heap. And the varibale name is created in the
 stack which holds the address (reference) to the object in the heap.

 Although string is a reference type data type, it has value type properties.

 */