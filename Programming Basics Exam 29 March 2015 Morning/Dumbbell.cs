using System;

namespace ProgrammingBasicExam
{
	class Dumbbell
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char backgroundSymbol = '.';
			char dumbbellSymbol = '&';
			char midDumbbellSymbol = '*';

			int leftRightBackground = (n - 1) / 2;
			int background = n;
			int dumbbell = (n + 1) / 2;
			int midDumbbell = (n - 1) / 2 - 1;

			Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, leftRightBackground), new string(dumbbellSymbol, dumbbell),
				new string(backgroundSymbol, background));
			for (int i = 1; i < (n + 1) / 2; i++)
			{
				leftRightBackground -= 1;
				midDumbbell += 1;

				if (i == (n + 1) / 2 - 1)
				{
					Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(backgroundSymbol, leftRightBackground), dumbbellSymbol,
						new string(midDumbbellSymbol, midDumbbell), new string('=', background));
				}
				else
				{
					Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(backgroundSymbol, leftRightBackground), dumbbellSymbol,
						new string(midDumbbellSymbol, midDumbbell), new string(backgroundSymbol, background));

				}
			}

			for (int i = 1; i < n / 2; i++)
			{
				leftRightBackground += 1;
				midDumbbell -= 1;

				Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(backgroundSymbol, leftRightBackground), dumbbellSymbol,
					new string(midDumbbellSymbol, midDumbbell), new string(backgroundSymbol, background));
			}

			leftRightBackground += 1;
			Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, leftRightBackground), new string(dumbbellSymbol, dumbbell),
				new string(backgroundSymbol, background));

		}
	}
}
