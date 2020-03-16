using System;
using System.Collections.Generic;
using System.Text;

namespace day15
{
	class ListOfInt
	{
		private string digit;

		public ListOfInt(string digit)
		{
			this.digit = digit;
		}

		public void SetDigit(string input)
		{
			digit = input;
		}

		public string GetDigit()
		{
			return digit;
		}
	}
}
