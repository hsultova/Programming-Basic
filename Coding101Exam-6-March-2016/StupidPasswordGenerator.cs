using System;

namespace CodingExam
{
	class StupidPasswordGenerator
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var l = int.Parse(Console.ReadLine());

			for (int i = 1; i < n; i++) //Digit 1 to n
			{
				for (int k = 1; k < n; k++) //Digit 1 to n
				{
					for (int m = 1; m <= l; m++) // Letter 1 to l
					{
						for (int j = 1; j <= l; j++) // Letter 1 to l
						{
							for (int p = 1; p <= n; p++) // Digit 1 to n bigger then first 2 digits
							{
								if (p > i && p > k)
								{
									Console.Write(i.ToString() + k.ToString() + Convert.ToChar(m + 96) + Convert.ToChar(j + 96) + p);
									Console.Write(" ");
								}
							}
						}
					}
				}
			}
		}
	}
}