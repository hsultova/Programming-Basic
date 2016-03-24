using System;

namespace ProgrammingBasicExam
{
	class Sunlight
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("{0}*{0}", new string('.', (3 * n - 1) / 2));
			//Print up diagonal sunbeams
			for (int i = 0; i < n - 1; i++)
			{
				Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i + 1), new string('.', (3 * n - 5) / 2 - i));
			}

			//Print up horizontal sunbeams
			for (int i = 0; i < n / 2; i++)
			{
				Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
			}
			Console.WriteLine(new string('*', 3 * n));

			//Print down horizontal sunbeams
			for (int i = 0; i < n / 2; i++)
			{
				Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
			}
			//Print down diagonal sunbeams
			for (int i = 0; i < n - 1; i++)
			{
				Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n - i - 1), new string('.', n / 2 + i));
			}
			Console.WriteLine("{0}*{0}", new string('.', (3 * n - 1) / 2));
		}
	}
}
