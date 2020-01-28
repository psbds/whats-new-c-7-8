using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class IndexesAndRanges
	{
		public static void Run()
		{
			var numbers = new int[] {
				0,	// 0 ^10
				1,	// 1 ^9
				2,	// 2 ^8
				3,	// 3 ^7
				4,	// 4 ^6
				5,	// 5 ^5
				6,	// 6 ^4
				7, 	// 7 ^3
				8, 	// 8 ^2
				9	// 9 ^1
			};

			Console.WriteLine($"Last Number {numbers[^1]}"); // Print 9

			Console.WriteLine($"First 4 numbers {string.Join(',', numbers[0..4])}"); // Print 0, 1, 2, 3

			Console.WriteLine($"Last 3 Numbers {string.Join(',', numbers[^3..^0])}"); // Print 7, 8, 9

			Console.WriteLine($"All Numbers {string.Join(',', numbers[..])}"); // Print All Numbers

			Console.WriteLine($"From Beggining to number 4 {string.Join(',', numbers[..5])}"); // Print 0, 1, 2, 3, 4

			Console.WriteLine($"From 5 to the end {string.Join(',', numbers[5..])}"); // Print 5, 6, 7, 8, 9

			Range range = 1..6;

			Console.WriteLine($"Numbers {string.Join(',', numbers[range])}");


			Debugger.Break();


		}

	}
}
