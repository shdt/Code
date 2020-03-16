using System;

namespace RigaCodingW5
{
	class Program
	{
		private static bool looper = true;

		static void Main(string[] args)
		{
			Students[] array = new Students[5];

			while (looper == true)
			{
				Console.WriteLine("What do you wanty to do?");
				Console.WriteLine("1. See the students list");
				Console.WriteLine("2. Add the student");
				Console.WriteLine("3. Edit students list");
				Console.WriteLine("4. EXIT or QUIT");
				int input = Convert.ToInt32(Console.ReadLine());
				MenuActions(input, array);
			}
		}

		static void MenuActions(int input, Students[] array)
		{
			if (input == 1)
			{
				Methods.ListStudent(array);
				Console.WriteLine("_________________________________________");
				Console.WriteLine();
			}

			else if (input == 2)
			{
				Methods.AddStudent(array, Methods.SelectFreeStudentSlot(array));
				Console.WriteLine("_________________________________________");
				Console.WriteLine();
			}
			else if (input == 3)
			{
				Methods.EditStudent(array, Methods.SelectStudentSlot(array));
				Console.WriteLine("_________________________________________");
				Console.WriteLine();
			}
			else if (input == 4)
			{
				looper = !looper;
			}
			else
			{
				Console.WriteLine("Smthing went wrong. Starting over.");
				Console.WriteLine("_________________________________________");
				Console.WriteLine();
			}
		}

		static void Same()
		{
			//Students st1 = new Students("Janis", "Berzins", 2);

			//Console.WriteLine(st1.GetName());

			//Students[] a = new Students[5];
			//a[0] = new Students("Janis", "Berzins", 2);

			//Tasks.AddStudents();
		}
	}
}
