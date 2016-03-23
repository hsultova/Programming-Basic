using System;

namespace ProgrammingBasic
{
	class  CakeTycoon
	{
		static void Main(string[] args)
		{
			Int64 numberOfCakes = Int64.Parse(Console.ReadLine());
			double flourNeeded = double.Parse(Console.ReadLine());
			Int64 flour = Int64.Parse(Console.ReadLine());
			Int64 truffles = Int64.Parse(Console.ReadLine());
			Int64 priceTruffle = Int64.Parse(Console.ReadLine());

			double cakesToMake = flour / flourNeeded;

			if (Math.Floor(cakesToMake) >= numberOfCakes)
			{
				Int64 trufflesCost = priceTruffle * truffles;
				double cakePrice = ((double) trufflesCost / numberOfCakes) * 1.25;
				Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
			}
			else
			{
				double totalFlour = numberOfCakes * flourNeeded;
				double kilogramsNeeded = totalFlour - flour;
				Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", Math.Floor(cakesToMake), kilogramsNeeded); 
			}
		}
	}
}