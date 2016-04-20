using System;

namespace ProgrammingBasicExam
{
	class OddEvenJumps
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().ToLower().Split(' ');
			int oddJump = int.Parse(Console.ReadLine());
			int evenJump = int.Parse(Console.ReadLine());

			string text = "";
			string oddLetters = "";
			string evenLetters = "";
			long oddResult = 0;
			long evenResult = 0;

			for (int i = 0; i < input.Length; i++)
			{
				text += input[i];
			}

			for (int i = 1; i <= text.Length; i++)
			{
				if (i % 2 == 0)
				{
					evenLetters += text[i - 1];
				}
				else
				{
					oddLetters += text[i - 1];
				}
			}

			oddResult = CalcResult(oddLetters, oddJump);
			evenResult = CalcResult(evenLetters, evenJump);

			Console.WriteLine("Odd: {0}", Convert.ToString(oddResult, 16).ToUpper());
			Console.WriteLine("Even: {0}", Convert.ToString(evenResult, 16).ToUpper());
		}

		static long CalcResult(string letters, int jump)
		{
			long result = 0;

			for (int i = 0; i < letters.Length; i++)
			{
				int letterCode = Convert.ToInt32(letters[i]);
				if ((i + 1) % jump == 0)
				{
					result *= letterCode;
				}
				else
				{
					result += letterCode;
				}
			}
			return result;
		}
	}
}