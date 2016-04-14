using System;

namespace ProgrammingBasicExam
{
	class SpyHard
	{
		static void Main(string[] args)
		{
			int keyNumber = int.Parse(Console.ReadLine());
			string message = Console.ReadLine();

			int result = 0;

			for (int i = 0; i < message.Length; i++)
			{
				int codeLetter = message.ToLower()[i];
				if (codeLetter >= 97 && codeLetter <= 122)
				{
					codeLetter -= 96;
				}
				result += codeLetter;
			}

			string resultToNumeralSystem = DecimalToArbitrarySystem(result, keyNumber);//Convert.ToString(result, keyNumber);
			Console.WriteLine("{0}{1}{2}", keyNumber, message.Length, resultToNumeralSystem);
		}

		public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
		{
			const int BitsInLong = 64;
			const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			if (decimalNumber == 0)
			{
				return "0";
			}

			int index = BitsInLong - 1;
			long currentNumber = Math.Abs(decimalNumber);
			char[] charArray = new char[BitsInLong];

			while (currentNumber != 0)
			{
				int remainder = (int)(currentNumber % radix);
				charArray[index--] = Digits[remainder];
				currentNumber = currentNumber / radix;
			}

			string result = new String(charArray, index + 1, BitsInLong - index - 1);
			if (decimalNumber < 0)
			{
				result = "-" + result;
			}

			return result;
		}
	}
}

