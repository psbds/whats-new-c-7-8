using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsNewCSharp78
{
	public static class ConsoleWrite
	{
		public static void Write(string value, ConsoleColor? color = null)
		{
			if (color != null)
				Console.ForegroundColor = color.Value;

			Console.Write(value);

			if (color != null)
				Console.ResetColor();
		}
		public static void WriteLine(string value, ConsoleColor? color = null)
		{
			if (color != null)
				Console.ForegroundColor = color.Value;
			
			Console.WriteLine(value);

			if (color != null)
				Console.ResetColor();
		}
	}
}
