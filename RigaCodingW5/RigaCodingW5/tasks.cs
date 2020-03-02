using System;
using System.Collections.Generic;
using System.Text;

namespace RigaCodingW5
{
	class Tasks
	{
		private static int GetRandom()
		{
			Random random = new Random();
			return random.Next(1, 100);

			//int[] a = new int[5];

			//a[0] = 4;
			//a[1] = 88;
			//a[2] = 93;
			//a[3] = 1;
			//a[4] = 6;

			//int[] c = { 4, 88, 93, 1, 6 };
		}

		public static void Task1()
		{
			int[] first = new int[5];
			for (int i = 0; i < first.Length; i++)
			{
				first[i] = GetRandom();
			}

			Console.WriteLine("Insert length of massive:");
			int length = Convert.ToInt32(Console.ReadLine());

			if (length <= 5)
			{
				for (int i = 0; i < first.Length; i++)
				{
					Console.Write(first[i] + " ");
				}
			}
			else
			{
				int[] second = new int[length];
				for (int i = 0; i < first.Length; i++)
				{
					second[i] = first[i];
				}
				for (int i = first.Length; i < second.Length; i++)
				{
					second[i] = GetRandom();
				}
				for (int i = 0; i < first.Length; i++)
				{
					Console.Write(first[i] + " ");
				}
			}
		}

		public static void Task1b()
		{
			int[] first = new int[5];
			for (int i = 0; i < first.Length; i++)
			{
				first[i] = GetRandom();
			}

			Console.WriteLine("Insert length of massive:");
			int length = Convert.ToInt32(Console.ReadLine());

			if (length <= 5)
			{
				for (int i = 0; i < first.Length; i++)
				{
					Console.Write(first[i] + " ");
				}
			}
			else
			{
				int[] temp = new int[first.Length];
				for (int i = 0; i < first.Length; i++)
				{
					temp[i] = first[i];
				}

				first = new int[length];

				for (int i = temp.Length; i < first.Length; i++)
				{
					first[i] = GetRandom();
				}
			}

			for (int i = 0; i < first.Length; i++)
			{
				Console.Write(first[i] + " ");
			}
			Console.WriteLine();

		}

		public static void Task2()
		{
			int[] massive = new int[100];

			massive[massive.Length - 1] = GetRandom();

			massive[0] = GetRandom();

			for (int i = 1; i < massive.Length - 1; i++)
			{
				massive[i] = massive[i - 1] + massive[massive.Length - 1];
			}

			for (int i = 0; i < massive.Length; i++)
			{
				Console.WriteLine(massive[i]);
			}
		}

		public static void Task3()
		{
			string[] inputStrings = new string[5];

			for (int i = 0; i < inputStrings.Length; i++)
			{
				Console.WriteLine($"insert text for value #{i + 1}:");
				inputStrings[i] = Console.ReadLine();
			}

			Console.WriteLine("results:");
			for (int i = 0; i < inputStrings.Length; i++)
			{
				if (inputStrings[i].Length > 5)
				{
					inputStrings[i] = "vii";
				}
				Console.Write($"{inputStrings[i]} ");
			}
			Console.WriteLine();
		}

		public static void AddStudents()
		{
			int amount = Convert.ToInt32(AnswerToQuestion("Insert students count:"));

			Students[] studentList = new Students[amount];

			for (int i = 0; i < studentList.Length; i++)
			{
				string name = AnswerToQuestion($"Insert #{i+1} students name:");
				string surename = AnswerToQuestion($"Insert  #{i + 1} students surename:");
				int course = Convert.ToInt32(AnswerToQuestion($"Which course is  #{i+1} student :"));

				studentList[i] = new Students(name, surename, course);

			}

			for (int i = 0; i < studentList.Length; i++)
			{
				Console.WriteLine($"{studentList[i].GetName()} {studentList[i].GetSurname()} {studentList[i].GetCourse()}");
			}
		}

		public static void AddStudentsMethod(Students[] studentList)
		{
			for (int i = 0; i < studentList.Length; i++)
			{
				string name = AnswerToQuestion($"Insert #{i + 1} students name:");
				string surename = AnswerToQuestion($"Insert  #{i + 1} students surename:");
				int course = Convert.ToInt32(AnswerToQuestion($"Which course is  #{i + 1} student :"));

				studentList[i] = new Students(name, surename, course);

			}

			for (int i = 0; i < studentList.Length; i++)
			{
				Console.WriteLine($"{studentList[i].GetName()} {studentList[i].GetSurname()} {studentList[i].GetCourse()}");
			}
		}

		//public static void ListStudents()
		//{

		//	for (int i = 0; i < a.Length; i++)
		//	{
		//		Console.WriteLine()
		//	}
		//}


		private static string AnswerToQuestion(string question)
		{
			Console.WriteLine(question);
			return Console.ReadLine();
		}
	}
}
