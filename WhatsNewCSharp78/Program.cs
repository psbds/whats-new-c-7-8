using System;
using System.Threading.Tasks;
using WhatsNewCSharp78.Present;

namespace WhatsNewCSharp78
{
	class Program
	{
		async static Task<int> Main(string[] args)
		{
			PresentationFactory.CreateInstance();

			return await Task.FromResult(0);
		}
	}
}
