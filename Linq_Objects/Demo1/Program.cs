using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// creating array list 
			int[] Numbers = { 1, 2, 3,4,5 };

			// selecting numbers greater than 2 using linq syntax
			var num = from i in Numbers where i > 2 select i;
			
			// display retrived num array
			Console.WriteLine("Numbers greater than 2 :");
			foreach (int n in num)
			{
				Console.WriteLine(n);
			}

			// creating city names 
			string[] cities = { "Pune", "mumbai", "Delhi", "Nagpur" };
			
			// writing linq syntax query to retrive city name contains a in their names
			var city = from i in cities where i.Contains("a") orderby i descending select i;
			// by default if we not write desciding or ascending it will sort as ascending

			// displaying city names containing a in their name
			Console.WriteLine("City names with a in their names :");
			foreach(string n in city)
			{
				Console.WriteLine(n);
			}
			Console.ReadLine();
		}
	}
}
