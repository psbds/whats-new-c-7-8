using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class Discards
	{
		public static void Run()
		{
			TupleExample();
			SwitchExample();
			OutExample();
		}

		public static void TupleExample()
		{
			(int _, int max) = GetRange(new int[] { 1, 3, 5, 7, 9 });

			Console.WriteLine($"{max}");
			Debugger.Break();
		}

		private static (int max, int min) GetRange(int[] numbers)
		{
			var numberLitst = numbers.ToList();
			return (numberLitst.Max(), numberLitst.Min());
		}

	

		public static void SwitchExample()
		{
			var objects = new ArrayList();

			objects.Add("batata");
			objects.Add(1);
			objects.Add(42);

			foreach (var obj in objects)
			{
				switch (obj)
				{
					case "batata":
						Console.WriteLine($"You got {obj}.");
						break;

					case int integer when integer == 42:
						Console.WriteLine($"You got the response of the universe and all things {integer}, the next number is {integer + 1}");
						break;

					case int _:
						Console.WriteLine($"You got a number");
						break;

					default:
						break;
				}
			}
			Debugger.Break();
		}

		private static void OutExample()
		{
			var i = DoSomething(out _);
			Debugger.Break();
		}

		private static int DoSomething(out string abc)
		{
			abc = "Hello World";

			return 1;
		}
	}
}
