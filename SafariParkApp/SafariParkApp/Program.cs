using System;

namespace SafariParkApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Person arthur = new Person("Arthur", "Tshaka", 23);
			Console.WriteLine(arthur.GetFullName());
		}
	}
}
