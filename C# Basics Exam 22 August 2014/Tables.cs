using System;

namespace ProgrammingBasicExam
{
	class Tables
	{
		static void Main(string[] args)
		{
			long bundle1 = long.Parse(Console.ReadLine());
			long bundle2 = long.Parse(Console.ReadLine());
			long bundle3 = long.Parse(Console.ReadLine());
			long bundle4 = long.Parse(Console.ReadLine());
			long tableTops = long.Parse(Console.ReadLine());
			long tablesToMade = long.Parse(Console.ReadLine());

			long legs = bundle1 * 1 + bundle2 * 2 + bundle3 * 3 + bundle4 * 4;
			long neededLegs = tablesToMade * 4;
			long neededTops = tablesToMade;

			if (neededLegs < legs && neededTops < tableTops)
			{
				Console.WriteLine("more: {0}", tableTops - neededTops);
				Console.WriteLine("tops left: {0}, legs left: {1}", tableTops - neededTops, legs - neededLegs);
			}
			else if (neededTops == tableTops)
			{
				Console.WriteLine("Just enough tables made: {0}", tableTops);
			}
			else
			{
				Console.WriteLine("less: {0}", tableTops - neededTops);
				Console.WriteLine("tops needed: {0}, legs needed: {1}", neededTops - tableTops, (neededLegs - legs) < 0 ? 0 : neededLegs - legs);
			}
		}
	}
}