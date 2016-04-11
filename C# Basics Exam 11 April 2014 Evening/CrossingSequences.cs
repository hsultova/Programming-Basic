using System;
using System.Collections.Generic;

namespace ProgrammingBasicExam
{
	class CrossingSequences
	{
		static void Main(string[] args)
		{
			// First three Tribonacci numbers
			int t1 = int.Parse(Console.ReadLine());
			int t2 = int.Parse(Console.ReadLine());
			int t3 = int.Parse(Console.ReadLine());

			int spiralNumber = int.Parse(Console.ReadLine());
			int step = int.Parse(Console.ReadLine());

			var tribonacciNumbers = new List<int>();
			var spiralNumbers = new List<int>();

			tribonacciNumbers.Add(t1);
			tribonacciNumbers.Add(t2);
			tribonacciNumbers.Add(t3);
			
			int number = 0;
			int findNumber = 0;

			spiralNumbers.Add(spiralNumber);
			for (int i = 1; i < 30; i++)
			{
				tribonacciNumbers.Add(tribonacciNumbers[i - 1] + tribonacciNumbers[i] + tribonacciNumbers[i + 1]);
			}
			for (int i = 1; i < 1000; i++)
			{
				if (i % 2 != 0)
				{
					spiralNumbers.Add(spiralNumbers[i - 1] + step * i);
				}

				spiralNumbers.Add(spiralNumbers[i] + step * i);
			}

			for (int i = 1; i < tribonacciNumbers.Count; i++)
			{
				number = tribonacciNumbers[i];
				if (spiralNumbers.Contains(number))
				{
					findNumber = number;
					break;
				}
			}
			Console.WriteLine(findNumber);
		}
	}
}

