using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsNewCSharp78.Model
{
	public class Topic
	{
		public string Name { get; set; }

		public Topic(string name)
		{
			ConsoleWrite.WriteLine($"{new String('-', 10)} {name}", ConsoleColor.Green);
			this.Name = name;
		}
	}
}
