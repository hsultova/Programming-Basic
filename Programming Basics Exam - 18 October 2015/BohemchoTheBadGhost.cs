using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class BohemchoTheBadGhost
	{
		static void Main(string[] args)
		{
			int countPoints = 0;
			ulong floor = 0;

			do
			{
				string line =Console.ReadLine();
				string apartments = Console.ReadLine();

				if (line == "Stop, God damn it")
				{
					break;
				}

				floor = ulong.Parse(line);
				int appNumber = 0;
				for (int i = 0; i < apartments.Split(' ').Length; i++)
				{
					appNumber = int.Parse(apartments.Split(' ')[i]);

					if (((floor << appNumber) & 1) == 1)
					{
						ulong mask = ~((ulong)1 << appNumber);
						floor = floor & mask;
					}
					else if (((floor << appNumber) & 1) == 0)
					{
						ulong mask = ((ulong)1 << appNumber);
						floor = floor | mask;
					}
				}

				for (int i = 0; i < 32; i++)
				{
					if (((floor << i) & 1) == 1)
					{
						countPoints++;
					}
				}
			}
			while (true);

			Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", countPoints, floor);

		}
	}
}