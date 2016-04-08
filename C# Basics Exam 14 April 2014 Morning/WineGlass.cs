using System;

namespace ProgrammingBasicExam
{
	class WineGlass
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char midSymbol = '*';
			char backgroundSymbol = '.';

			int background = 0;
			int mid = n;
			int rowStem = 0;

			if (n >= 12)
			{
				rowStem = n / 2 - 2;
			}
			else
			{
				rowStem = n / 2 - 1;
			}

			// Draw half of the glass
			for (int i = 0; i < n / 2; i++)
			{
				background = i;
				mid -= 2;
				Console.WriteLine("{0}\\{1}/{0}", new string(backgroundSymbol, background), new string(midSymbol, mid));
			}
			// Draw the other half of the glass
			for (int i = 0; i < rowStem; i++)
			{
				background = n / 2 - 1;

				Console.WriteLine("{0}||{0}", new string(backgroundSymbol, background));
			}

			for (int i = 0; i < n - n / 2 - rowStem; i++)
			{
				Console.WriteLine(new string('-', n));
			}
		}
	}
}

