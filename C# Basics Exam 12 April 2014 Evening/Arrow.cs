using System;

namespace ProgrammingBasicExam
{
	class Arrow
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char arrowSymbol = '#';
			char backgroundSymbol = '.';

			int arrow = n;
			int background = (n - 1) / 2;
			int mid = n - 2;

			Console.WriteLine("{0}{1}{0}", new string(backgroundSymbol, background), new string(arrowSymbol, arrow));
			for (int i = 0; i < n - 2; i++)
			{
				Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, background), arrowSymbol, new string(backgroundSymbol, mid));
			}

			arrow = (n + 1) / 2;

			Console.WriteLine("{0}{1}{0}", new string(arrowSymbol, arrow), new string(backgroundSymbol, mid));
			
			mid = 2 * n - 5;
			
			for (int i = 0; i < n - 2; i++)
			{
				background = 1 + i;
				if (i != 0)
				{
					mid -= 2;
				}
				Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, background), arrowSymbol, new string(backgroundSymbol, mid));
			}
			
			background += 1;
			
			Console.WriteLine("{0}{1}{0}", new string(backgroundSymbol, background), arrowSymbol);
		}
	}
}

