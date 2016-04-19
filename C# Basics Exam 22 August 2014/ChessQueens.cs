using System;
using System.Collections.Generic;

namespace ProgrammingBasicExam
{
	class ChessQueens
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int distance = int.Parse(Console.ReadLine());

			string[] board = new string[n];
			char letter = 'a';
			var result = new List<string>();

			for (int i = 0; i < n; i++)
			{
				board[i] = new string(letter, n);
				letter++;
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + distance + 1 < n))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i + distance + 1][j] + (j + 1));
					}
					if ((j + distance + 1 < n))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i][j + distance + 1] + (j + distance + 2));
					}
					if ((i + distance + 1 < n) && (j + distance + 1 < n))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i + distance + 1][j + distance + 1] + (j + distance + 2));
					}
					if ((i - distance - 1 >= 0))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i - distance - 1][j] + (j + 1));
					}
					if ((j - distance - 1 >= 0))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i][j - distance - 1] + (j - distance));
					}
					if ((i - distance - 1 >= 0) && (j - distance - 1 >= 0))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i - distance - 1][j - distance - 1] + (j - distance));
					}
					if ((i + distance + 1 < n) && (j - distance - 1 >= 0))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i + distance + 1][j - distance - 1] + (j - distance));
					}
					if ((i - distance - 1 >= 0) && (j + distance + 1 < n))
					{
						result.Add(board[i][j] + (j + 1).ToString() + " - " + board[i - distance - 1][j + distance + 1] + (j + distance + 2));
					}
				}
			}

			result.Sort();
			if (result.Count == 0)
			{
				Console.WriteLine("No valid positions");
			}
			else
			{
				foreach (string line in result)
				{
					Console.WriteLine(line);
				}
			}
		}
	}
}