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

			// C# 7.1 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#async-main
			topics.Add(new Topic("Async Main"));

			Debugger.Break();

			// C# 7.1 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#default-literal-expressions
			topics.Add(new Topic("Default Literal Expressions"));
			DefaultLiteralExpressions.Run();

			Debugger.Break();

			// C# 7.1 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-1#inferred-tuple-element-names
			topics.Add(new Topic("Inferred Tuple Property Names"));
			InferredTuple.Run();

			Debugger.Break();


			// C# 7.2 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-2#safe-efficient-code-enhancements
			// https://docs.microsoft.com/en-us/dotnet/csharp/write-safe-efficient-code
			topics.Add(new Topic("Safe Code Enhancements"));

			Debugger.Break();


			// C# 7.2 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-2#private-protected-access-modifier
			topics.Add(new Topic("Private Protected modifier"));
			PrivateProtected.Run();
			Debugger.Break();

			// C# 7.3 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3
			topics.Add(new Topic("C# 7.3 Improvements"));

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#default-interface-methods
			topics.Add(new Topic("Interface Implementation"));
			InterfaceImplementation.Run();

			Debugger.Break();

			// C# 8.0 -  https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#more-patterns-in-more-places
			topics.Add(new Topic("Switch Expressions"));
			SwitchExpressions.Run();

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations
			topics.Add(new Topic("Using Declaration"));
			UsingDeclaration.Run();

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations
			topics.Add(new Topic("Nullable Refernce types"));
			NullableRefTypes.Run();

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#asynchronous-streams
			topics.Add(new Topic("Async Streams"));
			AsyncStream.Run();

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#null-coalescing-assignment
			topics.Add(new Topic("Null Coalescing Assignment"));
			NullCoalescing.Run();

			Debugger.Break();

			// C# 8.0 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
			topics.Add(new Topic("Indexes and Ranges"));
			IndexesAndRanges.Run();

			Debugger.Break();
			
			return topics;
		}

	}
}
