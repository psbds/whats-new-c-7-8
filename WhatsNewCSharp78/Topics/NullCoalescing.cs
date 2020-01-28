using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class NullCoalescing
	{

		public static void Run()
		{
			string a = null;

			var mystring = a ?? "Hello World";


			Console.WriteLine(a);
			Console.WriteLine(mystring);
			Console.WriteLine("----");

			Debugger.Break();

			string b = null;

			var mystring2 = b ??= "Hello World";
			Console.WriteLine(b);
			Console.WriteLine(mystring2);

			Debugger.Break();
		}
	}
}
