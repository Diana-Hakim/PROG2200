using System;
using System.Collections.Generic;

namespace RemoveElementFromAlist
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new List<int>() { 10, 20, 30, 40, 10,20,20 };

			numbers.Remove(20); // removes the first "20" element from a list
			

			numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

			

			foreach (var num in numbers)
				Console.WriteLine(num);
		}
	}
}

