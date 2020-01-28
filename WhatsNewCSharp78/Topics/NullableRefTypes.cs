using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
//#nullable enable

// <Nullable>enable</Nullable>
namespace WhatsNewCSharp78.Topics
{
	class NullableRefTypes
	{

		public static void Run()
		{
			string mystring = new String('=', 10);
			
			mystring = null;

			Debugger.Break();
		}


	}
}
