using System;

namespace ProgrammingBasicExam
{
	class BitLock
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string line = Console.ReadLine();

			int rows = input.Split(' ').Length;
			int[] numbers = new int[rows];
			int countOneBits = 0;

			for (int i = 0; i < rows; i++)
			{
				numbers[i] = int.Parse(input.Split(' ')[i]);
			}

			while (line != "end")
			{
				if (line.Contains("check"))
				{
					int col = int.Parse(line.Split(' ')[1]);
					for (int i = 0; i < numbers.Length; i++)
					{
						if (((numbers[i] >> col) & 1) == 1)
						{
							countOneBits++;
						}
					}
					Console.WriteLine(countOneBits);
					countOneBits = 0;
				}
				else
				{
					int row = int.Parse(line.Split(' ')[0]);
					string direction = line.Split(' ')[1];
					int rotations = int.Parse(line.Split(' ')[2]);

					if (direction == "right")
					{
						for (int i = 0; i < rotations; i++)
						{
							int firstBit = numbers[row] & 1;
							numbers[row] >>= 1;
							numbers[row] |= firstBit << 11;
						}
					}
					else if (direction == "left")
					{
						for (int i = 0; i < rotations; i++)
						{
							int lastBit = (numbers[row] >> 11) & 1;
							numbers[row] &= ~(1 << 11);
							numbers[row] <<= 1;
							numbers[row] |= lastBit >> 0;
						}
					}

				}
				line = Console.ReadLine();
			}

			foreach (int number in numbers)
			{
				Console.Write(number + " ");
			}
		}
	}
}
