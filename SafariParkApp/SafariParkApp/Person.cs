using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
	public class Person
	{
		private string _firstName;
		private string _lastName;

		public int Age { get; set; }
		public Person(string firstName, string lastName, int age)
		{
			_firstName = firstName;
			_lastName = lastName;
			Age = age;
		}
		public string GetFullName()
		{
			return $"{ _firstName} {_lastName}";
		}
			
		
	}
}