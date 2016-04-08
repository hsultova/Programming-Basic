using System;

namespace ProgrammingBasicExam
{
	class BitRoller
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int f = int.Parse(Console.ReadLine());
			int r = int.Parse(Console.ReadLine());

			string nBits = Convert.ToString(n, 2).PadLeft(19, '0');
			string rolledBits = RollBitNumber(nBits, f);
			
			for (int i = 0; i < r - 1; i++)
			{
				rolledBits = RollBitNumber(rolledBits, f);
			}

			Console.WriteLine(Convert.ToInt32(rolledBits, 2));
		}

		static string RollBitNumber(string bitNumber, int f)
		{
			string rolledBits = "";
			int[] nBitsRolled = new int[bitNumber.Length];
			int nextIndex = 0;
			
			for (int i = 0; i < bitNumber.Length; i++)
			{
				nextIndex = i + 1;
				if (nextIndex > bitNumber.Length - 1)
				{
					nextIndex = 0;
				}

				if (nextIndex == bitNumber.Length - 1 - f && f != bitNumber.Length - 1)
				{
					nBitsRolled[nextIndex] = int.Parse(bitNumber[i + 1].ToString());
				}
				else if (nextIndex == bitNumber.Length - f && f != bitNumber.Length - 1)
				{
					nBitsRolled[nextIndex] = int.Parse(bitNumber[i - 1].ToString());
				}
				else if (nextIndex == bitNumber.Length - f)
				{
					nBitsRolled[nextIndex] = int.Parse(bitNumber[bitNumber.Length - 1].ToString());
				}
				else
				{
					nBitsRolled[nextIndex] = int.Parse(bitNumber[i].ToString());
				}
			}
			
			foreach (int bit in nBitsRolled)
			{
				rolledBits += bit;
			}
			
			return rolledBits;
		}
	}
}

