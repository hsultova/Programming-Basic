using System;

namespace ProgrammingBasicExam
{
	class TextBombardment
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int lineWidth = int.Parse(Console.ReadLine());
			string columnsToBombarded = Console.ReadLine();
			string[] columns = columnsToBombarded.Split(' ');

			int rows = (int)Math.Ceiling((double)text.Length / lineWidth);
			char[,] matrix = new char[rows, lineWidth];
			bool hasDestroyedLetter = false;

			matrix = FillMatrix(rows, lineWidth, text, matrix);

			//Bombard letters
			for (int i = 0; i < columns.Length; i++)
			{
				int column = int.Parse(columns[i]);
				hasDestroyedLetter = false;
				
				for (int j = 0; j < rows; j++)
				{
					if (matrix[j, column] == ' ' && hasDestroyedLetter)
					{
						j = rows - 1;
					}
					else
					{
						matrix[j, column] = ' ';
						hasDestroyedLetter = true;
					}
				}
			}
			PrintMatrix(matrix);
		}

		static char[,] FillMatrix(int width, int length, string textToFill, char[,] matrix)
		{
			int textIndex = 0;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (textIndex < textToFill.Length)
					{
						matrix[i, j] = textToFill[textIndex];
						textIndex++;
					}
					else
					{
						matrix[i, j] = ' ';
					}
				}
			}

			return matrix;
		}

		static void PrintMatrix(char[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j]);
				}
			}
		}
	}
}

