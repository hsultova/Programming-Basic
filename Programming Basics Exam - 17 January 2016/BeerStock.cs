using System;

namespace ProgrammingBasic
{
	class BeerStock
	{
		static void Main(string[] args)
		{
			uint reservedBeers = uint.Parse(Console.ReadLine());
			string shipment;
			ulong sumBeers = 0;

			do
			{
				shipment = Console.ReadLine();

				if (shipment.ToLower() == "exam over")
				{
					break;
				}

				ulong amount = ulong.Parse(shipment.Split(' ')[0]);
				string type = shipment.Split(' ')[1];
				
				if (amount >= 0)
				{
					if (type.ToLower() == "beers")
					{
						sumBeers += amount;
					}
					else if (type.ToLower() == "sixpacks")
					{
						sumBeers += amount * 6;
					}
					else if (type.ToLower() == "cases")
					{
						sumBeers += amount * 24;
					}
				}
			}
			while (true);

			sumBeers -= sumBeers / 100;

			if (sumBeers >= reservedBeers)
			{
				ulong leftBeers = sumBeers - reservedBeers;
				ulong cases = leftBeers / 24;
				ulong sixpacks = (leftBeers % 24) / 6;
				ulong beers = (leftBeers % 24) % 6;
				Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
			}
			else
			{
				ulong leftBeers = reservedBeers - sumBeers;
				ulong cases = leftBeers / 24;
				ulong sixpacks = (leftBeers % 24) / 6;
				ulong beers = (leftBeers % 24) % 6;
				Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
			}
		}
	}
}