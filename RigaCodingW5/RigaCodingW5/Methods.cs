using System;
using System.Collections.Generic;
using System.Text;

namespace RigaCodingW5
{
	class Methods
	{
		public static void AddStudent(Students[] studentArray, int selection)
		{
			while (studentArray[selection] != null)
			{
				Console.WriteLine("You've selected a slot which was not empty, please select empty slot:");
				selection = SelectFreeStudentSlot(studentArray);
			}

			string name = AnswerToQuestion($"Insert #{selection+1} students name:");
			string surename = AnswerToQuestion($"Insert  #{selection+1} students surname:");
			int course = NumericAnswerToQuestion($"Which course is  #{selection+1} student :");

			studentArray[selection] = new Students(name, surename, course);
		}

		public static void ListStudent(Students[] studentArray)
		{
			for (int i = 0; i < studentArray.Length; i++)
			{
				if (studentArray[i] == null)
				{
					Console.WriteLine($"#{i+1} empty");
				}
				else
				{
					//Console.WriteLine($"#{i+1} {studentList[i].GetName()} {studentList[i].GetSurname()} {studentList[i].GetCourse()}");
					Console.WriteLine($"#{i + 1} {studentArray[i].Print()}");
				}
			}
		}

		public static void EditStudent(Students[] studentArray, int selection)
		{
			while (studentArray[selection] == null)
			{
				Console.WriteLine("You've selected a slot which is empty, please select existing student slot:");
				selection = SelectStudentSlot(studentArray);
			}
			int edit = Convert.ToInt32(AnswerToQuestion("1 = name 2 = surname 3 = course"));

			if (edit == 1)
			{
				studentArray[selection].SetName(AnswerToQuestion("New Name"));
			}

			else if (edit == 2)
			{
				studentArray[selection].SetSurname(AnswerToQuestion("New Surname"));
			}

			else if (edit == 3)
			{
				studentArray[selection].SetCourse(NumericAnswerToQuestion("New course"));
			}
		}

		public static int SelectFreeStudentSlot(Students[] studentArray)
		{
			Console.WriteLine("Following slots are empty");
			for (int i = 0; i < studentArray.Length; i++)
			{
				if (studentArray[i] == null)
				{
					Console.WriteLine($"#{i + 1} empty");
				}
			}
			return NumericAnswerToQuestion("Which slot do you want to add the student to?")-1;
		}

		public static int SelectStudentSlot(Students[] studentArray)
		{
			Console.WriteLine("Following slots are editable:");
			for (int i = 0; i < studentArray.Length; i++)
			{
				if (studentArray[i] != null)
				{
					Console.WriteLine($"#{i + 1} {studentArray[i].Print()}");
				}
			}
			return NumericAnswerToQuestion("Which student to edit?") - 1;
		}

		private static string AnswerToQuestion(string question)
		{
			Console.WriteLine(question);
			return Console.ReadLine();
		}

		private static int NumericAnswerToQuestion(string question)
		{
			//add validation of input
			Console.WriteLine(question);
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}
