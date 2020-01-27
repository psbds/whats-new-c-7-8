using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsNewCSharp78.Model
{
	public class Presentation
	{
		public EPresentationSubject Subject { get; set; }

		public string PresentationUrl { get; set; }

		public Speaker Speaker { get; set; }

		public IEnumerable<Topic> Topics { get; set; }

		public override string ToString()
		{
			ConsoleWrite.Write("Subject: ");
			ConsoleWrite.Write($"{this.Subject.ToString()}", ConsoleColor.Cyan);
			Console.WriteLine();

			ConsoleWrite.Write("Presentation URL: ");
			ConsoleWrite.Write($"{this.PresentationUrl.ToString()}", ConsoleColor.Cyan);
			Console.WriteLine();

			ConsoleWrite.Write($"Speaker: ");
			ConsoleWrite.Write($"{this.Speaker.Name}", ConsoleColor.Cyan);
			Console.WriteLine();

			ConsoleWrite.Write("Company: ");
			ConsoleWrite.Write($"{this.Speaker.Company.Name}", ConsoleColor.Cyan);
			Console.WriteLine();

			ConsoleWrite.Write("Role: ");
			ConsoleWrite.Write($"{this.Speaker.Company.Role}", ConsoleColor.Cyan);
			Console.WriteLine();

			ConsoleWrite.WriteLine($"Contacts:");

			ConsoleWrite.WriteLine($"- LinkedIn: {this.Speaker.Linkedin}", ConsoleColor.Cyan);
			ConsoleWrite.WriteLine($"- GitHub: {this.Speaker.GitHub}", ConsoleColor.Cyan);

			return base.ToString();
		}
	}
}
