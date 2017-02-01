using System;

// when you move a class in a folder, the namespace is not automatically updated. So you have to manually write .Math to complete the namespace

namespace L27_Classses.Math 
{
	// make sure to declare the class as public. Otherwise, you won't be able to access this class from outside and thus will fail to
	// create an object of this class.
	public class Calculator2
	{
		public int Add (int a, int b) {
			return a + b;
		}
	}
}


/* Rmember we said that related classes are grouped together in a namespace. So it is more appropriate to move the calculator class
   to a different folder. So you right click on the project folder -> Add -> New Folder and name it. Then move in by dropping classes
   in the folder. Remember to update the namespace.
 
 */