using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class Summertime
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			if (n % 2 != 0 && n > 0)
			{
				Console.WriteLine("{0}{1}{0}", new string(' ', n / 2), new string('*', n + 1));

				for (int i = 0; i < (n + 1) / 2; i++)
				{
					Console.WriteLine("{0}*{1}*{0}", new string(' ', n / 2), new string(' ', n - 1));
				}

				for (int i = 0; i < (n -2) / 2; i++)
				{
					Console.WriteLine("{0}*{1}*{2}", new string(' ', (n / 2) - i-1), new string(' ', n-1 +2*(i+1)), new string(' ', (n / 2) + i-1));
				}

				for (int i = 0; i < n; i++)
				{
					Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
				}
				
				for (int i = 0; i < n; i++)
				{
					Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
				}

				Console.WriteLine(new string('*', 2 * n));
			}
		}
	}
}