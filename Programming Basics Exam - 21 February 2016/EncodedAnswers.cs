using System;

namespace ProgrammingExercises
{
	class  EncodedAnswers
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			
			int aCount = 0;
			int bCount = 0;
			int cCount = 0;
			int dCount = 0;
			string answers = "";

			for (int i = 0; i < n; i++)
			{
				uint question = uint.Parse(Console.ReadLine());

				if (question % 4 == 0)
				{
					aCount++;
					answers += "a";
				}
				else if (question % 4 == 1)
				{
					bCount++;
					answers += "b";
				}
				else if (question % 4 == 2)
				{
					cCount++;
					answers += "c";
				}
				else if (question % 4 == 3)
				{
					dCount++;
					answers += "d";
				}

				if (i != n - 1)
				{
					answers += " ";
				}
			}

			Console.WriteLine(answers);
			Console.WriteLine("Answer A: {0}", aCount);
			Console.WriteLine("Answer B: {0}", bCount);
			Console.WriteLine("Answer C: {0}", cCount);
			Console.WriteLine("Answer D: {0}", dCount);
		}
	}
}