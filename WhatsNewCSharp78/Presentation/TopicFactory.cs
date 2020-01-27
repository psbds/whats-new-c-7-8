using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WhatsNewCSharp78.Model;
using WhatsNewCSharp78.Topics;

namespace WhatsNewCSharp78.Present
{
	static class TopicFactory
	{
		public static IEnumerable<Topic> GetTopics(EPresentationSubject presentationSubject)
		{
			switch (presentationSubject)
			{
				case EPresentationSubject.What_is_new_CSharp_7_to_8:
					return GetTopicsForWhatsNewCSharp();
				default:
					throw new NotImplementedException();
			}
		}

		static private IEnumerable<Topic> GetTopicsForWhatsNewCSharp()
		{
			Debugger.Break();
			var topics = new List<Topic>();

			// C# 7 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#throw-expressions
			topics.Add(new Topic("Throw Expressions"));
			ThrowExp.Run();

			Debugger.Break();

			// C# 7 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#tuples"
			topics.Add(new Topic("Tuples"));
			Tuples.Run();

			Debugger.Break();

			// C# 7 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#pattern-matching
			topics.Add(new Topic("Pattern Matching"));
			PatternMatchingIs.Run();
			PatternMatchingSwitch.Run();

			Debugger.Break();

			// C# 7 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#discards
			topics.Add(new Topic("Discards"));
			Discards.Run();

			Debugger.Break();

			// C# 7 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions
			// C# 8 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#static-local-functions
			topics.Add(new Topic("Local Functions & Static Local Functions."));
			LocalFunctions.Run();

			Debugger.Break();


			return topics;
		}

	}
}
