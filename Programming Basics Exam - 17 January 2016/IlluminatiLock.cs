using System;

namespace ProgrammingBasic
{
	class IlluminatiLock
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[,] output = new string[n + 1, 3 * n];

			if (n % 2 != 0)
			{
				for (int i = 0; i < n + 1; i++)
				{
					for (int j = 0; j < 3 * n; j++)
					{
						output[i, j] = ".";

						for (int k = n; k < 2 * n; k++)
						{
							if (k == n || k == 2 * n - 1)
							{
								output[i, k] = "#";
							}
							if (i == 0 || i == n)
							{
								output[i, k] = "#";
							}
						}

						for (var l = 1; l <= 2; l++)
						{
							if (i < (n + 1) / 2 && i > 0)
							{
								output[i, n - l - 2 * i + 2] = "#";
								output[i, 2 * n + l + 2 * i - 3] = "#";
							}
							else if (i >= (n + 1) / 2 && i < n + 1)
							{
								output[i, -n + l + 2 * i -1] = "#";
								output[i, 4 * n - l - 2 * i] = "#";
							}
						}
						Console.Write(output[i, j]);
					}
					Console.WriteLine();
				}
			}
		}
	}
}