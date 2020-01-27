using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace WhatsNewCSharp78.Topics
{
	public static class PatternMatchingIs
	{
		class Person
		{
			public Person(string name) => Name = name;
			public string Name { get; set; }
		}

		class Animal
		{
			public Animal(string type) => Type = type;
			public string Type { get; set; }
		}

		public static void Run()
		{
			ArrayList objects = new ArrayList() { new Person("Breno"), new Animal("Galo") };

			foreach (var obj in objects)
			{
				Print(obj);
			}
			Debugger.Break();

			foreach (var obj in objects)
			{
				PrintNew(obj);
			}
			Debugger.Break();
		}

		private static void Print(object obj)
		{
			if (obj is Person)
			{
				var person = obj as Person;
				// or var person = (Person)obj;

				Console.WriteLine(person.Name);
			}
			else if (obj is Animal)
			{
				var animal = obj as Animal;
				// or var animal = (Animal)obj;
				Console.WriteLine(animal.Type);
			}

		}

		#region The New Way
		private static void PrintNew(object obj)
		{
			if (obj is Person person)
				Console.WriteLine(person.Name);
			else if (obj is Animal animal)
				Console.WriteLine(animal.Type);
		}

		#endregion
	}
}
