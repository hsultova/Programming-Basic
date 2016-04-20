using System;

namespace ProgrammingBasicExam
{
	class XBits
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[8];
			int countX = 0;

			for (int i = 0; i < 8; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < numbers.Length - 2; i++)
			{
				for (int j = 0; j < 32; j++)
				{
					bool top = ((numbers[i] >> j) & 7) == 5;
					bool mid = ((numbers[i + 1] >> j) & 7) == 2;
					bool bottom = ((numbers[i + 2] >> j) & 7) == 5;

					if (top && mid && bottom)
					{
						countX++;
					}
				}
			}

			Console.WriteLine(countX);
		}
	}
}