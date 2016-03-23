using System;

namespace ProgrammingExercises
{
	class FallenInLove
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int tilda = 0;
			int leftRightDot = 0;
			int midDot = 0;

			for (int i = 0; i < n; i++)
			{
				tilda = i;
				leftRightDot = 2 * n - 2 * i;
				midDot = 2 * i;

				Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', tilda), new string('.', leftRightDot), new string('.', midDot));
			}

			for (int i = n; i > 0; i--)
			{
				tilda = i;
				leftRightDot = n - i + 1 + (n - i);
				midDot = 2 * i;

				Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', leftRightDot), new string('~', tilda), new string('.', midDot));
			}

			leftRightDot = 2 * n + 1;
			Console.WriteLine("{0}####{0}", new string('.', leftRightDot));

			for (int i = 0; i < n; i++)
			{
				leftRightDot = 2 * n + 2;
				Console.WriteLine("{0}##{0}", new string('.', leftRightDot));
			}
		}
	}
}