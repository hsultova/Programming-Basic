using System;

namespace CodingExam
{
	class DrawFort
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int col = n / 2;
			int mid = 2 * n - 2 * col - 4;
			
			if (n < 5)
			{
				mid = 0;
			}

			Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', col), new string('_', mid));
			for (int i = 0; i < n - 3; i++)
			{
				Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
			}
			Console.WriteLine("|{0}{1}{0}|", new string(' ', col + 1), new string('_', mid));
			Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', col), new string(' ', mid));
		}
	}
}