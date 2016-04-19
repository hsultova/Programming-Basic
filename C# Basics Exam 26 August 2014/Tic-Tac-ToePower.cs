using System;

namespace ProgrammingBasicExam
{
	class TicTacToePower
	{
		static void Main(string[] args)
		{
			int y = int.Parse(Console.ReadLine());
			int x = int.Parse(Console.ReadLine());
			int value = int.Parse(Console.ReadLine());

			int[,] board = new int[3, 3];
			int[,] indexes = new int[3, 3];
			int i = 0;

			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					board[row, col] = value + i;
					indexes[row, col] = 1 + i;
					i++;
				}
			}

			ulong result = (ulong)Math.Pow(board[x, y], indexes[x, y]);
			Console.WriteLine(result);
		}
	}
}
