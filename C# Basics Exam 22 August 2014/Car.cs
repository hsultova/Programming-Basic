using System;

namespace ProgrammingBasicExam
{
	class Car
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

			for (int i = 0; i < n / 2 - 1; i++)
			{
				Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', n + 2 * i));
			}

			Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', 3 * n - 2 * (n / 2 + 1)));

			for (int i = 0; i < n / 2 - 2; i++)
			{
				Console.WriteLine("*{0}*", new string('.', 3 * n - 2));
			}

			Console.WriteLine(new string('*', 3 * n));

			for (int i = 0; i < n / 2 - 2; i++)
			{
				Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', (n + 1) / 2), new string('.', (n - 2) / 2), new string('.', n - 2));
			}

			Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', (n + 1) / 2), new string('*', (n - 2) / 2), new string('.', n - 2));
		}
	}
}