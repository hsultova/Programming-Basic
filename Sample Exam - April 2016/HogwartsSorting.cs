using System;

namespace ProgrammingBasicExam
{
	class HogwartsSorting
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int gryffindorCounter = 0;
			int slytherinCounter = 0;
			int ravenclawCounter = 0;
			int hufflepuffCounter = 0;

			for (int i = 0; i < n; i++)
			{
				string[] name = Console.ReadLine().Split(' ');

				long sum = CalcTextCodes(name[0]) + CalcTextCodes(name[1]);
				if (sum % 4 == 0)
				{
					gryffindorCounter++;
					Console.WriteLine("Gryffindor {0}{1}{2}", sum, name[0][0], name[1][0]);
				}
				else if (sum % 4 == 1)
				{
					slytherinCounter++;
					Console.WriteLine("Slytherin {0}{1}{2}", sum, name[0][0], name[1][0]);
				}
				else if (sum % 4 == 2)
				{
					ravenclawCounter++;
					Console.WriteLine("Ravenclaw {0}{1}{2}", sum, name[0][0], name[1][0]);
				}
				else if (sum % 4 == 3)
				{
					hufflepuffCounter++;
					Console.WriteLine("Hufflepuff {0}{1}{2}", sum, name[0][0], name[1][0]);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Gryffindor: {0}", gryffindorCounter);
			Console.WriteLine("Slytherin: {0}", slytherinCounter);
			Console.WriteLine("Ravenclaw: {0}", ravenclawCounter);
			Console.WriteLine("Hufflepuff: {0}", hufflepuffCounter);
		}

		static long CalcTextCodes(string text)
		{
			long sum = 0;
			for (int i = 0; i < text.Length; i++)
			{
				int code = Convert.ToInt32(text[i]);
				sum += code;
			}
			return sum;
		}
	}
}