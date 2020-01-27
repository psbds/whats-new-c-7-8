using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0.Topics
{
	class ThrowExp
	{
		public static void Run()
		{
			var var1 = true ? 1 : throw new Exception();

			var var2 = "Hello" ?? throw new Exception();

			Action act = () => throw new Exception();
		}

	}
}
