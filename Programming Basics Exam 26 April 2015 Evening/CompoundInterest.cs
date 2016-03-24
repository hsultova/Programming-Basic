using System;

namespace ProgrammingBasic
{
	class CompoundInterest
	{
		static void Main(string[] args)
		{
			decimal price = decimal.Parse(Console.ReadLine());
			int term = int.Parse(Console.ReadLine());
			decimal rateBank = decimal.Parse(Console.ReadLine());
			decimal rateFriend = decimal.Parse(Console.ReadLine());

			decimal bankLoan = price * (decimal)Math.Pow((1 + (double)rateBank), term);
			decimal friendLoan = price * (1 + rateFriend);

			if (friendLoan <= bankLoan)
			{
				Console.WriteLine("{0:f2} Friend", friendLoan);
			}
			else
			{
				Console.WriteLine("{0:f2} Bank", bankLoan);
			}
		}
	}
}
