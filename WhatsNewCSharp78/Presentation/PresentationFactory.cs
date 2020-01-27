using System.Diagnostics;
using WhatsNewCSharp78.Model;

namespace WhatsNewCSharp78.Present
{
	internal class PresentationFactory
	{	
		public static Presentation CreateInstance()
		{
			var presentation = new Presentation()
			{
				Subject = EPresentationSubject.What_is_new_CSharp_7_to_8,
				PresentationUrl = "https://github.com/psbds/whats-new-c-7-8",
				Speaker = new Speaker()
				{
					Name = "Paulo Sérgio Baima",
					Company = new Company()
					{
						Name = "Microsoft",
						Role = "Cloud Solution Architect"
					},
					Linkedin = "linkedin.padasil.com",
					GitHub = "github.padasil.com"
				}
			};
			presentation.ToString();

			presentation.Topics = TopicFactory.GetTopics(presentation.Subject);

			return presentation;
		}
	}

	
}
