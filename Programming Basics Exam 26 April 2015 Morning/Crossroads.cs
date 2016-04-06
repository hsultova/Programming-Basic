using System;

namespace ProgrammingBasicExam
{
	class Crossroads
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string line = Console.ReadLine();
			int[] board = new int[n];
			int countCrossroads = 0;

			while (line != "end")
			{
				int lineNumber = int.Parse(line.Split(' ')[0]);
				int bitPosition = int.Parse(line.Split(' ')[1]);


				board[lineNumber] ^= (1 << bitPosition);
				countCrossroads += FillDiagonals(board, lineNumber, bitPosition, -1, 1);
				countCrossroads += FillDiagonals(board, lineNumber, bitPosition, -1, -1);
				countCrossroads += FillDiagonals(board, lineNumber, bitPosition, 1, 1);
				countCrossroads += FillDiagonals(board, lineNumber, bitPosition, 1, -1);

				countCrossroads++;
				line = Console.ReadLine();

			}

			foreach (int number in board)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine(countCrossroads);
		}

		static int FillDiagonals(int[] board, int lineNumber, int bitPosition, int stepNumber, int stepBit)
		{
			int countCrossroads = 0;
			for (int i = 0; i <= board.Length; i++)
			{
				int nextLineNumber = -1;
				int nextBitposition = -1;

				nextLineNumber = lineNumber + stepNumber;
				nextBitposition = bitPosition + stepBit;
				if ((nextLineNumber >= 0 && nextLineNumber < board.Length) && (nextBitposition >= 0 && nextBitposition < board.Length))
				{
					lineNumber = nextLineNumber;
					bitPosition = nextBitposition;

					if (((board[lineNumber] >> bitPosition) & 1) == 1)
					{
						countCrossroads++;
						//Console.WriteLine(lineNumber + "," + bitPosition);
					}
					else
					{
						board[lineNumber] ^= (1 << bitPosition);
					}
				}
			}
			return countCrossroads;
		}
	}
}

