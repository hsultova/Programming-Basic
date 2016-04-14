using System;

namespace ProgrammingBasicExam
{
	class Headphones
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int leftRight = n / 2;
			int mid = 2 * n + 1 - leftRight * 2;
			int headphones = 1;

			Console.WriteLine("{0}{1}{0}", new string('-', leftRight), new string('*', mid));

			mid = n;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("{0}*{1}*{0}", new string('-', leftRight), new string('-', mid));
			}
			for (int i = 0; i < n / 2; i++)
			{
				leftRight -= 1;
				headphones += 2;
				mid -= 2;
				Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', leftRight), new string('*', headphones), new string('-', mid));

			}
			for (int i = 0; i < (n + 1) / 2 - 1; i++)
			{
				leftRight += 1;
				headphones -= 2;
				mid += 2;
				Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', leftRight), new string('*', headphones), new string('-', mid));
			}
		}
	}
}