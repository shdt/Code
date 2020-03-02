using System;

namespace RigaCodingW5
{
	class Program
	{
		private static bool looper = true;
		static void Main(string[] args)
		{
			//Students st1 = new Students("Janis", "Berzins", 2);

			//Console.WriteLine(st1.GetName());

			//Students[] a = new Students[5];
			//a[0] = new Students("Janis", "Berzins", 2);

			//Tasks.AddStudents();

			//bool looper = true;

			Students[] list = new Students[5];

			while (looper == true)
			{
				Console.WriteLine("What do you wanty to do?");
				Console.WriteLine("1. See the students list");
				Console.WriteLine("2. Add the student");
				Console.WriteLine("3. Edit students list");
				Console.WriteLine("4. EXIT or QUIT");
				int input = Convert.ToInt32(Console.ReadLine());
				MenuActions(input, list);
			}
		}

		static void MenuActions(int input, Students[] list)
		{
			if (input == 1)
			{
				Methods.ListStudent(list);
				Console.WriteLine("_________________________________________");
			}

			else if (input == 2)
			{
				Methods.AddStudent(list, Methods.SelectFreeStudentSlot(list));
				Console.WriteLine("_________________________________________");
			}
			else if (input == 3)
			{
				Methods.EditStudent(list, Methods.SelectStudentSlot(list));
				Console.WriteLine("_________________________________________");
			}
			else if (input == 4)
			{
				looper = !looper;
			}
			else
			{
				Console.WriteLine("Smthing went wrong. Starting over.");
				Console.WriteLine("_________________________________________");
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
