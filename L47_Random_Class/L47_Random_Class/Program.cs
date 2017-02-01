using System;

namespace L47_Random_Class
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var random = new Random();

			for (var i = 0; i < 10; i++) {
				Console.WriteLine(random.Next());
			}
			Console.WriteLine();

			// If we want to generate random numbers between 1 and 10 (excluding 10), we do this:

			for (var j = 0; j < 10; j++) {
				Console.WriteLine(random.Next(1, 10));
			}
			Console.WriteLine();

			// we can use this technique to generate random characters such as: random passwords. Each character internally 
			// is represented using a number. Because computers don't understand characters and letters. They understand numbers.

			Console.WriteLine((int)'a');		// casting this to an int will give an ASCII code

			// If you generate a random number between 97 and 122 and then cast it to a character, we will get a random character
			// and we can repeat this few times and generate a random string like a password.

			for (var j = 0; j < 10; j++)
			{
				Console.Write((char)random.Next(97, 122));
			}
			Console.WriteLine();

			// we can make this look nicer and more professional. We have 26 alphabets in English language. This would generate
			// a random number between 0 and 26. And then we add the character 'a' with the randomly generated number. If we
			// add a character to a number we get a number. Because characters are internally represented by a number.

			for (var k = 0; k < 10; k++) {
				Console.Write((char)('a' + random.Next(0, 26)));
			}
			Console.WriteLine();

			// now in real world we don't just want to print numbers in the console. We want to save it in a string. Remember we said
			// before that string are immutable Which means once you create them you cannot change them. If you add something
			// to a string, the original string remains unaffected and you always create a new string.
			// So what we can do instead is we can store this result in an array and then create a string based in that array.
			// so instead of displaying the characters in the console, we can simply store it in the buffer.

			var buffer = new char[10];

			for (var k = 0; k < 10; k++)
			{
				buffer[k] = (char)('a' + random.Next(0, 26));
			}

			var password = new string(buffer);				// string is a keyword that maps to the String class in the .Net framework
	//		var password = buffer;							// this will also work

			Console.WriteLine(password);

			// Now we can improve the quality of our code by making a small modification. This code is now more expressive and
			// more reliable. Now if we want to change the length of our password, we can just simply change the passwordLength.

			const int passwordLength = 10;
			var Buffer = new char[passwordLength];

			for (var k = 0; k < passwordLength; k++)
			{
				Buffer[k] = (char)('a' + random.Next(0, 26));
			}

			var Password = new string(Buffer);
			Console.WriteLine(Password);


		}
	}
}
