using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class PrivateProtected
	{

		public static void Run()
		{
			var obj1 = new Hello();
			//	Console.WriteLine(obj1.number);
			Console.WriteLine(obj1.number2);

			Debugger.Break();
		}
	}

	public class HelloChild : Hello
	{
		public HelloChild()
		{
			Console.WriteLine(this.number);
			Console.WriteLine(this.number2);
		}
	}

	// Child AND are in the same assembly
	public class Hello
	{

		// Is Child and are in the same assembly
		protected private int number { get; set; }

		// Is Child OR are in the same assembly
		protected internal int number2 { get; set; }


	}


}
