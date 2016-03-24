using System;

namespace ProgrammingBasic
{
	class ShuffleBits
	{
		static void Main(string[] args)
		{
			var number1 = uint.Parse(Console.ReadLine());
			var number2 = uint.Parse(Console.ReadLine());

			string number1Bits = Convert.ToString(number1, 2).PadLeft(32, '0');
			string number2Bits = Convert.ToString(number2, 2).PadLeft(32, '0');
			char[] result = new char[64];

			int j = 0;
			int k = 0;
			if (number1 >= number2)
			{
				for (int i = 1; i <= 64; i++)
				{
					if (i % 2 != 0)
					{
						result[i - 1] = number1Bits[j];
						j++;
					}
					else
					{
						result[i - 1] = number2Bits[k];
						k++;
					}
				}
			}
			else
			{
				for (int i = 0; i < 64; i += 4)
				{
					result[i] = number1Bits[j];
					result[i+1] = number1Bits[j + 1];
					j+=2;
				}
				for (int i = 2; i < 64; i += 4)
				{
					result[i] = number2Bits[k];
					result[i + 1] = number2Bits[k + 1];
					k+=2;
				}
			}

			Console.WriteLine(Convert.ToUInt64(new string(result), 2));
		}
	}
}