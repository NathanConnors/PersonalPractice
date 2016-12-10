/*
* A program that illustrates ability to put class on same pagel
* Uses command line compile.
*/
using System;

namespace OneFileClass
{
	class Program
	{
		static void Main(string[] args)
		{
			// Default constructor call
			MyClass c1 = new MyClass();
			c1.getInt();
			
			// Non-default constructor call
			MyClass c2 = new MyClass(4);
			c2.getInt();
		}
	}
	
	class MyClass
	{
		public int myInt;
		
		public MyClass()
		{
			myInt = 1;
		}
		
		public MyClass(int myInt)
		{
			this.myInt = myInt;
		}
		
		public void getInt()
		{
			Console.WriteLine(myInt);
		}
	}
}