using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Standard { get; set; }

	}
	class School : IEnumerable
	{
		List<Student> students	= new List<Student>();
		public void add(Student s)
		{
			students.Add(s);
		}

		public IEnumerator GetEnumerator()
		{
			return students.GetEnumerator();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student std1 = new Student();

			std1.Id = 1;
			std1.Name = "Ram";
			std1.Standard = 10;

			Student std2 = new Student();
			std2.Id = 2;
			std2.Name = "Sham";
			std2.Standard = 11;

			Student std3 = new Student();
			std3.Id = 3;
			std3.Name = "Jay";
			std3.Standard = 12;

			School students = new School();
			students.add(std1);
			students.add(std2);
			students.add(std3);

			foreach (Student item in students)
			{
				Console.WriteLine(item.Id + " " + item.Name + " " + item.Standard);
			}
			Console.ReadLine();
		}

	}
}
