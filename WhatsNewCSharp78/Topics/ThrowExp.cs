using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WhatsNewCSharp78.Topics
{
	public class ThrowExp
	{
		///<see cref="CSharp6.0\Topics\ThrowExp.cs"/>
		public static void Run()
		{
			/*
			 * Throw is now an expression, not only an statement
			 */

			// Conditional Operators
			var var1 = true ? 1 : throw new Exception();

			// Nullable Operators
			var var2 = "Hello" ?? throw new Exception();

			// Lambda Expressions
			Action var3 = () => throw new Exception();

			Debugger.Break();

		}
	}
}
