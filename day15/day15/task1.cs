using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace day15
{
	class Task1
	{

		public static void Execution()
		{

		}



		public static void Task()
		{
			try
			{
				StreamWriter sw = new StreamWriter("C:\\Users\\maksims.tabaks\\Documents\\GitHub\\CodeTesto.txt");


				List<int> ElementValues = new List<int>();

				foreach (int element in ElementValues)
				{
					Console.WriteLine(element);
				}

				int input = Convert.ToInt32(Console.ReadLine());
				ElementValues.Add(input);
				sw.WriteLine(ElementValues[ElementValues.Count - 1]);


				sw.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception:" + e);
			}

		}

		//private static void AddingInput(List<int> ElVal)
		//{
		//	int input = Convert.ToInt32(Console.ReadLine());
		//	ElVal.Add(input);
		//	ListOfInt.WriteLine(ElVal)



		//}
	}

}
}
