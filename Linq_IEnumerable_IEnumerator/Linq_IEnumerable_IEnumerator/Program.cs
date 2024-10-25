using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_IEnumerable_IEnumerator
{
	internal class Program
	{
		// If we use these two methods for IEnumerable it show some different output...not same
		static void show1(IEnumerator<int> n)
		{
			while (n.MoveNext())
			{
                Console.WriteLine(n.Current);
				if (n.Current == 44)
				{
					show2(n);
				}
			}
		}
		static void show2(IEnumerator<int> n)
		{
			while (n.MoveNext())
			{
                Console.WriteLine(n.Current);
			}
		}
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

			// this generic list is for methods
			List<int> NumberSet = new List<int> { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
			IEnumerator<int> n1 = NumberSet.GetEnumerator();
			show1(n1);

			// through linq fetching data 
			var nums = from i in numbers where i > 5 select i;

			// displaying the number using foreach
			foreach (var num in nums)
			{
				Console.WriteLine(num);
			}
			Console.WriteLine("---------------------------------------");


			// Now fetching through ienumerable and displaying
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("----------------------------------------");
			// now fetching and through IEnumarator
			IEnumerator<int> numbs = numbers.GetEnumerator();

			// now displaying data through IEnumerator
			while(numbs.MoveNext())
				{
					Console.WriteLine(numbs.Current.ToString());
				}
				Console.ReadLine();

			}
		}
	}
