using System;

namespace ProgrammingBasicExam
{
	class Boat
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int right = n;
			int mid;
			int left;

			//Top of the sail
			for (int i = 0; i < (n + 1) / 2; i++)
			{
				mid = 1 + 2 * i;
				left = 2 * n - right - mid;

				Console.WriteLine("{0}{1}{2}", new string('.', left), new string('*', mid), new string('.', right));
			}
			for (int i = 1; i < (n + 1) / 2; i++)
			{
				mid = n - 2 * i;
				left = 2 * n - right - mid;

				Console.WriteLine("{0}{1}{2}", new string('.', left), new string('*', mid), new string('.', right));
			}
			//The body of boat
			for (int i = 0; i < n / 2; i++)
			{
				mid = 2 * n - 2 * i;
				right = (2 * n - mid) / 2;
				left = (2 * n - mid) / 2;

				Console.WriteLine("{0}{1}{2}", new string('.', left), new string('*', mid), new string('.', right));
			}
		}
	}
}

