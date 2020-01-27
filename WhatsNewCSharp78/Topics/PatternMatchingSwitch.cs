using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class PatternMatchingSwitch
	{

		public static void Run()
		{
			var objects = new ArrayList();

			objects.Add("batata");
			objects.Add(1);
			objects.Add(42);

			foreach (var obj in objects)
			{
				Debugger.Break();
				switch (obj)
				{
					case "batata":
						Console.WriteLine($"You got {obj}.");
						break;

					case int integer when integer == 42:
						Console.WriteLine($"You got the response of the universe and all things {integer}, the next number is {integer + 1}");
						Debugger.Break();
						break;

					case int integer:
						Console.WriteLine($"You got the number {integer}, the next number is {integer + 1}");
						Debugger.Break();
						break;

					default:
						break;
				}
			}
		}
	}
}
