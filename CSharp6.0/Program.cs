using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = true ? 1 : throw new Exception();
		}
	}
}
