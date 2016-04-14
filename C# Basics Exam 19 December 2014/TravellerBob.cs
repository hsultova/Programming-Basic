using System;

namespace ProgrammingBasicExam
{
	class TravellerBob
	{
		static void Main(string[] args)
		{
			string yearType = Console.ReadLine();
			int contracts = int.Parse(Console.ReadLine());
			int family = int.Parse(Console.ReadLine());

			//Calculate total travels - contracts, family, normal
			double totalTravels = 4 * 3 * contracts + 2 * 2 * family + (12 - contracts - family) * 12 * 3 / 5.0;

			if (yearType == "leap")
			{
				totalTravels *= 1.05;
			}

			Console.WriteLine(Math.Floor(totalTravels));
		}
	}
}

