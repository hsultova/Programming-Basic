using System;

namespace ProgrammingBasicExam
{
	class House
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int leftRight = n - 1;
			int mid = 1;

			//roof
			Console.WriteLine("{0}*{0}", new string('.', leftRight));

			for (int i = 0; i < n - 1; i++)
			{
				leftRight--;
				Console.WriteLine("{0}*{1}*{0}", new string('.', leftRight), new string('.', mid));
				mid += 2;
			}

			Console.WriteLine(new string('*', 2 * n - 1));

			//wall
			for (int i = 0; i < n / 4; i++)
			{
				Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
			}

			//window
			for (int i = 0; i < n / 2; i++)
			{
				leftRight = n / 2;
				mid = n - 3;
				Console.WriteLine("*{0}{1}{0}*", new string('.', leftRight), new string('*', mid));
			}

			for (int i = 0; i < n / 4; i++)
			{
				Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
			}

			Console.WriteLine(new string('*', 2 * n - 1));
		}
	}
}