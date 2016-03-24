using System;
using System.Numerics;

namespace ProgrammingBasicExam
{
	class PeterGame
	{
		static void Main(string[] args)
		{
			ulong startNumber = ulong.Parse(Console.ReadLine());
			ulong endNumber = ulong.Parse(Console.ReadLine());
			string replacementString = Console.ReadLine();

			BigInteger sum = 0;

			for (ulong i = startNumber; i < endNumber; i++)
			{
				if (i % 5 == 0)
				{
					sum += i;
				}
				else
				{
					sum += (i % 5);
				}
			}

			string sumString = sum.ToString();
			string digitToReplace;

			if (sum % 2 == 0)
			{
				digitToReplace = sumString[0].ToString();
			}
			else
			{
				digitToReplace = sumString[sumString.Length - 1].ToString();
			}
			sumString = sumString.Replace(digitToReplace, replacementString);

			Console.WriteLine(sumString);
		}
	}
}