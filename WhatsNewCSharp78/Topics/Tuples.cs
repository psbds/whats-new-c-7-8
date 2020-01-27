using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class Tuples
	{

		public static void Run()
		{
			(int min, int max) = GetRange(new int[] { 1, 3, 5, 7, 9 });

			Console.WriteLine($"{min}, {max}");

			var range = GetRange(new int[] { 1, 3, 5, 7, 9 });

			Console.WriteLine($"{range.min},{range.max}");

			Debugger.Break();

			// How Tuples were Before

			(int min2, int max2) = GetRangeOld(new int[] { 1, 3, 5, 7, 9 });

			var range2 = GetRangeOld(new int[] { 1, 3, 5, 7, 9 });

			Console.WriteLine($"{range2.Item1},{range2.Item2}");

			var fakeStruct = new TupleStruct();

			Debugger.Break();
		}


		private static (int max, int min) GetRange(int[] numbers)
		{
			var numberLitst = numbers.ToList();
			return (numberLitst.Max(), numberLitst.Min());
		}


		// How Tuples were Before
		private static Tuple<int, int> GetRangeOld(int[] numbers)
		{
			var numberLitst = numbers.ToList();
			return new Tuple<int, int>(numberLitst.Max(), numberLitst.Min());
		}

		#region Tuple Struct
		struct TupleStruct
		{
			int Item1;
			int Item2;
		}
		#endregion

		#region When not to use
		private static void WhenNotToUse()
		{
			// Get the cartesian local of an object

			var point = GetPoint(new { });

			Console.WriteLine($"{point.x},{point.y}");
		}

		private static Point GetPoint(object whatever)
		{
			// [...] any logic
			var point = new Point(1, 2);

			return point;
		}

		struct Point
		{
			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
			public double x;
			public double y;
		}
		#endregion

	}
}
