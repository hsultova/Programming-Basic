using System;

namespace ProgrammingBasicExam
{
	class BitwiseOperators
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				int numberToConvert = int.Parse(Console.ReadLine());
				string numbersBits = Convert.ToString(numberToConvert, 2);

				string reversedNumberBits = "";
				for (int j = numbersBits.Length - 1; j >= 0; j--)
				{
					reversedNumberBits += numbersBits[j];
				}

				int convertedNumber = (numberToConvert ^ ~numberToConvert) & Convert.ToInt32(new string(reversedNumberBits.ToCharArray()), 2);
				Console.WriteLine(convertedNumber);
			}
		}
	}
}