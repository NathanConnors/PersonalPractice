using System;

namespace ImmutableString
{
	class Program
	{
		static void Main(string[] args)
		{
			// Initialize a string, it is actually instantiated an object
			String s = "This is my string";
			
			// Appears to overwrite string but is actually crating a new object
			s = "new string";
			Console.WriteLine(s);
			
			// Again creates a new object
			s += " is immutable";
			Console.WriteLine(s);

		}
	}
	
}