using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
	class StudentList
	{
		public string name;
		public string surname;
		public int course;

		public StudentList(string name, string surname, int course)
		{
			this.name = name;
			this.surname = surname;
			this.course = course;
		}

		public string GetName()
		{
			return name;
		}
		public string GetSurname()
		{
			return surname;
		}
		public int GetCourse()
		{
			return course;
		}
		public void SetName(string input)
		{
			name = input;
		}
		public void SetSurname(string input)
		{
			surname = input;
		}
		public void SetCourse(int input)
		{
			course = input;
		}
		public void Print()
		{
			Console.WriteLine( $"{name} {surname} {course}");
		}

		public string Full()
		{
			return $"{name} {surname} {course}";
		}

	}
}
