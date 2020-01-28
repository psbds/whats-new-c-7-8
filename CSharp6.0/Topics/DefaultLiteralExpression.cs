using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0.Topics
{
	public static class DefaultLiteralExpression
	{
		private static void Run()
		{
			var a = 1;

			a = default(int);

			Console.WriteLine(a);

			Debugger.Break();

			a = default;
		}
	}
}
