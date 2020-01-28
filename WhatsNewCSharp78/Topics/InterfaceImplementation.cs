using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class InterfaceImplementation
	{

		public static void Run()
		{

			Debugger.Break();
		}
	}

	public interface Repository
	{
		public void DoSomething()
		{
			Console.WriteLine("Hello!");
		}
	}
}
