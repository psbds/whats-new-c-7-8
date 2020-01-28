using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class InferredTuple
	{

		public static void Run()
		{
			var min = 0;
			var max = 1;

			var range = (maximum: max, minimum: min);

			Console.WriteLine(range.maximum);
			Console.WriteLine(range.minimum);

			var range2 = (max, min);
			Console.WriteLine(range2.max);
			Console.WriteLine(range2.min);

			Debugger.Break();
		}
	}
}
