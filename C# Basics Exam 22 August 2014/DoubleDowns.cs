using System;
using System.Collections.Generic;

namespace ProgrammingBasicExam
{
	class DoubleDowns
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];

			int countRightDiagonal = 0;
			int countLeftDiagonal = 0;
			int countVertical = 0;

			int numberRolledLeftBits = 0;
			int numberRolledRightBits = 0;

			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < n - 1; i++)
			{
				countVertical += CountVerticals(numbers[i], numbers[i + 1]);

				numberRolledLeftBits = numbers[i] << 1;
				numberRolledRightBits = numbers[i] >> 1;

				countLeftDiagonal += CountVerticals(numberRolledLeftBits, numbers[i + 1]);
				countRightDiagonal += CountVerticals(numberRolledRightBits, numbers[i + 1]);
			}

			Console.WriteLine(countRightDiagonal);
			Console.WriteLine(countLeftDiagonal);
			Console.WriteLine(countVertical);
		}

		static int CountVerticals(int number1, int number2)
		{
			int count = 0;
			for (int j = 0; j < 32; j++)
			{
				if ((((number1 & number2) >> j) & 1) == 1)
				{
					count++;
				}
			}

			return count;
		}
	}
}