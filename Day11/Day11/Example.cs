using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
	class Example
	{
		public static void ex1()
		{
			List<int> a = new List<int>();
			a.Add(2);
			a.Add(5);

			for (int i = 0; i < a.Count; i++)
			{
				Console.WriteLine(a[i]);
			}

			foreach (int b in a)
			{
				Console.WriteLine(b);
			}
		}

		public static void Task1()
		{
			List<int> array = new List<int>();
			Console.WriteLine("how much numbers to sum?");
			int input = Convert.ToInt32(Console.ReadLine());

			int result = 0;
			for (int i = 0; i < input; i++)
			{
				Console.WriteLine($"write digit #{i + 1}");
				array.Add(Convert.ToInt32(Console.ReadLine()));

				result = result + array[i];
			}


			foreach (int a in array)
			{
				result += a;
			}

			Console.WriteLine($"Result is {result}");

		}
	}
}
