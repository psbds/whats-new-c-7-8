using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewCSharp78.Topics
{
	public static class AsyncStream
	{

		public async static void Run()
		{
			await foreach (var number in GenerateSequence())
			{
				Console.WriteLine(number);
			}

			Debugger.Break();
		}

		public static async IAsyncEnumerable<int> GenerateSequence()
		{
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(100);
				yield return i;
			}
		}

	}
}
