using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public static class UsingDeclaration
	{

		public static void Run()
		{
			Debugger.Break();

		}



		private static long GetFileSize1(bool condition)
		{
			FileStream file;
			if (condition)
			{
				using (file = new FileStream(@"C:/Test.txt", FileMode.Open))
				{
					// [Logic]
					return file.Length;
				} // Dispose here
			}
			else
			{
				using (file = new FileStream(@"C:/Test2.txt", FileMode.Open))
				{
					// [Same Logic]
					return file.Length;
				} // Dispose here
			}
		}




		private static long NewApproach(bool condition)
		{
			using FileStream file = condition ? new FileStream(@"C:/Test.txt", FileMode.Open) : new FileStream(@"C:/Test2.txt", FileMode.Open);
			// Run Logic
			return file.Length;     // Dispose Here
		}
	}
}
