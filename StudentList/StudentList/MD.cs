using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
	class MD
	{
		static string filepath = "C:\\Users\\maksims.tabaks\\Documents\\GitHub\\test.txt";

		public static void ExecuteMD()
		{
			List<StudentList> List = new List<StudentList>();
			StartUp(List);

			int sel = 1;
			while (sel != 0)
			{
				FreeSpace();
				Console.WriteLine("Make selection from the options bellow?");
				Console.WriteLine("1. Show current student list");
				Console.WriteLine("2. Add Student to the list");
				Console.WriteLine("3. Remove student from the list");
				Console.WriteLine("4. Edit student from the list");
				Console.WriteLine("0. Quit");

				try
				{
					sel = Convert.ToInt32(Console.ReadLine());
					SelectAction(sel, List);
				}
				catch
				{
					Console.WriteLine("You should select a number of provided range");
				}
			}
		}

		public static void SelectAction(int input, List<StudentList> ls)
		{
			try
			{
				switch (input)
				{
					case 1:
						FreeSpace();
						ShowList(ls);
						break;
					case 2:
						FreeSpace();
						AddStudent(ls);
						break;
					case 3:
						FreeSpace();
						RemoveStudent(ls);
						break;
					case 4:
						FreeSpace();
						EditStudent(ls);
						break;
					case 0:
						break;
					default:
						FreeSpace();
						Console.WriteLine("Select option from the list.");
						break;
				}
			}
			catch
			{
				Console.WriteLine("Please input the digit of your selection.");
				FreeSpace();
			}
		}

		private static void ShowList(List<StudentList> ls)
		{
			foreach (StudentList el in ls)
			{
				el.Print();
			}
			if (ls.Count == 0)
			{
				Console.WriteLine("Currently list is empty.");
			}
		}

		private static void AddStudent(List<StudentList> ls)
		{
			string name = GetAnswer("Enter the name:");
			string surname = GetAnswer("Enter the surname:");
			int course = GetINTAnswer("Enter the course:");

			ls.Add(new StudentList(name, surname, course));
			RewriteFile(ls);
		}

		private static void RemoveStudent(List<StudentList> ls)
		{
			if (ListStudentsWithPos(ls) == true)
			{
				string sel = GetAnswer("Delete by name / surname / or index?");
				switch (sel)
				{
					case "index":
						RemoveByIndex(ls);
						break;
					case "name":
						RemoveByName(ls);
						break;
					case "surname":
						RemoveBySurname(ls);
						break;
					default:
						Console.WriteLine("Something went wrong. Please try again.");
						break;
				}
				RewriteFile(ls);
			}
		}

		private static void RemoveByName(List<StudentList> ls)
		{
			string sel = GetAnswer("Enter the name of stodent to delete:");
			int index = ls.FindIndex(x=> x.name.Contains(sel));

			ConfirmRemove(ls, index);
		}

		private static void RemoveBySurname(List<StudentList> ls)
		{
			string sel = GetAnswer("Enter the surname of student to delete:");
			int index = ls.FindIndex(x => x.surname.Contains(sel));

			ConfirmRemove(ls, index);
		}

		private static void ConfirmRemove(List<StudentList> ls, int index)
		{
			string sel = GetAnswer($"You're about to delete {ls[index].GetName()} {ls[index].GetSurname()}. Are you sure?");
			if (sel == "yes" || sel == "y")
			{
				ls.RemoveAt(index);
			}
		}

		private static void RemoveByIndex(List<StudentList> ls)
		{
			int sel = GetINTAnswer("Enter index of student you would like to remove?");
			ls.RemoveAt(sel - 1);
		}

		private static bool ListStudentsWithPos(List<StudentList> ls)
		{
			if (ls.Count == 0)
			{
				Console.WriteLine("List is empty, please add students and repeat the action.");
				return false;
			}
			else
			{
				for (int i = 0; i < ls.Count; i++)
				{
					Console.WriteLine($"{i + 1} {ls[i].Full()}");
				}
				return true;
			}
		}

		private static void EditStudent(List<StudentList> ls)
		{
			if (ListStudentsWithPos(ls) == true)
			{
				int sel = GetINTAnswer("Who you want to edit?");
				string val = GetAnswer("select name / surname / course");
				switch (val)
				{
					case "name":
						ls[sel-1].SetName(GetAnswer("Enter new name:"));
						break;
					case "surname":
						ls[sel-1].SetSurname(GetAnswer("Enter new surname:"));
						break;
					case "course":
						ls[sel-1].SetCourse(GetINTAnswer("Enter the new course:"));
						break;
					default:
						Console.WriteLine("select name / surname / course");
						break;
				}
				RewriteFile(ls);
			}
		}

		private static string GetAnswer(string question)
		{
			Console.WriteLine(question);
			string answer = Console.ReadLine();
			return answer;
		}

		private static int GetINTAnswer(string question)
		{
			Console.WriteLine(question);
			string answer;
			while (true)
			{
				try
				{
					answer = Console.ReadLine();
					Convert.ToInt32(answer);
					break;
				}
				catch
				{
					Console.WriteLine($"!Answer should be numerical!");
					Console.WriteLine(question);
				}
			}
			return Convert.ToInt32(answer);
		}

		private static void FreeSpace()
		{
			Console.WriteLine("_______________________________________");
			Console.WriteLine();
		}

		private static void StartUp(List<StudentList> ls)
		{
			try
			{
				string line;
				StreamReader sw = new StreamReader(filepath);

				line = sw.ReadLine();

				while (line != null)
				{
					string[] studenline = line.Split(' ');
					int course = Convert.ToInt32(studenline[2]);
					ls.Add(new StudentList(studenline[0], studenline[1], Convert.ToInt32(studenline[2])));
					line = sw.ReadLine();
				}
				sw.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error message:" + e);
			}
		}

		private static void RewriteFile (List<StudentList> ls)
		{
			try
			{
				StreamWriter sw = new StreamWriter(filepath);
				sw.Flush();
				foreach (StudentList el in ls)
				{
					sw.WriteLine(el.Full());
				}
				sw.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error meassage:" + e);
			}
		}
	}
}
