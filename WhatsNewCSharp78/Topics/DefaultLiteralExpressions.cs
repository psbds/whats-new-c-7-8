using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class DefaultLiteralExpressions
	{

		public static void Run()
		{
			var a = 1;

			a = default(int);

			Console.WriteLine(a);

			Debugger.Break();

			a = default;

		}
	}
}
