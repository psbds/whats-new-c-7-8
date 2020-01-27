using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class LocalFunctions
	{
		public static object Debgger { get; private set; }

		public static void Run()
		{
			var myValue = 0;

			Print();
			Print2();

			void Print()
			{
				Console.WriteLine("Hello World + " + myValue);
				Debugger.Break();
			}

			static void Print2()
			{
				// Console.WriteLine("Hello World + " + myValue);
				Debugger.Break();
			}


			#region How was before

			Action a = () => Console.WriteLine("Hello World");

			a();

			Func<string> b = () => "Hello";

			Console.WriteLine(b());

			Debugger.Break();
			#endregion


		}

		private static void Whatever()
		{
			// Print();
			// Print2();
		}
	}
}
