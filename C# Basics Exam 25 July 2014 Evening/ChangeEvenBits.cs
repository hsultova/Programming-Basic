using System;

namespace ProgrammingBasicExam
{
	class ChangeEvenBits
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			int changesCounter = 0;

			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			ulong numberToChange = ulong.Parse(Console.ReadLine());

			for (int i = 0; i < numbers.Length; i++)
			{
				string numberBits = Convert.ToString(numbers[i], 2);
				int evenPositions = numberBits.Length;

				for (int j = 0; j < 64; j++)
				{
					if ((((numberToChange >> j) & 1) == 0) && (j % 2 == 0) && (j < evenPositions * 2))
					{
						numberToChange ^= (ulong)1 << j;
						changesCounter += 1;
					}
				}
			}

			Console.WriteLine(numberToChange);
			Console.WriteLine(changesCounter);
		}
	}
}