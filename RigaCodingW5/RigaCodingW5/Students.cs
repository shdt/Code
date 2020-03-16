using System;
using System.Collections.Generic;
using System.Text;

namespace RigaCodingW5
{
	class Students
	{
		private string name;
		private string surname;
		private int course;
		public Students (string name, string surname, int course)
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

		public void SetName(string inputName)
		{
			name = inputName;
		}

		public void SetSurname(string inputSurname)
		{
			surname = inputSurname;
		}

		public void SetCourse(int inputCourse)
		{
			course = inputCourse;
		}
		public void Print()
		{
			Console.WriteLine( $"{name} {surname} {course}");
		}
	}
}
