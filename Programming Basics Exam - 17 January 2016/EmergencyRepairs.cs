using System;

namespace ProgrammingExercises
{
	class EmergencyRepairs
	{
		static void Main(string[] args)
		{
			var wall = ulong.Parse(Console.ReadLine());
			var emergencyRepairKit = int.Parse(Console.ReadLine());
			var numberOfAttacks = uint.Parse(Console.ReadLine());

			char[] wallBits = (Convert.ToString((long)wall, 2).PadLeft(64, '0')).ToCharArray();
			int countZeroBit = 0;

			for (int i = 0; i < numberOfAttacks; i++)
			{
				var attack = uint.Parse(Console.ReadLine());

				if (wallBits[63 - attack] == '1')
				{
					wallBits[63 - attack] = '0';
				}
			}

			for (int j = 63; j > 0; j--)
			{
				if (wallBits[j] == '0')
				{
					countZeroBit++;
					if ( countZeroBit >= 2 && (wallBits[j-1] =='1'|| j==1) )
					{
						for (int k = countZeroBit-1; k >=0; k--)
						{
							if (emergencyRepairKit > 0)
							{
								wallBits[j + k] = '1';
							}
							emergencyRepairKit--;
						}
					}
				}
				else
				{
					countZeroBit = 0;
				}
			}

			Console.WriteLine(Convert.ToUInt64(new string(wallBits), 2));
		}
	}
}