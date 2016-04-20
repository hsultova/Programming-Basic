using System;

namespace ProgrammingBasicExam
{
	class Electricity
	{
		static void Main(string[] args)
		{
			int floors = int.Parse(Console.ReadLine());
			int flats = int.Parse(Console.ReadLine());
			DateTime time = DateTime.Parse(Console.ReadLine());

			decimal lamps = 100.53m;
			decimal computers = 125.9m;

			if (time >= DateTime.Parse("14:00") && time <= DateTime.Parse("18:59"))
			{
				lamps *= 2;
				computers *= 2;
			}
			else if (time >= DateTime.Parse("19:00") && time <= DateTime.Parse("23:59"))
			{
				lamps *= 7;
				computers *= 6;
			}
			else if (time >= DateTime.Parse("00:00") && time <= DateTime.Parse("08:59"))
			{
				lamps *= 1;
				computers *= 8;
			}
			else
			{
				lamps *= 0;
				computers *= 0;
			}

			decimal watts = floors * flats * (lamps + computers);

			Console.WriteLine("{0} Watts", Math.Floor(watts));

		}
	}
}