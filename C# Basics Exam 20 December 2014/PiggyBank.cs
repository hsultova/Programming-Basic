using System;

namespace ProgrammingBasicExam
{
	class PiggyBank
	{
		static void Main(string[] args)
		{
			int priceTank = int.Parse(Console.ReadLine());
			int partyDays = int.Parse(Console.ReadLine());

			int normalDays = 30 - partyDays;
			int averageSaves = Math.Abs(normalDays * 2 - partyDays * 5);
			int months = (int)Math.Ceiling((double)priceTank / averageSaves);

			if (partyDays > 8)
			{
				Console.WriteLine("never");
			}
			else
			{
				Console.WriteLine("{0} years, {1} months", months / 12, Math.Ceiling(months % 12.0));
			}
		}
	}
}

