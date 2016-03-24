using System;

namespace ProgrammingExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			char background = char.Parse(Console.ReadLine());
			char rhombus = char.Parse(Console.ReadLine());

			int leftRight = n;
			int midUp = 2 * n - 1;
			int midDown = 2 * n - 1;

			Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, leftRight), rhombus, new string(background, midUp));

			for (int k = 0; k < 2; k++)
			{
				int j = n - 1;
				for (int i = 1; i < n; i++)
				{
					leftRight = n - i;
					midUp = 2 * n - 1 - 2 * i;
					midDown = 2 * n - 1 - 2 * j;

					Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
						new string(background, leftRight), rhombus, new string(background, midDown), new string(background, midUp));
					j--;
				}

				midDown = 2 * n - 1;
				Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, new string(background, midDown));

				j = 1;
				for (int i = n - 1; i > 0; i--)
				{
					leftRight = n - i;
					midUp = 2 * n - 1 - 2 * i;
					midDown = 2 * n - 1 - 2 * j;

					Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
						new string(background, leftRight), rhombus, new string(background, midDown), new string(background, midUp));
					j++;
				}

				leftRight = n;
				midUp = 2 * n - 1;

				Console.WriteLine("{0}{1}{2}{1}{0}", new string(background, leftRight), rhombus, new string(background, midUp));
			}
		}
	}
}