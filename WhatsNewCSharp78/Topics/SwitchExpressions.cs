using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public class SwitchExpressions
	{
		public static void Run()
		{
			var color = ConsoleColor.Red;


			int result;
			switch (color)
			{
				case ConsoleColor.Red:
					result = 0;
					break;
				case ConsoleColor.Yellow:
					result = 1;
					break;
				case ConsoleColor.Green:
					result = 2;
					break;
				case ConsoleColor.Blue:
					result = 3;
					break;
				default:
					result = 3;
					break;
			};


			var result2 = color switch
			{
				(ConsoleColor.Red) => 0,
				(ConsoleColor.Yellow) => 1,
				(ConsoleColor.Green) => 2,
				(ConsoleColor.Blue) => 3,
				_ => 4
			};


			var result3 = GetSwitch(color);

			Debugger.Break();
		}

		private static int GetSwitch(ConsoleColor color) => color switch
		{
			(ConsoleColor.Red) => 0,
			(ConsoleColor.Yellow) => 1,
			(ConsoleColor.Green) => 2,
			(ConsoleColor.Blue) => 3,
			_ => 4
		};

	}
}
