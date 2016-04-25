using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingBasicExam
{
	class BlurFilter
	{
		static void Main(string[] args)
		{
			int blurAmount = int.Parse(Console.ReadLine());
			string[] line = Console.ReadLine().Split(' ');
			int rows = int.Parse(line[0]);
			int columns = int.Parse(line[1]);
			long[,] matrix = new long[rows, columns];

			for (int row = 0; row < rows; row++)
			{
				line = Console.ReadLine().Split(' ');
				for (int col = 0; col < columns; col++)
				{
					matrix[row, col] = int.Parse(line[col]);
				}
			}

			line = Console.ReadLine().Split(' ');
			int rowToBlur = int.Parse(line[0]);
			int colToBlur = int.Parse(line[1]);

			int startRow = Math.Max(0, rowToBlur - 1);
			int endRow = Math.Min(rows, rowToBlur + 1);
			int startCol = Math.Max(0, colToBlur - 1);
			int endCol = Math.Min(columns, colToBlur + 1);

			for (int row = startRow; row <= endRow; row++)
			{
				for (int col = startCol; col <= endCol; col++)
				{
					matrix[row, col] += blurAmount;
				}
			}

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < columns; col++)
				{
					Console.Write(matrix[row, col] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}